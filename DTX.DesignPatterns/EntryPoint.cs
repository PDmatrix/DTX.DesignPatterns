using System;
using System.Globalization;
using System.Linq;
using System.Reflection;
using DTX.DesignPatterns.Definition;
using DTX.DesignPatterns.Extensions;
using Mono.Options;

namespace DTX.DesignPatterns
{
    public static class EntryPoint
    {
        private static readonly OptionSet OptionSet = new OptionSet
        {
            {"l|list:", "list of all or {patterntype} patterns", PrintPatterns},
            {"p|pattern=", "execute {pattern}", v => PatternFactory.Create(v).Excecute()},
            {
                "d|description=", "description of the {pattern}.",
                v => Console.WriteLine(PatternFactory.Create(v).Description())
            },
            {"lang=", "{language} of the program", ChangeLanguage},
            {"?|h|help", "show help", v => ShowHelp()}
        };

        private static void Main(string[] args)
        {
            try
            {
                OptionSet.Parse(args);
            }
            catch (OptionException e)
            {
                Console.Write(@"DTX.DesignPatterns: ");
                Console.WriteLine(e.Message);
                Console.WriteLine(@"Try 'DTX.DesignPatterns --help' for more information.");
            }
        }

        private static void ShowHelp()
        {
            OptionSet.WriteOptionDescriptions(Console.Out);
        }

        private static void ChangeLanguage(string lang)
        {
            CultureInfo.DefaultThreadCurrentUICulture = CultureInfo.GetCultureInfo(lang.ToLowerInvariant());
        }

        private static void PrintPatterns(string patternTypeName)
        {
            var patterns = Assembly.GetExecutingAssembly().GetTypes().Where(r => r.BaseType == typeof(Pattern));

            var patternClasses = patterns.Select(r => PatternFactory.Create(r.Name)).ToArray();

            // Get pattern type if patternTypeName is specified. Otherwise, get all the types
            var patternTypes = patternClasses
                .Where(r => patternTypeName == null || string.Equals(r.PatternType.GetType().Name,
                                patternTypeName.RemoveWhiteSpace(),
                                StringComparison.CurrentCultureIgnoreCase))
                .Select(r => r.PatternType)
                .GroupBy(x => x.PatternType)
                .Select(g => g.First());

            foreach (var patternType in patternTypes)
            {
                Console.WriteLine($@"{patternType.PatternType}:");
                patternClasses.Where(r => r.PatternType.PatternType == patternType.PatternType)
                    .ToList()
                    .ForEach(r => Console.WriteLine($@"	{r.PatternName}"));
                Console.WriteLine();
            }
        }
    }
}

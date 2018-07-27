using System;
using System.Globalization;
using System.Linq;
using System.Reflection;
using DTX.DesignPatterns.Definition;
using Mono.Options;

namespace DTX.DesignPatterns
{
    public static class EntryPoint
    {
        private static readonly OptionSet OptionSet = new OptionSet {
            { "l|list:", "list of all or {patterntype} patterns", PrintPatterns },
            { "p|pattern=", "execute {pattern}", v=> PatternFactory.Create(v).Excecute() },
            { "d|description=", "description of the {pattern}.",
                v => Console.WriteLine(PatternFactory.Create(v).Description()) },
            { "lang=", "{language} of the program", ChangeLanguage },
            { "?|h|help", "show help", v => ShowHelp() }
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

            var patternTypes = Assembly.GetExecutingAssembly().GetTypes().Where(r => 
                patternTypeName != null ? r.Name == patternTypeName : r.BaseType == typeof(Pattern));//r.BaseType == typeof(Pattern));
            foreach (var patternType in patternTypes)
            {
                var concretePatterns =
                    Assembly.GetExecutingAssembly().GetTypes().Where(r => r.BaseType == patternType).ToArray();

                Console.WriteLine(
                    $@"{PatternFactory.Create(concretePatterns.First().Name).PatternType}:");
                foreach (var pattern in concretePatterns)
                {
                    Console.WriteLine(
                        $@"   {PatternFactory.Create(pattern.Name).PatternName}");
                }
                Console.WriteLine();
            }
        }
    }
}

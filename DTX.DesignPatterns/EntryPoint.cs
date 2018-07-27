using System;
using System.Globalization;
using System.Linq;
using System.Reflection;
using DTX.DesignPatterns.Definition;
using NDesk.Options;

namespace DTX.DesignPatterns
{
    public static class EntryPoint
    {
        private static readonly OptionSet OptionSet = new OptionSet {
            { "l|list", "list of patterns", v => PrintPatterns()},
            { "c|concretelist=", "list of {PATTERNTYPE}", PrintPatterns},
            { "p|pattern=", "execute {PATTERN}", v=> PatternFactory.Create(v).Excecute() },
            { "d|description=", "description of the {PATTERN}. If {PATTERN} contains whitespaces, you should type it in one word",
                v => Console.WriteLine(PatternFactory.Create(v).Description()) },
            { "lang=", "{LANGUAGE} of the program", ChangeLanguage },
            { "h|help", "show help", v=> ShowHelp() }
        };

        private static void Main(string[] args)
        {
            try
            {
                OptionSet.Parse(args);
                Console.ReadKey();
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

        private static void PrintPatterns()
        {
            var patternTypes = Assembly.GetExecutingAssembly().GetTypes().Where(r => r.BaseType == typeof(Pattern));
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

        private static void PrintPatterns(string patternTypeName)
        {
            var patternType = 
                Assembly.GetEntryAssembly().GetTypes().First(r => r.Name == patternTypeName);

            var concretePatterns = 
                Assembly.GetExecutingAssembly().GetTypes().Where(r => r.IsSubclassOf(patternType)).ToArray();

            Console.WriteLine(
                $@"{PatternFactory.Create(concretePatterns.First().Name).PatternType}:");
            foreach (var pattern in concretePatterns)
            {
                Console.WriteLine(
                    $@"	{PatternFactory.Create(pattern.Name).PatternName}");
            }
            Console.WriteLine();
        }
    }
}

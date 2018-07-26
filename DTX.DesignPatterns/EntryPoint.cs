using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using DTX.DesignPatterns.Definition;
using NDesk.Options;

namespace DTX.DesignPatterns
{
    internal static class EntryPoint
    {
        private static readonly OptionSet OptionSet = new OptionSet {
            { "l|list", "list of patterns", v => PrintPatterns()},
            { "c|concretelist=", "list of {PATTERNTYPE}", PrintPatterns},
            { "p|pattern=", "execute {PATTERN}", v=> PatternFactory.Create(v).Excecute() },
            { "d|description=", "description fo the {PATTERN}", v=> Console.WriteLine(PatternFactory.Create(v).Description()) },
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

        private static void PrintPatterns()
        {
            var patternTypes = Assembly.GetExecutingAssembly().GetTypes().Where(r => r.BaseType == typeof(Pattern));
            foreach (var patternType in patternTypes)
            {
                var concretePatterns =
                    Assembly.GetExecutingAssembly().GetTypes().Where(r => r.BaseType == patternType);
                Console.WriteLine($@"{patternType.Name}:");
                foreach (var pattern in concretePatterns)
                {
                    Console.WriteLine($@"   {((Pattern)Activator.CreateInstance(pattern, args: new Dictionary<string, string>())).PatternName}");
                }
                Console.WriteLine();
            }
        }

        private static void PrintPatterns(string patternType)
        {
            var concretePatterns = Assembly.GetExecutingAssembly().GetTypes().Where(r => r.BaseType?.Name == patternType);
            Console.WriteLine($@"{patternType}:");
            foreach (var pattern in concretePatterns)
            {
                Console.WriteLine(
                    $@"	{((Pattern) Activator.CreateInstance(pattern, args: new Dictionary<string, string>())).PatternName}");
            }

            Console.WriteLine();
        }
    }
}

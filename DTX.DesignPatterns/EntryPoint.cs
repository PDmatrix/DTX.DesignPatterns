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
        private static void Main(string[] args)
        {
            var showHelp = false;

            var optionSet = new OptionSet() {
                { "l|list", "list of patterns", v => ShowListOfPatterns()},
                { "tl|typelist", "list of type patterns", v => ShowListOfTypePatterns() },
                { "h|help", "show help", v => showHelp = v != null }
                /*{ "n|name=", "the {NAME} of someone to greet.",
                    v => names.Add (v) },
                { "r|repeat=",
                    "the number of {TIMES} to repeat the greeting.\n" +
                    "this must be an integer.",
                    (int v) => repeat = v },
                { "v", "increase debug message verbosity",
                    v => { if (v != null) ++verbosity; } },
                { "h|help",  "show this message and exit",
                    v => show_help = v != null },*/
            };

            List<string> extra;
            try
            {
                extra = optionSet.Parse(args);
            }
            catch (OptionException e)
            {
                Console.Write(@"DTX.DesignPatterns: ");
                Console.WriteLine(e.Message);
                Console.WriteLine(@"Try 'DTX.DesignPatterns --help' for more information.");
                return;
            }

            if (!showHelp) return;
            ShowHelp(optionSet);
            //optionSet.WriteOptionDescriptions(Console.Out);
            //var dictionary = ParseArgs(args);
            // var pattern = PatternFactory.Create(dictionary);
            //Console.WriteLine(pattern.PatternType);
            //Console.WriteLine(pattern.Description());
            //pattern.Excecute();
        }

        private static void ShowHelp(OptionSet optionSet)
        {
            optionSet.WriteOptionDescriptions(Console.Out);
        }

        private static void ShowListOfPatterns()
        {
            foreach (var patternName in GetPatterns())
            {
                Console.WriteLine(patternName);
            }
        }

        private static void ShowListOfTypePatterns()
        {
            foreach (var patternType in GetPatternTypes())
            {
                Console.WriteLine(patternType);
            }
        }

        private static IEnumerable<string> GetPatternTypes()
        {
            var patternTypes = Assembly.GetExecutingAssembly().GetTypes().Where(r => r.BaseType == typeof(Pattern));
            return patternTypes.Select(patternType => (string) patternType.GetField("PatternTypeName").GetRawConstantValue()).ToList();
        }

        private static IEnumerable<string> GetPatterns()
        {
            var patternNames = Assembly.GetExecutingAssembly().GetTypes().Where(r => r.IsSubclassOf(typeof(Pattern)) && r.BaseType != typeof(Pattern));
            return patternNames.Select(patternName => ((Pattern) Activator.CreateInstance(patternName, args: new Dictionary<string, string>())).PatternName).ToList();
        }
    }
}

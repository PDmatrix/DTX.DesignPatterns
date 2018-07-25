using System;
using System.Collections.Generic;
using System.Linq;
using DTX.DesignPatterns.Definition;

namespace DTX.DesignPatterns
{
    internal static class EntryPoint
    {
        private static void Main(string[] args)
        {
            var dictionary = ParseArgs(args);
            var pattern = PatternFactory.Create(dictionary);
            Console.WriteLine(pattern.PatternType);
            //Console.WriteLine(pattern.Description());
            //pattern.Excecute();
            Console.ReadKey();
        }

        private static Dictionary<string, string> ParseArgs(IEnumerable<string> args)
        {
            return args
                .Distinct()
                .Select(arg => arg.Split('='))
                .ToDictionary(pair => pair[0].ToUpperInvariant(),
                    pair => pair.Length > 1 ? string.Join("=", pair.Skip(1)) : "");
        }
    }
}

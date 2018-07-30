using System;
using System.Collections.Generic;
using DTX.DesignPatterns.Definition;
using DTX.DesignPatterns.Definition.PatternTypes;
using DTX.DesignPatterns.Properties;

namespace DTX.DesignPatterns.Patterns.Prototype
{
    public class Prototype : Pattern
    {
        private static readonly string PatternNameStr = Properties.PatternName.PrototypeName;

        public Prototype(IDictionary<string, string> args)
        {
            PatternName = PatternNameStr;
            PatternType = new CreationalPattern();
        }

        public override void Excecute()
        {
            Console.WriteLine($@"{PatternNameStr}:{Environment.NewLine}");
            ClassicPrototype.Start();
        }

        public override string Description()
        {
            return $"{PatternNameStr}: {Environment.NewLine}\t{PatternDescription.PrototypeDescription}";
        }
    }
}
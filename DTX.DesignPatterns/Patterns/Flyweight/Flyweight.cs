using System;
using System.Collections.Generic;
using DTX.DesignPatterns.Definition.PatternTypes;
using DTX.DesignPatterns.Properties;

namespace DTX.DesignPatterns.Patterns.Flyweight
{
    public class Flyweight : StructuralPattern
    {
        private static readonly string PatternNameStr = Properties.PatternName.FlyweightName;

        public Flyweight(IDictionary<string, string> args)
        {
            PatternName = PatternNameStr;
        }

        public override void Excecute()
        {
            throw new System.NotImplementedException();
        }

        public override string Description()
        {
            return $"{PatternNameStr}: {Environment.NewLine}\t{PatternDescription.FlyweightDescription}";
        }
    }
}
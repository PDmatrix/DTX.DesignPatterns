using System;
using System.Collections.Generic;
using DTX.DesignPatterns.Definition;
using DTX.DesignPatterns.Definition.PatternTypes;
using DTX.DesignPatterns.Properties;

namespace DTX.DesignPatterns.Patterns.Decorator
{
    public class Decorator : Pattern
    {
        private static readonly string PatternNameStr = Properties.PatternName.DecoratorName;

        public Decorator(IDictionary<string, string> args)
        {
            PatternName = PatternNameStr;
            PatternType = new StructuralPattern();
        }

        public override void Excecute()
        {
            throw new System.NotImplementedException();
        }

        public override string Description()
        {
            return $"{PatternNameStr}: {Environment.NewLine}\t{PatternDescription.DecoratorDescription}";
        }
    }
}
using System;
using System.Collections.Generic;
using DTX.DesignPatterns.Definition;
using DTX.DesignPatterns.Definition.PatternTypes;
using DTX.DesignPatterns.Properties;

namespace DTX.DesignPatterns.Patterns.Abstract_Factory
{
    public class AbstractFactory : Pattern
    {
        private static readonly string PatternNameStr = Properties.PatternName.AbstractFactoryName;

        public AbstractFactory(IDictionary<string, string> args)
        {
            PatternName = PatternNameStr;
            PatternType = new CreationalPattern();
        }

        public override void Excecute()
        {
            throw new NotImplementedException();
        }

        public override string Description()
        {
            return $"{PatternNameStr}: {Environment.NewLine}\t{PatternDescription.AbstractFactoryDescription}";
        }
    }
}
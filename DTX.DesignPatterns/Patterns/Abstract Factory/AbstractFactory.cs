using System;
using System.Collections.Generic;
using DTX.DesignPatterns.Definition.PatternTypes;
using DTX.DesignPatterns.Properties;

namespace DTX.DesignPatterns.Patterns.Abstract_Factory
{
    public class AbstractFactory : CreationalPattern
    {
        private static readonly string PatternNameStr = Properties.PatternName.AbstractFactoryName;

        public AbstractFactory(IDictionary<string, string> args)
        {
            PatternName = PatternNameStr;
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
using System;
using System.Collections.Generic;
using DTX.DesignPatterns.Definition;
using DTX.DesignPatterns.Definition.PatternTypes;
using DTX.DesignPatterns.Properties;

namespace DTX.DesignPatterns.Patterns.Factory_Method
{
   
    public class FactoryMethod : Pattern
    {
        private readonly string _patternNameStr = Properties.PatternName.FactoryMethodName;

        public FactoryMethod(IDictionary<string, string> args)
        {
            PatternName = _patternNameStr;
            PatternType = new CreationalPattern();
        }

        public override void Excecute()
        {
            Console.WriteLine($@"{_patternNameStr}:" + Environment.NewLine);
            ClassicFactoryMethod.Start();
        }

        public override string Description()
        {
            return $"{_patternNameStr}: {Environment.NewLine}\t{PatternDescription.FactoryMethodDescription}";
        }
    }
}
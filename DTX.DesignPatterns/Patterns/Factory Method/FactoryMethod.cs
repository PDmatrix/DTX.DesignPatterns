using System;
using System.Collections.Generic;
using DTX.DesignPatterns.Definition.PatternTypes;

namespace DTX.DesignPatterns.Patterns.Factory_Method
{
    public class FactoryMethod : CreationalPattern
    {
        private const string PatternNameStr = "Factory method";

        public FactoryMethod(IDictionary<string, string> args)
        {
            PatternName = PatternNameStr;
        }

        public override void Excecute()
        {
            Console.WriteLine("Excecute");
        }

        public override string Description()
        {
            return "Description";
        }
    }
}
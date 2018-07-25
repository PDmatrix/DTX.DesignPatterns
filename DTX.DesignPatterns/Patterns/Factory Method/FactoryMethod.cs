using System;
using System.Collections.Generic;
using DTX.DesignPatterns.Definition.PatternTypes;

namespace DTX.DesignPatterns.Patterns.Factory_Method
{
    public class FactoryMethod : CreationalPattern
    {
        public FactoryMethod(IDictionary<string, string> args)
        {
            
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
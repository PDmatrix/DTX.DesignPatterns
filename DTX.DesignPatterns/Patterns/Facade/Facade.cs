using System;
using System.Collections.Generic;
using DTX.DesignPatterns.Definition;
using DTX.DesignPatterns.Definition.PatternTypes;
using DTX.DesignPatterns.Properties;

namespace DTX.DesignPatterns.Patterns.Facade
{
    public class Facade : Pattern
    {
        private static readonly string PatternNameStr = Properties.PatternName.FacadeName;

        public Facade(IDictionary<string, string> args)
        {
            PatternName = PatternNameStr;
            PatternType = new StructuralPattern();
        }

        public override void Excecute()
        {
            Console.WriteLine($@"{PatternNameStr}:{Environment.NewLine}");
            ClassicFacade.Start();
        }

        public override string Description()
        {
            return $"{PatternNameStr}: {Environment.NewLine}\t{PatternDescription.FacadeDescription}";
        }
    }
}
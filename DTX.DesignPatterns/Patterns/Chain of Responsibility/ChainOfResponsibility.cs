using System;
using System.Collections.Generic;
using DTX.DesignPatterns.Definition;
using DTX.DesignPatterns.Definition.PatternTypes;
using DTX.DesignPatterns.Properties;

namespace DTX.DesignPatterns.Patterns.Chain_of_Responsibility
{
    public class ChainOfResponsibility : Pattern
    {
        private static readonly string PatternNameStr = Properties.PatternName.ChainOfResponsibilityName;

        public ChainOfResponsibility(IDictionary<string, string> args)
        {
            PatternName = PatternNameStr;
            PatternType = new BehavioralPattern();
        }

        public override void Excecute()
        {
            Console.WriteLine($@"{PatternNameStr}:{Environment.NewLine}");
            ClassicChainOfResponsibility.Start();
        }

        public override string Description()
        {
            return $"{PatternNameStr}: {Environment.NewLine}\t{PatternDescription.ChainOfResponsibilityDescription}";
        }
    }
}
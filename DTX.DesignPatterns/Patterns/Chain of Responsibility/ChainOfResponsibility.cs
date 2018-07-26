using System;
using System.Collections.Generic;
using DTX.DesignPatterns.Definition.PatternTypes;
using DTX.DesignPatterns.Properties;

namespace DTX.DesignPatterns.Patterns.Chain_of_Responsibility
{
    public class ChainOfResponsibility : BehavioralPattern
    {
        private const string PatternNameStr = "Chain of responsibility";

        public ChainOfResponsibility(IDictionary<string, string> args)
        {
            PatternName = PatternNameStr;
        }

        public override void Excecute()
        {
            throw new System.NotImplementedException();
        }

        public override string Description()
        {
            return $"{PatternNameStr}: {Environment.NewLine}\t{PatternDescription.ChainOfResponsibilityDescription}";
        }
    }
}
using System;
using System.Collections.Generic;
using DTX.DesignPatterns.Definition;
using DTX.DesignPatterns.Definition.PatternTypes;
using DTX.DesignPatterns.Properties;

namespace DTX.DesignPatterns.Patterns.Mediator
{
    public class Mediator : Pattern
    {
        private static readonly string PatternNameStr = Properties.PatternName.MediatorName;

        public Mediator(IDictionary<string, string> args)
        {
            PatternName = PatternNameStr;
            PatternType = new BehavioralPattern();
        }

        public override void Excecute()
        {
            throw new System.NotImplementedException();
        }

        public override string Description()
        {
            return $"{PatternNameStr}: {Environment.NewLine}\t{PatternDescription.MediatorDescription}";
        }
    }
}
using System;
using System.Collections.Generic;
using DTX.DesignPatterns.Definition;
using DTX.DesignPatterns.Definition.PatternTypes;
using DTX.DesignPatterns.Properties;

namespace DTX.DesignPatterns.Patterns.Visitor
{
    public class Visitor : Pattern
    {
        private static readonly string PatternNameStr = Properties.PatternName.VisitorName;

        public Visitor(IDictionary<string, string> args)
        {
            PatternName = PatternNameStr;
            PatternType = new BehavioralPattern();
        }

        public override void Excecute()
        {
            throw new NotImplementedException();
        }

        public override string Description()
        {
            return $"{PatternNameStr}: {Environment.NewLine}\t{PatternDescription.VisitorDescription}";
        }
    }
}
using System;
using System.Collections.Generic;
using DTX.DesignPatterns.Definition.PatternTypes;
using DTX.DesignPatterns.Properties;

namespace DTX.DesignPatterns.Patterns.Observer
{
    public class Observer : BehavioralPattern
    {
        private static readonly string PatternNameStr = Properties.PatternName.ObserverName;

        public Observer(IDictionary<string, string> args)
        {
            PatternName = PatternNameStr;
        }

        public override void Excecute()
        {
            throw new NotImplementedException();
        }

        public override string Description()
        {
            return $"{PatternNameStr}: {Environment.NewLine}\t{PatternDescription.ObserverDescripton}";
        }
    }
}
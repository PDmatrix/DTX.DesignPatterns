using System;
using System.Collections.Generic;
using DTX.DesignPatterns.Definition.PatternTypes;
using DTX.DesignPatterns.Properties;

namespace DTX.DesignPatterns.Patterns.State
{
    public class State : BehavioralPattern
    {
        private readonly string _patternNameStr = Properties.PatternName.StateName;

        public State(IDictionary<string, string> args)
        {
            PatternName = _patternNameStr;
        }

        public override void Excecute()
        {
            throw new NotImplementedException();
        }

        public override string Description()
        {
            return $"{_patternNameStr}: {Environment.NewLine}\t{PatternDescription.StateDescription}";
        }
    }
}
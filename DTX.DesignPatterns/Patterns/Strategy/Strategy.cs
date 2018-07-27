using System;
using System.Collections.Generic;
using DTX.DesignPatterns.Definition.PatternTypes;
using DTX.DesignPatterns.Properties;

namespace DTX.DesignPatterns.Patterns.Strategy
{
    public class Strategy : BehavioralPattern
    {
        private readonly string _patternNameStr = Properties.PatternName.StrategyName;

        public Strategy(IDictionary<string, string> args)
        {
            PatternName = _patternNameStr;
        }

        public override void Excecute()
        {
            throw new NotImplementedException();
        }

        public override string Description()
        {
            return $"{_patternNameStr}: {Environment.NewLine}\t{PatternDescription.StrategyDescription}";
        }
    }
}
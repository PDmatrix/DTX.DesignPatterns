using System;
using System.Collections.Generic;
using DTX.DesignPatterns.Definition;
using DTX.DesignPatterns.Definition.PatternTypes;
using DTX.DesignPatterns.Properties;

namespace DTX.DesignPatterns.Patterns.Bridge
{
    public class Bridge : Pattern
    {
        private static readonly string PatternNameStr = Properties.PatternName.BridgeName;

        public Bridge(IDictionary<string, string> args)
        {
            PatternName = PatternNameStr;
            PatternType = new CreationalPattern();
        }

        public override void Excecute()
        {
            throw new System.NotImplementedException();
        }

        public override string Description()
        {
            return $"{PatternNameStr}: {Environment.NewLine}\t{PatternDescription.BridgeDescription}";
        }
    }
}
using System;
using System.Collections.Generic;
using DTX.DesignPatterns.Definition.PatternTypes;
using DTX.DesignPatterns.Properties;

namespace DTX.DesignPatterns.Patterns.Proxy
{
    public class Proxy : StructuralPattern
    {
        private readonly string _patternNameStr = Properties.PatternName.ProxyName;

        public Proxy(IDictionary<string, string> args)
        {
            PatternName = _patternNameStr;
        }

        public override void Excecute()
        {
            throw new NotImplementedException();
        }

        public override string Description()
        {
            return $"{_patternNameStr}: {Environment.NewLine}\t{PatternDescription.ProxyDescription}";
        }
    }
}
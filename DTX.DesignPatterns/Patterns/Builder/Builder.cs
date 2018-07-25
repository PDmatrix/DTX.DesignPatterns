using System.Collections.Generic;
using DTX.DesignPatterns.Definition.PatternTypes;

namespace DTX.DesignPatterns.Patterns.Builder
{
    public class Builder : CreationalPattern
    {
        private const string PatternNameStr = "Builder";

        public Builder(IDictionary<string, string> args)
        {
            PatternName = PatternNameStr;
        }

        public override void Excecute()
        {
            throw new System.NotImplementedException();
        }

        public override string Description()
        {
            throw new System.NotImplementedException();
        }
    }
}
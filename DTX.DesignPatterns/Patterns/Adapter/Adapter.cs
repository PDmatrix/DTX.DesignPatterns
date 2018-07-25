using System.Collections.Generic;
using DTX.DesignPatterns.Definition.PatternTypes;

namespace DTX.DesignPatterns.Patterns.Adapter
{
    public class Adapter : StructuralPattern
    {
        private const string PatternNameStr = "Adapter";

        public Adapter(IDictionary<string, string> args)
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
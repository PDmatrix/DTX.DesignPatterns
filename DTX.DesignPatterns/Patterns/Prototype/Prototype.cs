using System.Collections.Generic;
using DTX.DesignPatterns.Definition;
using DTX.DesignPatterns.Definition.PatternTypes;

namespace DTX.DesignPatterns.Patterns.Prototype
{
    public class Prototype : CreationalPattern
    {
        private const string PatternNameStr = "Prototype";

        public Prototype(IDictionary<string, string> args)
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
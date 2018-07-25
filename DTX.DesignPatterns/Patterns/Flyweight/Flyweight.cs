using System.Collections.Generic;
using DTX.DesignPatterns.Definition.PatternTypes;

namespace DTX.DesignPatterns.Patterns.Flyweight
{
    public class Flyweight : StructuralPattern
    {
        private const string PatternNameStr = "Flyweight";

        public Flyweight(IDictionary<string, string> args)
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
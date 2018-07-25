using System.Collections.Generic;
using DTX.DesignPatterns.Definition.PatternTypes;

namespace DTX.DesignPatterns.Patterns.Iterator
{
    public class Iterator : BehavioralPattern
    {
        private const string PatternNameStr = "Iterator";

        public Iterator(IDictionary<string, string> args)
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
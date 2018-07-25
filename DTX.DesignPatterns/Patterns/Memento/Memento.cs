using System.Collections.Generic;
using DTX.DesignPatterns.Definition.PatternTypes;

namespace DTX.DesignPatterns.Patterns.Memento
{
    public class Memento : BehavioralPattern
    {
        private const string PatternNameStr = "Memento";

        public Memento(IDictionary<string, string> args)
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
using System;
using System.Collections.Generic;
using DTX.DesignPatterns.Definition;
using DTX.DesignPatterns.Definition.PatternTypes;
using DTX.DesignPatterns.Properties;

namespace DTX.DesignPatterns.Patterns.Memento
{
    public class Memento : Pattern
    {
        private static readonly string PatternNameStr = Properties.PatternName.MementoName;

        public Memento(IDictionary<string, string> args)
        {
            PatternName = PatternNameStr;
            PatternType = new BehavioralPattern();
        }

        public override void Excecute()
        {
            Console.WriteLine($@"{PatternNameStr}:{Environment.NewLine}");
        }

        public override string Description()
        {
            return $"{PatternNameStr}: {Environment.NewLine}\t{PatternDescription.MementoDescription}";
        }
    }
}
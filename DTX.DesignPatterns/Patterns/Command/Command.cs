using System;
using System.Collections.Generic;
using DTX.DesignPatterns.Definition;
using DTX.DesignPatterns.Definition.PatternTypes;
using DTX.DesignPatterns.Properties;

namespace DTX.DesignPatterns.Patterns.Command
{
    public class Command : Pattern
    {
        private static readonly string PatternNameStr = Properties.PatternName.CommandName;

        public Command(IDictionary<string, string> args)
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
            return $"{PatternNameStr}: {Environment.NewLine}\t{PatternDescription.CommandDescription}";
        }
    }
}
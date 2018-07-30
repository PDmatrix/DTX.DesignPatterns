using System;
using System.Collections.Generic;
using DTX.DesignPatterns.Definition;
using DTX.DesignPatterns.Definition.PatternTypes;
using DTX.DesignPatterns.Properties;

namespace DTX.DesignPatterns.Patterns.Interpreter
{
    public class Interpreter : Pattern
    {
        private static readonly string PatternNameStr = Properties.PatternName.InterpreterName;

        public Interpreter(IDictionary<string, string> args)
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
            return $"{PatternNameStr}: {Environment.NewLine}\t{PatternDescription.InterpreterDescription}";
        }
    }
}
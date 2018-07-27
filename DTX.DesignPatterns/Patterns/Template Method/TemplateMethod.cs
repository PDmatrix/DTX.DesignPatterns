using System;
using System.Collections.Generic;
using DTX.DesignPatterns.Definition.PatternTypes;
using DTX.DesignPatterns.Properties;

namespace DTX.DesignPatterns.Patterns.Template_Method
{
    public class TemplateMethod : BehavioralPattern
    {
        private readonly string _patternNameStr = Properties.PatternName.TemplateMethodName;

        public TemplateMethod(IDictionary<string, string> args)
        {
            PatternName = _patternNameStr;
        }

        public override void Excecute()
        {
            throw new System.NotImplementedException();
        }

        public override string Description()
        {
            return $"{_patternNameStr}: {Environment.NewLine}\t{PatternDescription.TemplateMethodDescription}";
        }
    }
}
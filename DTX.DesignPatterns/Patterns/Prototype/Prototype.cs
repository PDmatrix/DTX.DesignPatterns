﻿using System;
using System.Collections.Generic;
using DTX.DesignPatterns.Definition.PatternTypes;
using DTX.DesignPatterns.Properties;

namespace DTX.DesignPatterns.Patterns.Prototype
{
    public class Prototype : CreationalPattern
    {
        private readonly string _patternNameStr = Properties.PatternName.PrototypeName;

        public Prototype(IDictionary<string, string> args)
        {
            PatternName = _patternNameStr;
        }

        public override void Excecute()
        {
            throw new System.NotImplementedException();
        }

        public override string Description()
        {
            return $"{_patternNameStr}: {Environment.NewLine}\t{PatternDescription.PrototypeDescription}";
        }
    }
}
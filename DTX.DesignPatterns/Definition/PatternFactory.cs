using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace DTX.DesignPatterns.Definition
{
    public static class PatternFactory
    {
        public static Pattern Create(string pattern)
        {
            var patternType = Assembly.GetExecutingAssembly().GetTypes().First(r => r.Name == pattern);
            return (Pattern)Activator.CreateInstance(patternType, new Dictionary<string, string>());
        }
    }
}
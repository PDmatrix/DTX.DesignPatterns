using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace DTX.DesignPatterns.Definition
{
    public static class PatternFactory
    {
        public static Pattern Create(IDictionary<string, string> args)
        {
            var patternType = Assembly.GetExecutingAssembly().GetTypes().First(r => r.Name == args["PATTERN"]);
            return (Pattern)Activator.CreateInstance(patternType, args);
        }
    }
}
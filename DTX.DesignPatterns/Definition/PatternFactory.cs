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
            pattern = PatternNameIntoOneWord(pattern);
            var patternType = Assembly.GetExecutingAssembly().GetTypes()
                .First(r => string.Equals(r.Name, pattern, StringComparison.CurrentCultureIgnoreCase));
            return (Pattern)Activator.CreateInstance(patternType, new Dictionary<string, string>());
        }

        private static string PatternNameIntoOneWord(string pattern)
        {
            return pattern.Replace(" ", "");
        }
    }
}
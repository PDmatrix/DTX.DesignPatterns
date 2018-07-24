using System;
using System.Linq;
using System.Reflection;

namespace DTX.DesignPatterns
{
    public static class PatternFactory
    {
        public static Pattern Create(object[] args)
        {
            var patternType = Assembly.GetExecutingAssembly().GetTypes().First(r => r.Name == (string) "FactoryMethod");
            return (Pattern)Activator.CreateInstance(patternType, args);
        }
    }
}
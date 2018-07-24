using System;

namespace DTX.DesignPatterns
{
    internal class EntryPoint
    {
        private static void Main(string[] args)
        {

            var a = PatternFactory.Create(args);
        }
    }
}

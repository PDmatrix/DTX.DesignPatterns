using System;
using System.Collections.Generic;
using DTX.DesignPatterns.Definition;
using DTX.DesignPatterns.Definition.PatternTypes;
using DTX.DesignPatterns.Properties;

namespace DTX.DesignPatterns.Patterns.Singleton
{
    public class Singleton : Pattern
    {
        private static readonly string PatternNameStr = Properties.PatternName.SingletonName;

        public Singleton(IDictionary<string, string> args)
        {
            PatternName = PatternNameStr;
            PatternType = new CreationalPattern();
        }
        

        public override void Excecute()
        {
            Console.WriteLine($@"{PatternNameStr}:{Environment.NewLine}");

            #region The First Way

            Console.WriteLine(@"The first way");
            LazySingleton.Start();
            #endregion

            #region The Second Way

            Console.WriteLine($@"{Environment.NewLine}The second way");
            AmbientContext.Start();
            Console.WriteLine(AmbientContext.GlobalLogger.Logger);

            #endregion
        }

        public override string Description()
        {
            return $"{PatternNameStr}: {Environment.NewLine}\t{PatternDescription.SingletonDescription}";
        }
    }
}
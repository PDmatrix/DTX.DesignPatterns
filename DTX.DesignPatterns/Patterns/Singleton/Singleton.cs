using System;
using System.Collections.Generic;
using DTX.DesignPatterns.Definition.PatternTypes;
using DTX.DesignPatterns.Properties;

namespace DTX.DesignPatterns.Patterns.Singleton
{
    public sealed class Logger
    {
        private static readonly Logger Instance = new Logger();


        private Logger()
        {
        }

        public static Logger GetInstance()
        {
            return Instance;
        }

        public static void LogToConsole()
        {
            Console.WriteLine(@"Logging into console...");
        }

        public static void LogToFile()
        {
            Console.WriteLine(@"Logging into file...");
        }
    }

    public class Singleton : CreationalPattern
    {
        private const string PatternNameStr = "Singleton";

        public Singleton(IDictionary<string, string> args)
        {
            PatternName = PatternNameStr;
        }

        public override void Excecute()
        {
            Console.WriteLine(@"Singleton:" + Environment.NewLine);
            var logger = Logger.GetInstance();
            Logger.LogToConsole();
            Logger.LogToFile();
            var newLogger = Logger.GetInstance();
            Console.WriteLine($@"logger == newLogger : {logger == newLogger}");
        }

        public override string Description()
        {
            return Resources.SingletonDescription;
        }
    }
}
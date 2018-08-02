using System;
using System.Threading;

namespace DTX.DesignPatterns.Patterns.Singleton
{
    public static class LazySingleton
    {
        public sealed class Logger
        {
            private static readonly Lazy<Logger> Instance = new Lazy<Logger>(() => new Logger());

            private Logger()
            {
            }

            public static Logger GetInstance()
            {
                return Instance.Value;
            }

            public void LogToConsole()
            {
                Console.WriteLine(@"Logging into console...");
            }

            public void LogToFile()
            {
                Console.WriteLine(@"Logging into file...");
            }
        }

        public static void Start()
        {
            var logger = Logger.GetInstance();
            logger.LogToConsole();

            var newLogger = Logger.GetInstance();
            newLogger.LogToFile();
            Console.WriteLine($@"logger == newLogger : {logger == newLogger}");
        }
    }
}
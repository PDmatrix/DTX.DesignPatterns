using System;

namespace DTX.DesignPatterns.Patterns.Singleton
{
    public static class AmbientContext
    {
        private interface ILogger
        {
            void Write();
        }

        private class FileLogger : ILogger
        {
            public void Write()
            {
                Console.WriteLine(@"Logging into file...");
            }
        }

        private class ConsoleLogger : ILogger
        {
            public void Write()
            {
                Console.WriteLine(@"Logging into console...");
            }
        }

        private static class GlobalLogger
        {
            public static ILogger Logger { get; internal set; } = new ConsoleLogger();
        }

        public static void Start()
        {
            Console.WriteLine(GlobalLogger.Logger);
            GlobalLogger.Logger.Write();
            GlobalLogger.Logger = new FileLogger();
            Console.WriteLine(GlobalLogger.Logger);
            GlobalLogger.Logger.Write();
        }
    }
}
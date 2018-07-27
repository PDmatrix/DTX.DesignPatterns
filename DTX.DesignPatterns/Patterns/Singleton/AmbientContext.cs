using System;

namespace DTX.DesignPatterns.Patterns.Singleton
{
    public class AmbientContext
    {
        public interface ILogger
        {
            void Write();
        }

        public class FileLogger : ILogger
        {
            public void Write()
            {
                Console.WriteLine(@"Logging into file...");
            }
        }

        public class ConsoleLogger : ILogger
        {
            public void Write()
            {
                Console.WriteLine(@"Logging into console...");
            }
        }

        public static class GlobalLogger
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
using System;

namespace DTX.DesignPatterns.Patterns.Singleton
{
    public static class ClassicSingleton
    {

        // Singleton
        private sealed class Logger
        {
            private static Logger _instsance;

            private string LoggerName { get; set; }

            private Logger(string name)
            {
                LoggerName = name;
            }

            public static Logger GetInstance(string name)
            {
                return _instsance ?? (_instsance = new Logger(name));
            }

            public void Log()
            {
                Console.WriteLine($@"Logging into {LoggerName}...");
            }
        }

        // Client
        public static void Start()
        {
            var logger = Logger.GetInstance("File");
            logger.Log();


            var newLogger = Logger.GetInstance("File");
            newLogger.Log();

            Console.WriteLine($@"logger == newLogger : {logger == newLogger}");
        }
    }
}
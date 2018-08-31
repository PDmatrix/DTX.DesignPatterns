using System;

namespace DTX.DesignPatterns.Patterns.Proxy
{
    public static class ClassicProxy
    {
        // Service Interface
        private abstract class Subject
        {
            public abstract void Request();
        }

        // Service
        private class RealSubject : Subject
        {
            public override void Request()
            {
                Console.WriteLine(@"Got a new request!");
            }
        }

        // Proxy
        private class Proxy : Subject
        {
            private RealSubject _realSubject;
            public override void Request()
            {
                if (_realSubject == null)
                {
                    _realSubject = new RealSubject();
                }
                _realSubject.Request();
            }
        }

        // Client
        public static void Start()
        {
            Subject subject = new Proxy();
            subject.Request();
        }
    }
}
using System;

namespace DTX.DesignPatterns.Patterns.Adapter
{
    public static class ClassicAdapter
    {
        // Target Interface
        private interface ITransport
        {
            void Drive();
        }

        // Concrete Target
        private class Auto : ITransport
        {
            public void Drive()
            {
                Console.WriteLine(@"The car is on the road");
            }
        }

        // Client Interface
        private static class Driver
        {
            public static void Travel(ITransport transport)
            {
                transport.Drive();
            }
        }

        // Adaptee Interface
        private interface IAnimal
        {
            void Move();
        }

        // Concrete Adaptee
        private class Camel : IAnimal
        {
            public void Move()
            {
                Console.WriteLine(@"A camel walks through the desert sand");
            }
        }

        // Adapter
        private class CamelToTransportAdapter : ITransport
        {
            private readonly IAnimal _camel;

            public CamelToTransportAdapter(IAnimal c)
            {
                _camel = c;
            }

            public void Drive()
            {
                _camel.Move();
            }
        }

        public static void Start()
        {
            var auto = new Auto();

            Driver.Travel(auto);

            IAnimal camel = new Camel();
            ITransport camelTransport = new CamelToTransportAdapter(camel);

            Driver.Travel(camelTransport);
        }
    }
}
using System;

namespace DTX.DesignPatterns.Patterns.Factory_Method
{

    public static class ClassicFactoryMethod
    {
        // Product
        private interface ITransport
        {
            void Move();
        }

        // Concrete Product A
        private class Ship : ITransport
        {
            public void Move()
            {
                Console.WriteLine(@"Ship on the sea");
            }
        }

        // Concrete Product B
        private class Car : ITransport
        {
            public void Move()
            {
                Console.WriteLine(@"Car on the road");
            }
        }

        // Creator
        private abstract class Transport
        {
            public void Deliver()
            {
                var transport = CreateTransport();
                transport.Move();
            }

            protected abstract ITransport CreateTransport();
        }

        // Concrete Creator A
        private class ShipCreator : Transport
        {
            protected override ITransport CreateTransport()
            {
                return new Ship();
            }
        }

        // Concrete Creator B
        private class CarCreator : Transport
        {
            protected override ITransport CreateTransport()
            {
                return new Car();
            }
        }

        // Client
        public static void Start()
        {
            Transport transport = new CarCreator();
            transport.Deliver();

            transport = new ShipCreator();
            transport.Deliver();
        }
    }
}
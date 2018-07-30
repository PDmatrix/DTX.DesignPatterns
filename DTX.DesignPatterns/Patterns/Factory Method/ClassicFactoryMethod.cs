using System;

namespace DTX.DesignPatterns.Patterns.Factory_Method
{

    public static class ClassicFactoryMethod
    {
        private interface ITransport
        {
            void Move();
        }

        private class Ship : ITransport
        {
            public void Move()
            {
                Console.WriteLine(@"Ship on the sea");
            }
        }

        private class Car : ITransport
        {
            public void Move()
            {
                Console.WriteLine(@"Car on the road");
            }
        }

        private abstract class Transport
        {
            public void Deliver()
            {
                var transport = CreateTransport();
                transport.Move();
            }

            protected abstract ITransport CreateTransport();
        }

        private class ShipCreator : Transport
        {
            protected override ITransport CreateTransport()
            {
                return new Ship();
            }
        }

        private class CarCreator : Transport
        {
            protected override ITransport CreateTransport()
            {
                return new Car();
            }
        }

        public static void Start()
        {
            Transport transport = new CarCreator();
            transport.Deliver();

            transport = new ShipCreator();
            transport.Deliver();
        }
    }
}
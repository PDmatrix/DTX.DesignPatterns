using System;
using System.Collections.Generic;
using DTX.DesignPatterns.Definition.PatternTypes;
using DTX.DesignPatterns.Properties;

namespace DTX.DesignPatterns.Patterns.Factory_Method
{

    public interface ITransport
    {
        void Move();
    }

    public class Ship : ITransport
    {
        public void Move()
        {
            Console.WriteLine(@"Ship on the sea");
        }
    }

    public class Car : ITransport
    {
        public void Move()
        {
            Console.WriteLine(@"Car on the road");
        }
    }

    public abstract class Transport
    {
        public void Deliver()
        {
            var transport = CreateTransport();
            transport.Move();
        }

        public abstract ITransport CreateTransport();
    }

    public class ShipCreator : Transport
    {
        public override ITransport CreateTransport()
        {
            return new Ship();
        }
    }

    public class CarCreator : Transport
    {
        public override ITransport CreateTransport()
        {
            return new Car();
        }
    }
   
    public class FactoryMethod : CreationalPattern
    {
        private const string PatternNameStr = "Factory method";

        public FactoryMethod(IDictionary<string, string> args)
        {
            PatternName = PatternNameStr;
        }

        public override void Excecute()
        {
            Console.WriteLine($@"{PatternNameStr}:" + Environment.NewLine);

            #region First Way

            Console.WriteLine(@"The first way");
            Transport transport = new CarCreator();
            transport.Deliver();

            transport = new ShipCreator();
            transport.Deliver();

            #endregion


            #region Second Way

            Console.WriteLine(Environment.NewLine + @"The second way");
            Transport newTransport = new CarCreator();
            var car = newTransport.CreateTransport();
            car.Move();

            newTransport = new ShipCreator();
            var ship = newTransport.CreateTransport();
            ship.Move();

            #endregion

        }

        public override string Description()
        {
            return Resources.FactoryMethodDescription;
        }
    }
}
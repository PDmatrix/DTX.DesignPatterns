using System;
using System.Collections.Generic;
using DTX.DesignPatterns.Definition;
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
   
    public class FactoryMethod : Pattern
    {
        private readonly string _patternNameStr = Properties.PatternName.FactoryMethodName;

        public FactoryMethod(IDictionary<string, string> args)
        {
            PatternName = _patternNameStr;
            PatternType = new CreationalPattern();
        }

        public override void Excecute()
        {
            Console.WriteLine($@"{_patternNameStr}:" + Environment.NewLine);

            #region The First Way

            Console.WriteLine(@"The first way");
            Transport transport = new CarCreator();
            transport.Deliver();

            transport = new ShipCreator();
            transport.Deliver();

            #endregion


            #region The Second Way

            Console.WriteLine($@"{Environment.NewLine}The second way");
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
            return $"{_patternNameStr}: {Environment.NewLine}\t{PatternDescription.FactoryMethodDescription}";
        }
    }
}
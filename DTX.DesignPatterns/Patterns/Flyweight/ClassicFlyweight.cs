using System;
using System.Collections.Generic;

namespace DTX.DesignPatterns.Patterns.Flyweight
{
    public static class ClassicFlyweight
    {
        // Flyweight
        private abstract class House
        {
            protected int Stages;

            public abstract void Build(double longitude, double latitude);
        }

        // ConcreteFlyweight
        private class PanelHouse : House
        {
            public PanelHouse()
            {
                Stages = 16;
            }

            public override void Build(double longitude, double latitude)
            {
                Console.WriteLine(
                    $@"A panel house with {Stages} floors was built; Coordinates: {latitude} latitude and {longitude} longitude");
            }
        }

        // ConcreteFlyweight
        private class BrickHouse : House
        {
            public BrickHouse()
            {
                Stages = 5;
            }

            public override void Build(double longitude, double latitude)
            {
                Console.WriteLine(
                    $@"A brick house with {Stages} floors was built; Coordinates: {latitude} latitude and {longitude} longitude");
            }
        }

        // FlyWeight factory
        private class HouseFactory
        {
            private readonly Dictionary<string, House> _houses = new Dictionary<string, House>();
            public HouseFactory()
            {
                _houses.Add("Panel", new PanelHouse());
                _houses.Add("Brick", new BrickHouse());
            }

            public House GetHouse(string key)
            {
                return _houses.ContainsKey(key) 
                    ? _houses[key] 
                    : null;
            }
        }

        // Client
        public static void Start()
        {
            var longitude = 37.61;
            var latitude = 55.74;

            var houseFactory = new HouseFactory();
            for (var i = 0; i < 5; i++)
            {
                var panelHouse = houseFactory.GetHouse("Panel");
                panelHouse?.Build(longitude, latitude);
                longitude += 0.1;
                latitude += 0.1;
            }
            Console.WriteLine();
            for (var i = 0; i < 5; i++)
            {
                var brickHouse = houseFactory.GetHouse("Brick");
                brickHouse?.Build(longitude, latitude);
                longitude += 0.1;
                latitude += 0.1;
            }
        }
    }
}
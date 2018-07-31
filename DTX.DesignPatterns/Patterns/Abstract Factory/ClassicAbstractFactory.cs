using System;

namespace DTX.DesignPatterns.Patterns.Abstract_Factory
{
    public static class ClassicAbstractFactory
    {
        // Product A
        private abstract class Chair
        {
            public abstract void Sit();
        }

        // Concrete Product A 1
        private class ModernChair : Chair
        {
            private static string Style => "Modern";

            public override void Sit()
            {
                Console.WriteLine($@"Sit on {Style} chair");
            }
        }

        // Concrete Product A 2
        private class ClassicChair : Chair
        {
            private static string Style => "Classic";

            public override void Sit()
            {
                Console.WriteLine($@"Sit on {Style} chair");
            }
        }

        // Product B
        private abstract class Bed
        {
            public abstract void Lay();
        }

        // Concrete Product B 1
        private class ModernBed : Bed
        {
            private static string Style => "Modern";

            public override void Lay()
            {
                Console.WriteLine($@"Lay on {Style} bed");
            }
        }

        // Concrete Product B 2
        private class ClassicBed : Bed
        {
            private static string Style => "Classic";

            public override void Lay()
            {
                Console.WriteLine($@"Lay on {Style} bed");
            }
        }

        // Abstract Factory
        private interface IFurnitureFactory
        {
            Chair CreateChair();
            Bed CreateBed();
        }

        // Concrete Factory A
        private class ModernFurnitureFactory : IFurnitureFactory
        {
            public Chair CreateChair()
            {
                return new ModernChair();
            }

            public Bed CreateBed()
            {
                return new ModernBed();
            }
        }

        // Concrete Factory B
        private class ClassicFurnitureFactory : IFurnitureFactory
        {
            public Chair CreateChair()
            {
                return new ClassicChair();
            }

            public Bed CreateBed()
            {
                return new ClassicBed();
            }
        }

        // Client
        private class Factory
        {
            private readonly Bed _bed;
            private readonly Chair _chair;

            public Factory(IFurnitureFactory factory)
            {
                _bed = factory.CreateBed();
                _chair = factory.CreateChair();
            }

            public void LayOnBed()
            {
                _bed.Lay();
            }

            public void SitOnChair()
            {
                _chair.Sit();
            }
        }

        public static void Start()
        {
            Console.WriteLine(@"ModernFurnitureFactory:");
            var modernFactory = new Factory(new ModernFurnitureFactory());
            modernFactory.SitOnChair();
            modernFactory.LayOnBed();

            Console.WriteLine($@"{Environment.NewLine}ClassicFurnitureFactory:");
            var classicFactory = new Factory(new ClassicFurnitureFactory());
            classicFactory.SitOnChair();
            classicFactory.LayOnBed();
        }
    }
}
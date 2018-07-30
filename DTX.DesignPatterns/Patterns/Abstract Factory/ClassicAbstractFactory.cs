using System;

namespace DTX.DesignPatterns.Patterns.Abstract_Factory
{
    public static class ClassicAbstractFactory
    {
        private abstract class Chair
        {
            public abstract void Sit();
        }

        private class ModernChair : Chair
        {
            private static string Style => "Modern";

            public override void Sit()
            {
                Console.WriteLine($@"Sit on {Style} chair");
            }
        }

        private class ClassicChair : Chair
        {
            private static string Style => "Classic";

            public override void Sit()
            {
                Console.WriteLine($@"Sit on {Style} chair");
            }
        }

        private abstract class Bed
        {
            public abstract void Lay();
        }

        private class ModernBed : Bed
        {
            private static string Style => "Modern";

            public override void Lay()
            {
                Console.WriteLine($@"Lay on {Style} bed");
            }
        }

        private class ClassicBed : Bed
        {
            private static string Style => "Classic";

            public override void Lay()
            {
                Console.WriteLine($@"Lay on {Style} bed");
            }
        }

        private abstract class FurnitureFactory
        {
            public abstract Chair CreateChair();
            public abstract Bed CreateBed();
        }

        private class ModernFurnitureFactory : FurnitureFactory
        {
            public override Chair CreateChair()
            {
                return new ModernChair();
            }

            public override Bed CreateBed()
            {
                return new ModernBed();
            }
        }

        private class ClassicFurnitureFactory : FurnitureFactory
        {
            public override Chair CreateChair()
            {
                return new ClassicChair();
            }

            public override Bed CreateBed()
            {
                return new ClassicBed();
            }
        }

        private class Factory
        {
            private readonly Bed _bed;
            private readonly Chair _chair;

            public Factory(FurnitureFactory factory)
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
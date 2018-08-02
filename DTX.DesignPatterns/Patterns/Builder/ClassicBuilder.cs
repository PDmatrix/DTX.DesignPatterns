using System;
using System.Text;

namespace DTX.DesignPatterns.Patterns.Builder
{
    public static class ClassicBuilder
    {
        // Builder
        private abstract class BreadBuilder
        {
            public Bread Bread { get; private set; }
            public void CreateBread()
            {
                Bread = new Bread();
            }
            public abstract void SetFlour();
            public abstract void SetSalt();
            public abstract void SetAdditives();
        }

        // Director
        private class Baker
        {
            public Bread Bake(BreadBuilder breadBuilder)
            {
                breadBuilder.CreateBread();
                breadBuilder.SetFlour();
                breadBuilder.SetSalt();
                breadBuilder.SetAdditives();
                return breadBuilder.Bread;
            }
        }

        // Concrete Builder A
        private class RyeBreadBuilder : BreadBuilder
        {
            public override void SetFlour()
            {
                Bread.Flour = new Flour { Sort = "Rye flour of the first grade" };
            }

            public override void SetSalt()
            {
                Bread.Salt = new Salt() { Amount = 5 };
            }

            public override void SetAdditives()
            {
                // Not used
            }
        }

        // Concrete Builder B
        private class WheatBreadBuilder : BreadBuilder
        {
            public override void SetFlour()
            {
                Bread.Flour = new Flour { Sort = "Wheat flour of the highest grade" };
            }

            public override void SetSalt()
            {
                Bread.Salt = new Salt { Amount = 3};
            }

            public override void SetAdditives()
            {
                Bread.Additives = new Additives { Name = "Bakery improver" };
            }
        }

        private class Flour
        {
            public string Sort { get; set; }
        }

        private class Salt
        {
            public int Amount { get; set; }
        }

        private class Additives
        {
            public string Name { get; set; }
        }

        // Product
        private class Bread
        {
            public Flour Flour { get; set; }
            public Salt Salt { get; set; }
            public Additives Additives { get; set; }

            public override string ToString()
            {
                var sb = new StringBuilder();
                sb.Append($@"Bread: {Environment.NewLine}");
                if (Flour != null)
                    sb.Append($@"Sort: {Flour.Sort}{Environment.NewLine}");
                if (Salt != null)
                    sb.Append($@"Amount of salt: {Salt.Amount} gr.{Environment.NewLine}");
                if (Additives != null)
                    sb.Append($@"Additives: {Additives.Name}{Environment.NewLine}");
                return sb.ToString();
            }
        }

        // Client
        public static void Start()
        {            
            var baker = new Baker();
            BreadBuilder builder = new RyeBreadBuilder();

            var ryeBread = baker.Bake(builder);
            Console.WriteLine(ryeBread.ToString());

            builder = new WheatBreadBuilder();
            var wheatBread = baker.Bake(builder);

            Console.WriteLine(wheatBread.ToString());
        }
    }
}
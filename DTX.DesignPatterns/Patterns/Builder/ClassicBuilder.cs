using System;

namespace DTX.DesignPatterns.Patterns.Builder
{
    public static class ClassicBuilder
    {
        private interface IBuilder
        {
            void SetSalt(int gram);
            void SetSugar(int gram);
            void SetPepper(int gram);
        }

        private class Cake
        {
            private float _sweetness;

            public float Sweetnes
            {
                get => _sweetness;
                set => _sweetness += value / 100f;
            }
        }

        private class Soup
        {
            private float _saltiness;
            private float _spiciness;

            public float Saltiness
            {
                get => _saltiness;
                set => _saltiness += value / 100f;
            }

            public float Spiciness
            {
                get => _spiciness;
                set => _spiciness += value / 100f;
            }
        }

        private class SoupBuilder : IBuilder
        {
            private readonly Soup _tastySoup = new Soup();

            public void SetSalt(int gram)
            {
                _tastySoup.Saltiness += gram;
            }

            public void SetSugar(int gram)
            {
            }

            public void SetPepper(int gram)
            {
                _tastySoup.Spiciness += gram;
            }

            public Soup GetResult()
            {
                return _tastySoup;
            }
        }

        private class CakeBuilder : IBuilder
        {
            private readonly Cake _tastyCake = new Cake();

            public void SetSalt(int gram)
            {
            }

            public void SetSugar(int gram)
            {
                _tastyCake.Sweetnes += gram;
            }

            public void SetPepper(int gram)
            {
            }

            public Cake GetResult()
            {
                return _tastyCake;
            }
        }

        private class Director
        {
            private IBuilder _builder;

            public Director(IBuilder builder)
            {
                _builder = builder;
            }

            public void ChangeBuilder(IBuilder builder)
            {
                _builder = builder;
            }

            public void MakeCake()
            {
                _builder.SetSugar(10);
            }

            public void MakeSoup()
            {
                _builder.SetPepper(1);
                _builder.SetSalt(2);
            }
        }

        public static void Start()
        {
            var cakeBuilder = new CakeBuilder();
            var director = new Director(cakeBuilder);
            director.MakeCake();

            var soupBuilder = new SoupBuilder();
            director.ChangeBuilder(soupBuilder);
            director.MakeSoup();

            Console.WriteLine($@"Sweatness of the cake: {cakeBuilder.GetResult().Sweetnes}");
            Console.WriteLine($@"Saltienss of the soup: {soupBuilder.GetResult().Saltiness}");
            Console.WriteLine($@"Spiciness of the soup: {soupBuilder.GetResult().Spiciness}");
        }
    }
}
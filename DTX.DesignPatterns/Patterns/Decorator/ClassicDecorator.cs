using System;
using System.Diagnostics.Contracts;

namespace DTX.DesignPatterns.Patterns.Decorator
{
    public static class ClassicDecorator
    {
        // Component
        private abstract class Pizza
        {
            public string Name { get; }

            protected Pizza(string name)
            {
                Name = name;
            }

            public abstract int GetCost();
        }

        // Concrete Component A
        private class ItalianPizza : Pizza
        {
            public ItalianPizza() 
                : base("Italian pizza")
            {

            }

            public override int GetCost()
            {
                return 10;
            }
        }

        // Concrete Component B
        private class BulgarianPizza : Pizza
        {
            public BulgarianPizza()
                : base("Bulgarian pizza")
            {

            }

            public override int GetCost()
            {
                return 8;
            }
        }

        // Base Decorator
        private abstract class PizzaDecorator : Pizza
        {
            protected readonly Pizza Pizza;

            protected PizzaDecorator(string name, Pizza pizza) : base(name)
            {
                Pizza = pizza;
            }
        }

        // Concrete Decorator A
        private class TomatoPizza : PizzaDecorator
        {
            public TomatoPizza(Pizza p)
                : base($"{p.Name}, with tomatoes", p)
            {

            }

            public override int GetCost()
            {
                return Pizza.GetCost() + 3;
            }
        }

        // Concrete Decorator B
        private class CheesePizza : PizzaDecorator
        {
            public CheesePizza(Pizza p)
                : base($"{p.Name}, with cheese", p)
            {

            }

            public override int GetCost()
            {
                return Pizza.GetCost() + 5;
            }
        }

        // Client
        public static void Start()
        {
            Pizza tomatoPizza = new TomatoPizza(new ItalianPizza());
            PrintNameAndCost(tomatoPizza.Name, tomatoPizza.GetCost());
            
            Pizza chessePizza = new CheesePizza(new ItalianPizza());
            PrintNameAndCost(chessePizza.Name, chessePizza.GetCost());

            Pizza mixedPizza = new CheesePizza(new TomatoPizza(new BulgarianPizza()));
            PrintNameAndCost(mixedPizza.Name, mixedPizza.GetCost());
        }

        private static void PrintNameAndCost(string name, int cost)
        {
            Console.WriteLine($@"Name: {name}");
            Console.WriteLine($@"Cost: {cost}");
            Console.WriteLine();
        }
    }
}
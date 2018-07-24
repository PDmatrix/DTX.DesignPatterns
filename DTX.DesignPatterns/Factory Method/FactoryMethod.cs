using System;

namespace DTX.DesignPatterns.Factory_Method
{
    public class FactoryMethod : CreationalPattern
    {
        public override void Excecute()
        {
            Console.WriteLine("Excecute");
        }

        public override string Description()
        {
            return "Description";
        }
    }
}
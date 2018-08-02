using System;

namespace DTX.DesignPatterns.Patterns.Bridge
{
    public static class ClassicBridge
    {
        // Implementor
        private interface ILanguage
        {
            void Build();
            void Execute();
        }

        // Concrete Implementor A
        private class CppLanguage : ILanguage
        {
            public void Build()
            {
                Console.WriteLine(@"Using the C ++ compiler, we compile the program into binary code");
            }

            public void Execute()
            {
                Console.WriteLine(@"Run the executable file of the program");
            }
        }

        // Concrete Implementor B
        private class CSharpLanguage : ILanguage
        {
            public void Build()
            {
                Console.WriteLine(@"Using the Roslyn compiler, we compile the source code into an exe file");
            }

            public void Execute()
            {
                Console.WriteLine(@"JIT compiles a binary code program");
                Console.WriteLine(@"The CLR executes the compiled binary code");
            }
        }

        // Abstraction
        private abstract class Programmer
        {
            private ILanguage _language;

            public ILanguage Language
            {
                set => _language = value;
            }

            protected Programmer(ILanguage lang)
            {
                _language = lang;
            }

            public virtual void DoWork()
            {
                _language.Build();
                _language.Execute();
            }

            public abstract void EarnMoney();
        }

        // Refined Abstraction A
        private class FreelanceProgrammer : Programmer
        {
            public FreelanceProgrammer(ILanguage lang) 
                : base(lang)
            {

            }
            public override void EarnMoney()
            {
                Console.WriteLine(@"Receive payment for the executed order");
            }
        }

        // Refined Abstraction B
        private class CorporateProgrammer : Programmer
        {
            public CorporateProgrammer(ILanguage lang)
                : base(lang)
            {

            }
            public override void EarnMoney()
            {
                Console.WriteLine(@"Receive a salary at the end of the month");
            }
        }

        // Client
        public static void Start()
        {
            Programmer freelancer = new FreelanceProgrammer(new CppLanguage());
            freelancer.DoWork();
            freelancer.EarnMoney();
            
            Programmer corporateProgrammer = new CorporateProgrammer(new CSharpLanguage());

            corporateProgrammer.DoWork();
            corporateProgrammer.EarnMoney();
        }
    }
}
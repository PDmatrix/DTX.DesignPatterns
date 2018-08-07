using System;

namespace DTX.DesignPatterns.Patterns.Facade
{
    public static class ClassicFacade
    {
        // Subsystem class
        private class TextEditor
        {
            public void CreateCode()
            {
                Console.WriteLine(@"Writing code");
            }
            public void Save()
            {
                Console.WriteLine(@"Saving code");
            }
        }

        // Subsystem class
        private class Compiller
        {
            public void Compile()
            {
                Console.WriteLine(@"Compiling");
            }
        }

        // Subsystem class
        private class Clr
        {
            public void Execute()
            {
                Console.WriteLine(@"Excecuting");
            }
            public void Finish()
            {
                Console.WriteLine(@"Stopping");
            }
        }

        // Facade
        private class VisualStudioFacade
        {
            private readonly TextEditor _textEditor;
            private readonly Compiller _compiller;
            private readonly Clr _clr;
            public VisualStudioFacade(TextEditor te, Compiller compil, Clr clr)
            {
                _textEditor = te;
                _compiller = compil;
                _clr = clr;
            }
            public void Run()
            {
                _textEditor.CreateCode();
                _textEditor.Save();
                _compiller.Compile();
                _clr.Execute();
            }
            public void Stop()
            {
                _clr.Finish();
            }
        }

        // Client
        private class Programmer
        {
            public void CreateApplication(VisualStudioFacade facade)
            {
                facade.Run();
                facade.Stop();
            }
        }
        
        public static void Start()
        {
            var textEditor = new TextEditor();
            var compiller = new Compiller();
            var clr = new Clr();

            var ide = new VisualStudioFacade(textEditor, compiller, clr);

            var programmer = new Programmer();
            programmer.CreateApplication(ide);
        }
    }
}
using System;

namespace DTX.DesignPatterns.Patterns.Command
{
    public static class ClassicCommand
    {
        // Command
        private interface ICommand
        {
            void Execute();
            void Undo();
        }

        // Receiver 
        private class Tv
        {
            public void On()
            {
                Console.WriteLine(@"TV is on!");
            }

            public void Off()
            {
                Console.WriteLine(@"TV is off...");
            }
        }

        // ConcreteCommand
        private class TvOnCommand : ICommand
        {
            private readonly Tv _tv;
            public TvOnCommand(Tv tvSet)
            {
                _tv = tvSet;
            }
            public void Execute()
            {
                _tv.On();
            }
            public void Undo()
            {
                _tv.Off();
            }
        }

        // Invoker
        private class RemoteController
        {
            private ICommand _command;

            public void SetCommand(ICommand com)
            {
                _command = com;
            }

            public void PressButton()
            {
                _command.Execute();
            }
            public void PressUndo()
            {
                _command.Undo();
            }
        }

        // Client
        public static void Start()
        {
            var remoteController = new RemoteController();
            var tv = new Tv();
            remoteController.SetCommand(new TvOnCommand(tv));
            remoteController.PressButton();
            remoteController.PressUndo();
        }
    }
}
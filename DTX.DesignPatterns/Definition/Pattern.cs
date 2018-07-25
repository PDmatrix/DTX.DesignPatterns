namespace DTX.DesignPatterns.Definition
{
    public abstract class Pattern
    {
        public string PatternType { get; protected set; }

        public abstract void Excecute();
        public abstract string Description();
    }
}
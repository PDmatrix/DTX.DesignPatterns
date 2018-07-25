namespace DTX.DesignPatterns.Definition
{
    public abstract class Pattern
    {
        public string PatternType { get; set; }
        public string PatternName { get; set; }

        public abstract void Excecute();
        public abstract string Description();
    }
}
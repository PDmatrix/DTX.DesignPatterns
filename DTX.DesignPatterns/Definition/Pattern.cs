using DTX.DesignPatterns.Definition.PatternTypes;

namespace DTX.DesignPatterns.Definition
{
    public abstract class Pattern
    {
        public IPatternType PatternType { get; protected set; }
        public string PatternName { get; protected set; }
           
        public abstract void Excecute();
        public abstract string Description();
    }
}
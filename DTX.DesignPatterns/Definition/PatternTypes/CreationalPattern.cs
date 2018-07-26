namespace DTX.DesignPatterns.Definition.PatternTypes
{
    public abstract class CreationalPattern : Pattern
    {
        private const string PatternTypeName = "Creational pattern";

        protected CreationalPattern()
        {
            PatternType = PatternTypeName;
        }
    }
}
namespace DTX.DesignPatterns.Definition.PatternTypes
{
    public abstract class StructuralPattern : Pattern
    {
        private const string PatternTypeName = "Structural pattern";

        protected StructuralPattern()
        {
            PatternType = PatternTypeName;
        }
    }
}
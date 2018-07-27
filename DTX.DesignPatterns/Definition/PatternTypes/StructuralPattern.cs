namespace DTX.DesignPatterns.Definition.PatternTypes
{
    public abstract class StructuralPattern : Pattern
    {
        private static readonly string PatternTypeName = Properties.PatternType.StructuralPatternName;

        protected StructuralPattern()
        {
            PatternType = PatternTypeName;
        }
    }
}
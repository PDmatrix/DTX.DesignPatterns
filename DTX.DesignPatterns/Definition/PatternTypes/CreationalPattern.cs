namespace DTX.DesignPatterns.Definition.PatternTypes
{
    public abstract class CreationalPattern : Pattern
    {
        private static readonly string PatternTypeName = Properties.PatternType.CreationalPatternName;

        protected CreationalPattern()
        {
            PatternType = PatternTypeName;
        }
    }
}
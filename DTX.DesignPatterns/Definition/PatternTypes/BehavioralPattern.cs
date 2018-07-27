namespace DTX.DesignPatterns.Definition.PatternTypes
{
    public abstract class BehavioralPattern : Pattern
    {
        private static readonly string PatternTypeName = Properties.PatternType.BehavioralPatternName;

        protected BehavioralPattern()
        {
            PatternType = PatternTypeName;
        }
    }
}
namespace DTX.DesignPatterns.Definition.PatternTypes
{
    public abstract class BehavioralPattern : Pattern
    {
        private const string PatternTypeName = "Behavioral pattern";

        protected BehavioralPattern()
        {
            PatternType = PatternTypeName;
        }
    }
}
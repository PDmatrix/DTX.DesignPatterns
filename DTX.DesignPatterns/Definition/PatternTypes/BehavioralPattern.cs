namespace DTX.DesignPatterns.Definition.PatternTypes
{
    public abstract class BehavioralPattern : Pattern
    {
        // ReSharper disable once MemberCanBePrivate.Global
        public const string PatternTypeName = "Behavioral pattern";

        protected BehavioralPattern()
        {
            PatternType = PatternTypeName;
        }
    }
}
namespace DTX.DesignPatterns.Definition.PatternTypes
{
    public abstract class CreationalPattern : Pattern
    {
        // ReSharper disable once MemberCanBePrivate.Global
        public const string PatternTypeName = "Creational pattern";

        protected CreationalPattern()
        {
            PatternType = PatternTypeName;
        }
    }
}
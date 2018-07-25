namespace DTX.DesignPatterns.Definition.PatternTypes
{
    public abstract class StructuralPattern : Pattern
    {
        // ReSharper disable once MemberCanBePrivate.Global
        public const string PatternTypeName = "Structural pattern";

        protected StructuralPattern()
        {
            PatternType = PatternTypeName;
        }
    }
}
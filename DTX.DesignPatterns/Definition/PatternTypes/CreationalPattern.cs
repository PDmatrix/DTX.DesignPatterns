namespace DTX.DesignPatterns.Definition.PatternTypes
{
    public class CreationalPattern : IPatternType
    {
        private static readonly string PatternTypeName = Properties.PatternType.CreationalPatternName;

        public string PatternType => PatternTypeName;
    }
}
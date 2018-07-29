namespace DTX.DesignPatterns.Definition.PatternTypes
{
    public class StructuralPattern : IPatternType
    {
        private static readonly string PatternTypeName = Properties.PatternType.StructuralPatternName;
        
        public string PatternType => PatternTypeName;
    }
}
namespace DTX.DesignPatterns.Definition.PatternTypes
{
    public class BehavioralPattern : IPatternType
    {
        private static readonly string PatternTypeName = Properties.PatternType.BehavioralPatternName;
        
        public string PatternType => PatternTypeName;
    }
}
namespace DTX.DesignPatterns.Extensions
{
    public static class StringExtensions
    {
        public static string RemoveWhiteSpace(this string str)
        {
            return str.Replace(" ", "");
        }
    }
}
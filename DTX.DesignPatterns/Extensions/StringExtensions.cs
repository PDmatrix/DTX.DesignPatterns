using System.Text.RegularExpressions;

namespace DTX.DesignPatterns.Extensions
{
    public static class StringExtensions
    {
        public static string RemoveWhiteSpace(this string str)
        {
            var re = new Regex("\\s+");
            return re.Replace(str, string.Empty);
        }
    }
}
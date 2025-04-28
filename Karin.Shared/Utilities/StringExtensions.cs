using System.Globalization;

namespace Karin.Shared.Utilities
{
    public static class StringExtensions
    {
        public static bool IsNullOrEmpty(this string value)
        {
            return string.IsNullOrEmpty(value);
        }

        public static bool IsNullOrWhiteSpace(this string value)
        {
            return string.IsNullOrWhiteSpace(value);
        }

        public static string ToCamelCase(this string value)
        {
            if (string.IsNullOrEmpty(value) || value.Length < 2)
                return value.ToLower();

            return char.ToLowerInvariant(value[0]) + value.Substring(1);
        }

        public static string ToTitleCase(this string value)
        {
            if (string.IsNullOrWhiteSpace(value)) return value;

            var cultureInfo = CultureInfo.CurrentCulture;
            return cultureInfo.TextInfo.ToTitleCase(value.ToLower());
        }
    }
}
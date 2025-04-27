namespace Shared.Utilities
{
    public static class EnumExtensions
    {
        public static string GetName<TEnum>(this TEnum enumValue) where TEnum : Enum
        {
            return Enum.GetName(typeof(TEnum), enumValue);
        }

        public static int GetValue<TEnum>(this TEnum enumValue) where TEnum : Enum
        {
            return Convert.ToInt32(enumValue);
        }
    }
}

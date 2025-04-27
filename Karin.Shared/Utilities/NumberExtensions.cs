namespace Shared.Utilities
{
    public static class NumberExtensions
    {
        public static bool IsBetween(this int number, int min, int max)
        {
            return number >= min && number <= max;
        }

        public static bool IsEven(this int number)
        {
            return number % 2 == 0;
        }

        public static bool IsOdd(this int number)
        {
            return number % 2 != 0;
        }
    }
}

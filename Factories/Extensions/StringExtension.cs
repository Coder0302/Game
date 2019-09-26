using System.Linq;
namespace Factories.Extensions
{
    public static class StringExtension
    {
        public static bool InNullOrEmpty(this string str)
        {
            return str == null || !str.Any();
        }
    }
}
using System.Globalization;

namespace Topv
{
    public static class Tools
    {
        public static string ToMoney(this double money)
        {
            return money.ToString("N0", CultureInfo.CreateSpecificCulture("fa-ir"));
        }
    }
}

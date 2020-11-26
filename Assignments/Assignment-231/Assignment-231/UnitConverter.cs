using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_231
{
    public static class UnitConverter
    {
        // Declare a dictionary of conversions, from string pairs to Func<double, double>
        public static Dictionary<(String, String), Func<double, double>> Conversions = new Dictionary<(String, String), Func<double, double>>()
        {
            {("M", "CM"), (double x) => x * 100 },
            {("CM", "M"), (double x) => x / 100.0 }
        };

        /// <summary>
        /// Converts the value from the specified unit to the specified unit.
        /// </summary>
        /// <param name="from">The unit we want to convert from</param>
        /// <param name="to">The unit we want to convert to</param>
        /// <param name="value">The value we want to convert</param>
        /// <returns></returns>
        public static double ConvertFromUnitTo(string from, string to, double value)
        {
            if (Conversions.ContainsKey((from, to)))
            {
                return Conversions[(from, to)](value);
            } 
            else
            {
                return 0.0;
            }
        }

    }
}

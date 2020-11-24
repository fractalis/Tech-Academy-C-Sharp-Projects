using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_159
{
    struct PayInfo
    {
        public PayInfo( int HourlyRate, int HoursWorkedPerWeek)
        {
            this.HourlyRate = HourlyRate;
            this.HoursWorkedPerWeek = HoursWorkedPerWeek;
        }

        public int HourlyRate { get; set; }
        public int HoursWorkedPerWeek { get; set; }

        public int AnnualSalary
        {
            get
            {
                return (HourlyRate * HoursWorkedPerWeek) * 52;
            }
        }
    }

    class HourlyIncomeCalculator
    {
        public List<PayInfo> payInfos { get; set; }

        public HourlyIncomeCalculator()
        {
            payInfos = new List<PayInfo>();
        }

        /// <summary>
        /// Adds a new PayInfo record to our list of PayInfos
        /// </summary>
        public void AddPayInfo()
        {
            PayInfo payInfo = new PayInfo();

            Console.WriteLine("Hourly Rate?");
            payInfo.HourlyRate = GetUserInputAsInteger();

            Console.WriteLine("Hours worked per week?");
            payInfo.HoursWorkedPerWeek = GetUserInputAsInteger();

            payInfos.Add(payInfo);
        }

        public IEnumerable<int> GetAnnualSalaries()
        {
            return payInfos.Select(x => x.AnnualSalary);
        }

        public bool DoesPersonXMakeMoreThanPersonY(int x, int y)
        {
            x -= 1;
            y -= 1;

            // Return false if either of the values are invalid (e.g, beyond the payInfos.count)
            if ( x > payInfos.Count || x < 0 || y < 0 || y > payInfos.Count) { return false; }

            return payInfos[x].AnnualSalary > payInfos[y].AnnualSalary;
        }

        private int GetUserInputAsInteger()
        {
            while(true)
            {
                try
                {
                    return Convert.ToInt32(Console.ReadLine());
                }
                catch(FormatException ex)
                {
                    Console.WriteLine("Invalid value, please enter a valid number: ");
                    continue;
                }
            }
        }
    }
}

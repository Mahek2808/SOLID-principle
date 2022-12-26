using System;
using System.Collections.Generic;
using System.Text;

namespace SingleResponsibilityPrinciple
{
    public class HourReporter
    {
        public int ReportHour()
        {
            RegularHours();
            Console.WriteLine("Reported Hour of Employee");
            return 80;
        }
        public decimal RegularHours()
        {
            Console.WriteLine("Regular reported hours for Employee");
            return 0;
        }
    }
}

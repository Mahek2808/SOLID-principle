using System;
using System.Collections.Generic;
using System.Text;

namespace SingleResponsibilityPrinciple
{
    public class PayCalculator
    {
        public decimal CalcPay()
        {
            RegularPayHours();
            Console.WriteLine("Calculate pay for Employee");
            return 110;
        }

        public decimal RegularPayHours()
        {
            Console.WriteLine("Calculate regular pay for Employee");
            return 80;
        }
    }
}

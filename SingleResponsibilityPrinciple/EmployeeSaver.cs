using System;
using System.Collections.Generic;
using System.Text;

namespace SingleResponsibilityPrinciple
{
    public class EmployeeSaver
    {
        public bool Save()
        {
            Console.WriteLine("Employee's Data Saved...");
            return true;
        }
    }
}

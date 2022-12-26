using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversionPrinciple
{
    public class DataAccess
    {
        public static IEmpoyeeData GetEmployeeDataAccess()
        {
            return new DIP();
        }
    }
}

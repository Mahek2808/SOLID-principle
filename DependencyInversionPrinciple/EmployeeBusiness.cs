using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversionPrinciple
{
    class EmployeeBusiness
    {
        DIP _DIP;
        public EmployeeBusiness()
        {
            _DIP = (DIP)DataAccess.GetEmployeeDataAccess();
        }
        public Employee GetEmployeeData(int id)
        {
            return _DIP.GetEmployeeData(id);
        }
    }
}

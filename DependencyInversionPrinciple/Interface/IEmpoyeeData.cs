using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversionPrinciple
{
    public interface IEmpoyeeData
    {
        Employee GetEmployeeData(int id);
    }
}

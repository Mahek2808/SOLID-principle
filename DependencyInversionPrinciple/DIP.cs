using System;
using System.Collections.Generic;

namespace DependencyInversionPrinciple
{
    class Dependency
    {
        static void Main(string[] args)
        {
            IEmpoyeeData empoyee = new DIP();
            Employee emp = empoyee.GetEmployeeData(1);
            Console.WriteLine( "Id: " + emp.Id +'\n' + "Nme: " + emp.Name +'\n'+ "Department: " + emp.Department);
        }
    }
    public class DIP : IEmpoyeeData
    {
        public Employee GetEmployeeData(int id)
        {
            Employee emp = new Employee();
            emp.Id = id;
            emp.Name = "Mahek";
            emp.Department = "DotNet";
            return emp;
        }
    }
}

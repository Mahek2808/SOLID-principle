using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosedPrinciple
{
    public class Employee
    {
        public virtual double GetEmployee(double amount)
        {
            return amount;
        }
    }

    public class FinalPoint : Employee
    {
        public override double GetEmployee(double amount)
        {
            return base.GetEmployee(amount);
        }
    }
    public class Proposedsalary : Employee
    {
        public override double GetEmployee(double amount)
        {
            return base.GetEmployee(amount);
        }
    }
    public class Recurringsalary : Employee
    {
        public override double GetEmployee(double amount)
        {
            return base.GetEmployee(amount);
        }
    }
}

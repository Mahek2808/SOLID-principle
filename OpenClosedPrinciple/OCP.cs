using System;

namespace OpenClosedPrinciple
{
    class OCP
    {
        static void Main(string[] args)
        {
            Employee FPoint = new FinalPoint();
            Employee Psalary = new Proposedsalary();
            Employee Rsalary = new Recurringsalary();
            double FInvoiceAmount = FPoint.GetEmployee(10);
            double PInvoiceAmount = Psalary.GetEmployee(100000);
            double RInvoiceAmount = Rsalary.GetEmployee(10000);
            Console.WriteLine("Final Point is = " + FInvoiceAmount);
            Console.WriteLine("Proposed Salary is = " + PInvoiceAmount);
            Console.WriteLine("Recurring Salary is = " + RInvoiceAmount);
            Console.ReadKey();
        }
    }
}

using SingleResponsibilityPrinciple;
using SinglrResponsibilityPrinciple;
using System;
using System.Net.Mail;
namespace SinglrResponsibilityPrinciple
{
    public class SRP
    {
        public static void Main(string[] args)
        {
            var PayCalc = new PayCalculator();
            Console.WriteLine( "Calculate Pay : "+ PayCalc.CalcPay());

            var RepHour = new HourReporter();
            Console.WriteLine("Reported Hours : " + RepHour.ReportHour());

            var Save = new EmployeeSaver();
            Console.WriteLine("Data Saved : " + Save.Save());
   
        }
    }
}

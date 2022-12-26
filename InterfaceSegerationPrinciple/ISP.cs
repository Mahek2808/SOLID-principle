using InterfaceSegerationPrinciple.Interface;
using System;

namespace InterfaceSegerationPrinciple
{
    class ISP
    {
        public static void Main(string[] args)
        {
            ICompanyDepartment admin = new Simform(); new BlackCompany();
            Console.WriteLine("Simform,Black and White company have " + admin.Admin());
            ICompanyDepartment Sbusiness = new Simform(); 
            Console.WriteLine("Simform,Black and White company have " + Sbusiness.Business());
            ICompanyDepartment Hr = new Simform();
            Console.WriteLine("Simform,Black and White company have " + Hr.HR());
            IBlackCompany It = new BlackCompany();
            Console.WriteLine("BlackCompany have " + It.IT());
            IWhiteCompany marketing = new WhiteCompany();
            Console.WriteLine("WhiteCompany have " + marketing.Marketing());
        }
    }

    public class Simform : ICompanyDepartment
    {
        public string Admin()
        {
            return "Admin Department";
        }

        public string Business()
        {
            return "Business Department";
        }

        public string HR()
        {
            return "HR Department";
        }
    }

    public class BlackCompany : ICompanyDepartment, IBlackCompany
    {
        public string Admin()
        {
            return "Admin Department";
        }

        public string Business()
        {
            return "Business Department";
        }

        public string HR()
        {
            return "HR Department";
        }

        public string IT()
        {
            return "IT Department";
        }
    }

    public class WhiteCompany : ICompanyDepartment, IWhiteCompany
    {
        public string Admin()
        {
            return "Admin Department";
        }

        public string Business()
        {
            return "Business Department";
        }

        public string HR()
        {
            return "HR Department";
        }

        public string Marketing()
        {
            return "Marketing Department";
        }
    }
}

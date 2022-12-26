using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSegerationPrinciple.Interface
{
    public interface ICompanyDepartment
    {
        public string Admin();
        public string HR();
        public string Business();

    }

    interface IBlackCompany
    {
        public string IT();
    }
    interface IWhiteCompany
    {
        public string Marketing();
    }
}

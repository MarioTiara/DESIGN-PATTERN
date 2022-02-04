using System;
using System.Collections.Generic;

namespace OCPLibrary 
{
    public interface IAccounts
    {
        EmployeeModel Create (IApplicantModel person);
    }
}
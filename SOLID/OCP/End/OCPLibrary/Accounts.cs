using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPLibrary{
    public class Accounts{
        public EmployeeModel Create (PersonModel person){
            EmployeeModel output = new EmployeeModel();
            output.FirstName=person.FirstName;
            output.LastName = person.LastName;
            output.EmailAddress=$"{ person.FirstName.Substring(0,1)}{person.LastName}@gmail.com";
           if (person.TypeOfEmployee==EmpoyeeType.Manager)
           {
               output.IsManager=true;
           }           
            return output;
        }

    }
}
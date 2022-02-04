using System;
using System.Collections.Generic;
using OCPLibrary;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            List<PersonModel> applicatns = new List<PersonModel>()
            {
                new PersonModel {FirstName ="Mario", LastName="Pratama"},
                new PersonModel {FirstName="Ahmad", LastName="Fauzan", TypeOfEmployee=EmpoyeeType.Manager},
                new PersonModel{FirstName="Dery", LastName="Ardiansyah"}
            };

            List<EmployeeModel> employees = new List<EmployeeModel>();
            Accounts accountsProcessor= new Accounts();

            foreach ( var person in applicatns){
                employees.Add(accountsProcessor.Create(person));
            }

            foreach ( var emp in employees){
                Console.WriteLine ($"{emp.FirstName}{emp.LastName} : {emp.EmailAddress} isManager: {emp.IsManager}");
            }

        }
    }
}

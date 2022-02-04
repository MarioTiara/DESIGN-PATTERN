using System;
using System.Collections.Generic;
using OCPLibrary;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IApplicantModel> applicatns = new List<IApplicantModel>()
            {
                new PersonModel {FirstName ="Mario", LastName="Pratama"},
                new ManagerModel {FirstName="Ahmad", LastName="Fauzan"},
                new ExecutiveModel{FirstName="Dery", LastName="Ardiansyah"}
                
            };

            List<EmployeeModel> employees = new List<EmployeeModel>();

            foreach ( var person in applicatns){
                employees.Add(person.AccountProcessor.Create(person));
            }

            foreach ( var emp in employees){
                Console.WriteLine ($"{emp.FirstName}{emp.LastName} : {emp.EmailAddress} isManager: {emp.IsManager} IsExecutive: {emp.ISExecutive}");
            }

        }
    }
}

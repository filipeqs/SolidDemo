using System;
using System.Collections.Generic;

namespace OCPDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var applicants = new List<IApplicantModel>
            {
                new ManagerModel {FirstName = "Filipe", LastName = "Silva" },
                new ExecutiveModel {FirstName = "Tim", LastName = "Corey" },
                new PersonModel {FirstName = "Nancy", LastName = "Roman" },
            };

            var employees = new List<EmployeeModel>();

            foreach (var person in applicants)
                employees.Add(person.AccountProcessor.Create(person));

            foreach (var emp in employees)
                Console.WriteLine($"{emp.FirstName} {emp.LastName}: {emp.EmailAddress} IsManager: {emp.IsManager} IsExecutive: {emp.IsExecutive}");

            Console.ReadLine();
        }
    }
}

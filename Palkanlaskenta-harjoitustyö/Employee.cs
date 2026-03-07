using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palkanlaskenta_harjoitustyö
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthdate { get; set; }
        public string Address { get; set; }
        public string JobTitle { get; set; }
        public string PayType { get; set; } //tuntipalkka vai kuukausipalkka
        public decimal Salary { get; set; }
        public decimal TaxRate { get; set; }

        //kokonimi
        public string FullName => $"{FirstName} {LastName}";

        public Employee() { }

        public Employee(string firstName, string lastName, DateTime birthDate, 
                        string address, string jobtitle, decimal salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Birthdate = birthDate;
            Address = address;
            JobTitle = jobtitle;
            Salary = salary;
        }

        //esitetään henkilöt listassa järkevämmin
        public override string ToString()
        {
            return $"{Id} - {FirstName} {LastName}";
        }
    }
}

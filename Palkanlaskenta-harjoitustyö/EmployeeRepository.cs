using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Palkanlaskenta_harjoitustyö
{
    public class EmployeeRepository
    {
        private readonly string filePath = "employees.json";
        public List<Employee> Employees { get; private set; }

        //ladataan työntekijätiedot tiedostosta
        public EmployeeRepository()
        {
            Employees = LoadFromFile();
        }

        //työntekijän lisäys listaan ja tallennus tiedostoon
        public void AddEmployee(Employee emp)
        {
            emp.Id = GetNextId(); //asetetaan ID tässä kohtaa
            Employees.Add(emp); //lisätään listaan
            SaveToFile(); //tallennetaan tiedostoon
        }

        //ID:n generointi
        private int GetNextId()
        {
            //jos listassa ei ole työntekijöitä, aloitetaan ID:stä 1,
            if (Employees.Count == 0)
                return 1;
            //muuten otetaan suurin ID työntekijälistasta ja lisätään siihen 1
            return Employees.Max(e => e.Id) + 1;
        }

        //päivitetään työntekijän tietoja, jos työntekijä löytyy listasta
        public void UpdateEmployee(Employee updatedEmp)
        {
            var existing = Employees.FirstOrDefault(e => e.Id == updatedEmp.Id);
            if (existing != null)
            {
                existing.FirstName = updatedEmp.FirstName;
                existing.LastName = updatedEmp.LastName;
                existing.Birthdate = updatedEmp.Birthdate;
                existing.Address = updatedEmp.Address;
                existing.JobTitle = updatedEmp.JobTitle;
                existing.PayType = updatedEmp.PayType;
                existing.Salary = updatedEmp.Salary;
                existing.TaxRate = updatedEmp.TaxRate;

                SaveToFile();
            }
        }

        //haetaan kaikki työntekijät
        public List<Employee> GetAllEmployees()
        {
            return Employees;
        }

        //tiedostoon tallennus
        private void SaveToFile()
        {
            var options = new JsonSerializerOptions
            { WriteIndented = true };
            string json = JsonSerializer.Serialize(Employees, options);
            File.WriteAllText(filePath, json);
        }

        //tiedostosta lataus
        private List<Employee> LoadFromFile()
        {
            if (!File.Exists(filePath))
            {
                return new List<Employee>();
            }
            string json = File.ReadAllText(filePath);
            if (string.IsNullOrWhiteSpace(json))
            {
                return new List<Employee>();
            }
            return JsonSerializer.Deserialize<List<Employee>>(json) ?? new List<Employee>();
        }

    }
}

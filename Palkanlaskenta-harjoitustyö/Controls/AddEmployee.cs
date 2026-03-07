using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Palkanlaskenta_harjoitustyö
{
    public partial class AddEmployee : UserControl
    {
        private EmployeeRepository employeeRepository;
        public AddEmployee(EmployeeRepository repository)
        {
            InitializeComponent();
            employeeRepository = repository;
        }

        //luodaan uusi olio "Lisää"-napilla
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //kerätään syötteet
            string firstName = txtFirstName.Text.Trim();
            string lastName = txtLastName.Text.Trim();
            DateTime birthdate = dtpBirthdate.Value.Date;
            string address = txtAddress.Text.Trim();
            string jobTitle = comboJobTitle.Text.Trim();
            string payType = comboPayType.Text.Trim();
            string salaryText = txtSalary.Text.Trim();
            string taxRateText = txtTaxRate.Text.Trim();

            //validoinnit funktioista, paluu jos joku pielessä
            if (!ValidateInputNotEmpty(firstName, lastName, address, jobTitle, payType, salaryText)) return;
            if (!ValidateNames(firstName, lastName)) return;
            if (!ValidateAge(birthdate)) return;
            if (!ValidateSalary(salaryText, payType, out decimal salary)) return;
            if (!ValidateTaxRate(taxRateText, out decimal taxRate)) return;

            //kaikki kunnossa, luodaan olio ja tallennetaan
            Employee emp = new Employee
            {
                FirstName = firstName,
                LastName = lastName,
                Birthdate = birthdate,
                Address = address,
                JobTitle = jobTitle,
                PayType = payType,
                Salary = salary,
                TaxRate = taxRate / 100m //muutetaan prosentti desimaaliksi
            };

            employeeRepository.AddEmployee(emp);
            MessageBox.Show("Työntekijä tallennettu onnistuneesti!"); //vahvistusviesti
        }

////////////////////////////////// Validointifunktiot ////////////////////////////////////////////////////

        //1. pakolliset kentät täytetty
        private bool ValidateInputNotEmpty(string firstName, string lastName, string address, 
                                            string jobTitle, string payType, string salaryText)
        {
            if (string.IsNullOrWhiteSpace(firstName) ||
                string.IsNullOrWhiteSpace(lastName) ||
                string.IsNullOrWhiteSpace(address) ||
                string.IsNullOrWhiteSpace(jobTitle) ||
                string.IsNullOrWhiteSpace(payType) ||
                string.IsNullOrWhiteSpace(salaryText))
            {
                MessageBox.Show("Täytä kaikki pakolliset kentät.");
                return false;
            }

            return true;
        }

        //2. nimitiedot sisältää vain hyväksyjä merkkejä
        private bool ValidateNames(string firstName, string lastName)
        {
            if (!IsValidNameString(firstName) || !IsValidNameString(lastName))
            {
                MessageBox.Show("Nimitiedot eivät voi sisältää numeroita tai erikoismerkkejä");
                return false;
            }
            return true;
        }

        //3. työntekijä on vähintään 18-vuotias (ja samalla ettei syntymäaika tulevaisuudessa)
        private bool ValidateAge(DateTime birthdate)
        {
            int age = DateTime.Today.Year - birthdate.Year;
           
            if (birthdate > DateTime.Today.AddYears(-age))
            {
                age--; //ei vielä täyttänyt 18 -> age == 17
            }
    
            if (age < 18)
            {
                MessageBox.Show("Työntekijän tulee olla vähintään 18-vuotias");
                return false;
            }

            return true;
        }

        //4. palkkatiedot numeerisina arvoina ja jokseenkin järkevissä rajoissa
        private bool ValidateSalary(string salaryText, string payType, out decimal salary)
        {
            salary = 0;
            if (!decimal.TryParse(salaryText, out salary))
            {
                MessageBox.Show("Palkan tulee olla numeerinen arvo.");
                return false;
            }

            if (payType == "Tuntipalkka" && (salary < 5.00m || salary > 100.00m))
            {
                MessageBox.Show("Tarkista tuntipalkan määrä!");
                return false;
            }
            if (payType == "Kuukausipalkka" && (salary < 1000.00m || salary > 20000.00m))
            {
                MessageBox.Show("Tarkista kuukausipalkan määrä!");
                return false;
            }
            return true;
        }

        //5. verokortti numeerisena arvona välillä 0-60% (tai tyhjä, jolloin asetetaan 60%)
        private bool ValidateTaxRate(string taxRateText, out decimal taxRate)
        {
            taxRate = 60.00m;

            if (string.IsNullOrWhiteSpace(taxRateText))
            {
                return true;
            }

            if (!decimal.TryParse(taxRateText, out taxRate))
            {
                MessageBox.Show("Veroprosentin tulee olla numeerinen arvo.");
                return false;
            }

            if (taxRate < 0.00m || taxRate > 60.00m)
            {
                MessageBox.Show("Veroprosentin tulee olla välillä 0 - 60%.");
                return false;
            }

            return true;
        }

        //apufunktio syötteen tarkastukseen
        // -> syötteessä on vain hyväksytyt merkit (kirjaimet, välilyönti, yhdysmerkki)
        private bool IsValidNameString(string text)
        {
            foreach (char c in text)
            {
                if (!char.IsLetter(c) && c != ' ' && c != '-')
                {
                    return false;
                }
            }

            return true;
        }
    }
}

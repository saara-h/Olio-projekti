using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palkanlaskenta_harjoitustyö.Validators
{
    internal class ValidateNewEmployee : BaseValidators
    {
        private readonly EmployeeRepository employeeRepository; //repo ssn-tarkistusta varten
        public ValidateNewEmployee(EmployeeRepository repository)
        {
            employeeRepository = repository;
        }

        //tarkistetaan uuden työntekijän tiedot syötteistä ennen olion luontia ja tallennusta
        //uuden työntekijän kohdalla tarkistetaan pakolliset kentät (kaikki paitsi ID ja vero) täytetty,
        //nimitiedot ok, ikä väh. 18 vuotta, ssn ok, palkka ja veroprosentti ok
        public bool ValidateNewEmployeeData(string firstName, string lastName, DateTime birthdate,
                                        string ssn, string address, string jobTitle,
                                        string payType, string salaryText, string taxRateText, out decimal salary, out decimal taxRate)
        {
            salary = 0;
            taxRate = 0;
            //tässä kutsutaan erillisiä validointimetodeja (alla tai baseclassissa)
            if (!RequiredFieldsNotEmpty(firstName, lastName, ssn, address, jobTitle, payType, salaryText))
            {return false;}
            if (!IsValidNameString(firstName, lastName))
            { return false; }
            if (!IsOver18YearsOld(birthdate))
            { return false; }
            if (!IsValidSocialSecurityNumber(ssn, birthdate))
            { return false; }
            if (!ValidateSalary(salaryText, payType, out salary))
            { return false; }
            if (!ValidateTaxRate(taxRateText, out taxRate))
            { return false; }

            //kaikki ehdot täytetty
            return true;
        }


        //tarkistetaan, että pakolliset kentät on täytetty
        private bool RequiredFieldsNotEmpty(string firstName, string lastName, string ssn, string address, string jobTitle,
                                        string payType, string salaryText)
        {
            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName) ||
            string.IsNullOrWhiteSpace(ssn))
            {
                MessageBox.Show("Täytä pakolliset kentät!");
                return false;
            }
            if (!ValidateInputNotEmpty(address, jobTitle, payType, salaryText)) //yhteiset kentät add/update, tehdään baseclassin kautta
            {
                return false;
            }
            return true;
        }

        //tarkistetaan, että nimitiedot sisältävät vain hyväksyttyjä merkkejä
        private bool IsValidNameString(string firstName, string lastName)
        {
            if (!AcceptedCharacters(firstName) || !AcceptedCharacters(lastName)) //merkit tarkistetaan baseclassissa
            {
                MessageBox.Show("Nimissä voi käyttää vain kirjaimia, välilyöntejä ja yhdysmerkkejä.");
                return false;
            }
            return true;
        }

        //tarkistetaan henkilön ikä (väh. 18 vuotta)
        private bool IsOver18YearsOld(DateTime birthdate)
        {
            int age = DateTime.Now.Year - birthdate.Year;
            if (birthdate > DateTime.Today.AddYears(-age)) //syntymäpäivä kuluvana vuonna
            { age--; } // ei vielä täyttänyt 18 => 17

            if (age < 18)
            {
                MessageBox.Show("Työntekijän tulee olla vähintään 18-vuotias");
                return false;
            }
            return true;
        }

        private bool IsValidSocialSecurityNumber(string ssn, DateTime birthdate)
        {
            ssn = ssn.Trim().ToUpper(); //vertailu ei riipu kirjoitustavasta

            if (ssn.Length != 11)
            {
                MessageBox.Show("Henkilötunnuksen tulee olla 11 merkkiä pitkä.");
                return false;
            
            }

            if (birthdate.ToString("ddMMyy") != ssn.Substring(0, 6))
            {
                MessageBox.Show("Henkilötunnuksen alkuosa ei vastaa syntymäaikaa.");
                return false;
            }

            if (employeeRepository.SsnExists(ssn))
            {
                MessageBox.Show("Tällä henkilötunnuksella on jo työntekijä järjestelmässä.");
                return false;
            }

            return true;
        }
    }
}

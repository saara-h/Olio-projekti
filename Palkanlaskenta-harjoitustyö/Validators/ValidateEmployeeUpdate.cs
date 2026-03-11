using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palkanlaskenta_harjoitustyö.Validators
{
    internal class ValidateEmployeeUpdate : BaseValidators
    {
        public ValidateEmployeeUpdate() { }

        public bool ValidateUpdatedEmployeeData(Employee originalEmployee, string address, string jobTitle, 
                                                string payType, string salaryText, string taxRateText, 
                                                out decimal salary, out decimal taxRate)
        {
            salary = 0;
            taxRate = 0;

            //voidaan päivittää vain osoite, tehtävänimike, palkkatiedot
            if (!ValidateInputNotEmpty(address, jobTitle, payType, salaryText))
                { return false; }
            //perustarkistus palkalle
            if (!ValidateSalary(salaryText, payType, out salary))
                { return false; }
            //perustarkistus veroprosentille + prosentti ei voi olla enää tyhjä
            if (string.IsNullOrWhiteSpace(taxRateText))
            {
                MessageBox.Show("Veroprosentti ei voi olla tyhjä.");
                return false;
            } 
            if (!ValidateTaxRate(taxRateText, out taxRate))
                { return false; }
            //desimaalit parsettu, nyt voidaan vertailla uutta ja vanhaa palkkaa
            if (!ValidateSalaryChange(originalEmployee, salary, payType))
                { return false; }
            
            //kaikki ehdot täytetty
            return true;
        }

        private bool ValidateSalaryChange(Employee originalEmployee, decimal newSalary, string newPayType)
        {
            //jos vaihtuu tt -> kk tai kk -> tt, allaolevat säännöt eivät päde (vrt. kk-palkka 2500€ vs tt-palkka 19,57€/h)
            if (originalEmployee.PayType != newPayType)
            {
                return true;
            }

            if (newSalary < originalEmployee.Salary)
            {
                MessageBox.Show("Palkkaa ei voi laskea.");
                return false;
            }

            if (newSalary > originalEmployee.Salary * 1.5m)
            {
                MessageBox.Show("Palkkaa ei voi nostaa kerralla yli 50%.");
                return false;
            }

            return true;
        }
    }
}

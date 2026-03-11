using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palkanlaskenta_harjoitustyö.Validators
{
    //"validointipohjat" = validoinnit joita sekä new että update tarvitsevat
    internal class BaseValidators
    {
        //tarkistetaan, ettei pakolliset kentät ole tyhjiä
        //yhteiset kentät: osoite, tehtävänimike, palkkatyyppi, palkka, veroprosentti
        protected bool ValidateInputNotEmpty(string address, string jobTitle, string payType, string salaryText)
        {
            if (
                string.IsNullOrWhiteSpace(address) ||
                string.IsNullOrWhiteSpace(jobTitle) ||
                string.IsNullOrWhiteSpace(payType) ||
                string.IsNullOrWhiteSpace(salaryText))
            {
                MessageBox.Show("Täytä pakolliset kentät!");
                return false;
            }

            return true;
        }

        //palkkatiedot esitetään numeerisina arvoina ja jokseenkin järkevissä rajoissa
        protected bool ValidateSalary(string salaryText, string payType, out decimal salary)
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

        //verokortti numeerisena arvona välillä 0-60%
        protected bool ValidateTaxRate(string taxRateText, out decimal taxRate)
        {
            if (!decimal.TryParse(taxRateText, out taxRate))
            {
                MessageBox.Show("Veroprosentin tulee olla numeerinen arvo.");
                return false;
            }

            if (taxRate <= 0.00m || taxRate >= 60.00m)
            {
                MessageBox.Show("Veroprosentin tulee olla välillä 0 - 60%.");
                return false;
            }

            return true;
        }

        //tarkistetaan, että nimitiedot sisältävät vain hyväksyttyjä merkkejä
        protected bool AcceptedCharacters(string text)
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

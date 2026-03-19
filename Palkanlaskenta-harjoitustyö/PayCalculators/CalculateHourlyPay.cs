using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palkanlaskenta_harjoitustyö.PayCalculators
{
    public class HourlyPayCalculator : IPayCalculator
    {
        public Payslip CreatePayslip(Employee employee, decimal workedHours = 0)
        {
            decimal grossPay = employee.Salary * workedHours;
            decimal taxAmount = grossPay * employee.TaxRate;
            decimal netPay = grossPay - taxAmount;

            return new Payslip(employee, workedHours, grossPay, taxAmount, netPay);
        }
    }
}

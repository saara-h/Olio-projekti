using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palkanlaskenta_harjoitustyö.PayCalculators
{
    public class CalculateHourlyPay : IPayCalculator
    {
        public Payslip CreatePayslip(Employee employee, decimal workedHours = 0)
        {
            //lasketaan palkka
            decimal grossPay = employee.Salary * workedHours;
            decimal taxAmount = grossPay * employee.TaxRate;
            decimal netPay = grossPay - taxAmount;

            //muodostetaan palkkalaskelma
            return new Payslip
            {
                EmployeeId = employee.Id,
                EmployeeName = employee.FullName,
                JobTitle = employee.JobTitle,
                PayType = employee.PayType,
                HourlyRateOrMonthlySalary = employee.Salary,
                WorkedHours = workedHours,
                TaxRate = employee.TaxRate,
                TaxAmount = taxAmount,
                NetPay = netPay
            };
        }
    }
}

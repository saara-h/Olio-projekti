using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palkanlaskenta_harjoitustyö.PayCalculators
{
    public class CalculateMonthlyPay : IPayCalculator
    {
        public Payslip CreatePayslip(Employee employee, decimal workedHours = 0)
        {
            decimal grossPay = employee.Salary;
            decimal taxAmount = grossPay * employee.TaxRate;
            decimal netPay = grossPay - taxAmount;

            return new Payslip
            {
                EmployeeId = employee.Id,
                EmployeeName = employee.FullName,
                JobTitle = employee.JobTitle,
                PayType = employee.PayType,
                HourlyRateOrMonthlySalary = employee.Salary,
                WorkedHours = 0,
                GrossPay = grossPay,
                TaxRate = employee.TaxRate,
                TaxAmount = taxAmount,
                NetPay = netPay
            };
        }
    }
}

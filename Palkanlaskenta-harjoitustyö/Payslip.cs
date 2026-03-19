using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palkanlaskenta_harjoitustyö
{
    public class Payslip
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string SocialSecurityNumber { get; set; }
        public string JobTitle { get; set; }
        public string PayType { get; set; }

        public decimal HourlyRateOrMonthlySalary { get; set; }
        public decimal WorkedHours { get; set; }

        public decimal GrossPay { get; set; }
        public decimal TaxRate { get; set; }
        public decimal TaxRatePercent => TaxRate * 100;
        public decimal TaxAmount { get; set; }
        public decimal NetPay { get; set; }

        public Payslip(Employee employee,
                       decimal workedHours,
                       decimal grossPay,
                       decimal taxAmount,
                       decimal netPay)
        {
            EmployeeId = employee.Id;
            EmployeeName = employee.FullName;
            SocialSecurityNumber = employee.SocialSecurityNumber;
            JobTitle = employee.JobTitle;
            PayType = employee.PayType;

            HourlyRateOrMonthlySalary = employee.Salary;
            WorkedHours = workedHours;

            TaxRate = employee.TaxRate;
            GrossPay = grossPay;
            TaxAmount = taxAmount;
            NetPay = netPay;
        }

        public override string ToString()
        {
            return $"Työntekijä: {EmployeeName}\n" +
                   $"Bruttopalkka: {GrossPay:F2} €\n" +
                   $"Nettopalkka: {NetPay:F2} €";
        }
    }
}
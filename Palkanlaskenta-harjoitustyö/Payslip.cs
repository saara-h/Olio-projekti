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
        public string JobTitle { get; set; }
        public string PayType { get; set; }

        public decimal HourlyRateOrMonthlySalary { get; set; }
        public decimal WorkedHours { get; set; }

        public decimal GrossPay { get; set; }
        public decimal TaxRate { get; set; }
        public decimal TaxAmount { get; set; }
        public decimal NetPay { get; set; }
    }
}

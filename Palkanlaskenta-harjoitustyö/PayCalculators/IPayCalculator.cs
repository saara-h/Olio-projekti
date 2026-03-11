using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palkanlaskenta_harjoitustyö.PayCalculators
{
    public interface IPayCalculator
    {
        Payslip CreatePayslip(Employee employee, decimal workedHours = 0);
    }
}

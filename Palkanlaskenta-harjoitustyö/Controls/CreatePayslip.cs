using Palkanlaskenta_harjoitustyö.PayCalculators;
using Palkanlaskenta_harjoitustyö.Repos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Palkanlaskenta_harjoitustyö.Controls
{
    public partial class CreatePayslip : UserControl
    {
        EmployeeRepository employeeRepository;
        public CreatePayslip(EmployeeRepository repository)
        {
            InitializeComponent();
            employeeRepository = repository;
            LoadEmployees();
        }

        private void LoadEmployees()
        {
            listEmployees.Items.Clear();
            foreach (var emp in employeeRepository.GetAllEmployees())
            {
                listEmployees.Items.Add(emp);
            }
        }

        private void listEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listEmployees.SelectedItem is Employee selectedEmployee)
            {
                txtEmployeeID.Text = selectedEmployee.Id.ToString();
                txtSocialSecurityNumber.Text = selectedEmployee.SocialSecurityNumber;
                txtFirstName.Text = selectedEmployee.FirstName;
                txtLastName.Text = selectedEmployee.LastName;

                if (selectedEmployee.PayType == "Tuntipalkka")
                {
                    txtWorkedHours.Enabled = true;
                    lblWorkedHours.Enabled = true;
                }
                else
                {
                    txtWorkedHours.Enabled = false;
                    lblWorkedHours.Enabled = false;
                    txtWorkedHours.Clear();
                }

                txtboxPayslip.Clear();
            }
        }

        private void btnCalculatePay_Click(object sender, EventArgs e)
        {
            if (listEmployees.SelectedItem is not Employee selectedEmployee)
            {
                MessageBox.Show("Valitse työntekijä listasta.");
                return;
            }

            decimal workedHours = 0;
            IPayCalculator calculator;

            if (selectedEmployee.PayType == "Tuntipalkka")
            {
                if (!decimal.TryParse(txtWorkedHours.Text, out workedHours))
                {
                    MessageBox.Show("Syötä kelvollinen tuntimäärä.");
                    return;
                }
                calculator = new HourlyPayCalculator();

            }
            else if (selectedEmployee.PayType == "Kuukausipalkka")
            {
                calculator = new MonthlyPayCalculator();
            }
            else
            {
                MessageBox.Show("Tuntematon palkkatyyppi.");
                return;
            }

            Payslip payslip = calculator.CreatePayslip(selectedEmployee, workedHours);
            ShowPayslip(payslip);
        }

        private void ShowPayslip(Payslip payslip)
        {
            txtboxPayslip.Clear();

            txtboxPayslip.Text =
                $"PALKKALASKELMA{Environment.NewLine}{Environment.NewLine}" +
                $"Työntekijä: {payslip.EmployeeName}{Environment.NewLine}" +
                $"Henkilötunnus: {payslip.SocialSecurityNumber}{Environment.NewLine}" +
                $"Työntekijä ID: {payslip.EmployeeId}{Environment.NewLine}" +
                $"Tehtävänimike: {payslip.JobTitle}{Environment.NewLine}" +
                $"Palkkatyyppi: {payslip.PayType}{Environment.NewLine}";

            if (payslip.PayType == "Tuntipalkka")
            {
                txtboxPayslip.AppendText(
                    $"Tuntipalkka: {payslip.HourlyRateOrMonthlySalary:F2} €{Environment.NewLine}" +
                    $"Työtunnit: {payslip.WorkedHours:F2} h{Environment.NewLine}");
            }
            else
            {
                txtboxPayslip.AppendText(
                    $"Kuukausipalkka: {payslip.HourlyRateOrMonthlySalary:F2} €{Environment.NewLine}");
            }

            txtboxPayslip.AppendText(
                $"{Environment.NewLine}" +
                $"Bruttopalkka: {payslip.GrossPay:F2} €{Environment.NewLine}" +
                $"Veroprosentti: {(payslip.TaxRate * 100):F2} %{Environment.NewLine}" +
                $"Veron osuus: {payslip.TaxAmount:F2} €{Environment.NewLine}" +
                $"Nettopalkka: {payslip.NetPay:F2} €");
        }
    }
}

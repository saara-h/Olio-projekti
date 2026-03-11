using Palkanlaskenta_harjoitustyö.Repos;
using Palkanlaskenta_harjoitustyö.Validators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Palkanlaskenta_harjoitustyö
{
    public partial class AddEmployee : UserControl
    {
        private EmployeeRepository employeeRepository; //repo
        private ValidateNewEmployee validator; //validoinnit

        public AddEmployee(EmployeeRepository repository)
        {
            InitializeComponent();
            employeeRepository = repository;
            validator = new ValidateNewEmployee(employeeRepository);
        }

        //luodaan uusi olio "Lisää"-napilla
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //kerätään syötteet ja siistitään tarpeettomat välilyönnit
            string firstName = txtFirstName.Text.Trim();
            string lastName = txtLastName.Text.Trim();
            DateTime birthdate = dtpBirthdate.Value.Date;
            string ssn = txtSocialSecurityNumber.Text.Trim();
            string address = txtAddress.Text.Trim();
            string jobTitle = comboJobTitle.Text.Trim();
            string payType = comboPayType.Text.Trim();
            string salaryText = txtSalary.Text.Trim();
            string taxRateText = txtTaxRate.Text.Trim();
            
            if (string.IsNullOrEmpty(taxRateText))
            { taxRateText = "60"; } //verokortti puuttuu => 60% veroja

            if (!validator.ValidateNewEmployeeData(firstName, lastName, birthdate, ssn,
                                                address, jobTitle, payType, salaryText, taxRateText,
                                                out decimal salary, out decimal taxRate))
            { return; }

            //kaikki kunnossa, luodaan olio ja tallennetaan
            Employee emp = new Employee
            {
                FirstName = firstName,
                LastName = lastName,
                Birthdate = birthdate,
                SocialSecurityNumber = ssn,
                Address = address,
                JobTitle = jobTitle,
                PayType = payType,
                Salary = salary,
                TaxRate = taxRate / 100m //muutetaan prosentti desimaaliksi
            };

            employeeRepository.AddEmployee(emp);
            MessageBox.Show("Työntekijä tallennettu onnistuneesti!");

            ClearInputs();
        }

        //tyhjennetään syötteet "Tyhjennä"-napilla
        private void btnEmpty_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

        //syötteiden tyhjennysmetodi
        private void ClearInputs()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            dtpBirthdate.Value = DateTime.Today;
            txtSocialSecurityNumber.Clear();
            txtAddress.Clear();
            comboJobTitle.SelectedIndex = -1;
            comboPayType.SelectedIndex = -1;
            txtSalary.Clear();
            txtTaxRate.Clear();
            txtFirstName.Focus();
        }
    }
}

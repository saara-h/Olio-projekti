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

namespace Palkanlaskenta_harjoitustyö.Controls
{
    public partial class ViewEmployees : UserControl
    {
        private EmployeeRepository employeeRepository;
        private ValidateEmployeeUpdate validator;

        public ViewEmployees(EmployeeRepository repository)
        {
            InitializeComponent();
            employeeRepository = repository;
            validator = new ValidateEmployeeUpdate();
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
                txtAddress.Text = selectedEmployee.Address;
                comboJobTitle.Text = selectedEmployee.JobTitle;
                comboPayType.Text = selectedEmployee.PayType;
                txtSalary.Text = selectedEmployee.Salary.ToString("F2");
                txtTaxRate.Text = (selectedEmployee.TaxRate * 100).ToString("F2");
            }

        }

        // peruutetaan tehdyt muutokset lataamalla uudestaan valitun työntekijän tiedot
        // ei toimi toki "päivitä"-napin jälkeen
        private void btnUndoChanges_Click(object sender, EventArgs e)
        {
            listEmployees_SelectedIndexChanged(sender, e);
        }

        //muutetaan valitun työntekijän tietoja ja päivitetään repositoryyn
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (listEmployees.SelectedItem is not Employee selectedEmployee)
            {
                MessageBox.Show("Valitse työntekijä listasta ennen päivitystä.");
                return;
            }

            string address = txtAddress.Text.Trim();
            string jobTitle = comboJobTitle.Text.Trim();
            string payType = comboPayType.Text.Trim();
            string salaryText = txtSalary.Text.Trim();
            string taxRateText = txtTaxRate.Text.Trim();

            if(!validator.ValidateUpdatedEmployeeData(selectedEmployee, address, jobTitle, 
                                                      payType, salaryText, taxRateText, 
                                                      out decimal salary, out decimal taxRate))
            { return; }

            selectedEmployee.Address = address;
            selectedEmployee.JobTitle = jobTitle;
            selectedEmployee.PayType = payType;
            selectedEmployee.Salary = salary;
            selectedEmployee.TaxRate = taxRate / 100m;

            employeeRepository.UpdateEmployee(selectedEmployee);
            LoadEmployees(); 

            MessageBox.Show("Työntekijän tiedot päivitetty onnistuneesti.");
        }
    }
}
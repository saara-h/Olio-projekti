namespace Palkanlaskenta_harjoitustyö
{
    public partial class MainForm : Form
    {
        private EmployeeRepository employeeRepository;
        public MainForm()
        {
            InitializeComponent();
            LoadControl(new HomeControl()); //näyttää kotinäkymän aluksi
            employeeRepository = new EmployeeRepository(); //mainform luo repon, ettei tule tuplia
        }

        //Content-panelin tyhjäys ja valitun UserControlin lataus
        //tehdään joka kerta,kun navigointipainiketta painetaan
        private void LoadControl(UserControl control)
        {
            ContentPanel.Controls.Clear();
            control.Dock = DockStyle.Fill;
            ContentPanel.Controls.Add(control);
        }

        //etusivunäkymän lataus
        private void btnHomeControl_Click(object sender, EventArgs e)
        {
            LoadControl(new HomeControl());
        }

        //työntekijälisäyksen näkymän lataus
        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            LoadControl(new AddEmployee(employeeRepository));
        }

        private void btnViewEmployees_Click(object sender, EventArgs e)
        {
            LoadControl(new Controls.ViewEmployees(employeeRepository));
        }
    }
}

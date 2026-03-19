namespace Palkanlaskenta_harjoitustyö.Controls
{
    partial class CreatePayslip
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listEmployees = new ListBox();
            txtboxPayslip = new RichTextBox();
            txtLastName = new TextBox();
            lblLastName = new Label();
            txtFirstName = new TextBox();
            lblFirstName = new Label();
            txtSocialSecurityNumber = new TextBox();
            lblSocialSecurityNumber = new Label();
            txtEmployeeID = new TextBox();
            lblEmployeeID = new Label();
            lblWorkedHours = new Label();
            txtWorkedHours = new TextBox();
            btnCalculatePay = new Button();
            SuspendLayout();
            // 
            // listEmployees
            // 
            listEmployees.FormattingEnabled = true;
            listEmployees.ItemHeight = 25;
            listEmployees.Location = new Point(0, 0);
            listEmployees.Name = "listEmployees";
            listEmployees.Size = new Size(204, 479);
            listEmployees.TabIndex = 1;
            listEmployees.SelectedIndexChanged += listEmployees_SelectedIndexChanged;
            // 
            // txtboxPayslip
            // 
            txtboxPayslip.Location = new Point(244, 116);
            txtboxPayslip.Name = "txtboxPayslip";
            txtboxPayslip.ReadOnly = true;
            txtboxPayslip.Size = new Size(722, 361);
            txtboxPayslip.TabIndex = 2;
            txtboxPayslip.Text = "";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(424, 65);
            txtLastName.Name = "txtLastName";
            txtLastName.ReadOnly = true;
            txtLastName.Size = new Size(259, 31);
            txtLastName.TabIndex = 16;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(424, 37);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(85, 25);
            lblLastName.TabIndex = 15;
            lblLastName.Text = "Sukunimi";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(242, 65);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.ReadOnly = true;
            txtFirstName.Size = new Size(176, 31);
            txtFirstName.TabIndex = 14;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(242, 37);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(71, 25);
            lblFirstName.TabIndex = 13;
            lblFirstName.Text = "Etunimi";
            // 
            // txtSocialSecurityNumber
            // 
            txtSocialSecurityNumber.Location = new Point(556, 0);
            txtSocialSecurityNumber.Name = "txtSocialSecurityNumber";
            txtSocialSecurityNumber.ReadOnly = true;
            txtSocialSecurityNumber.Size = new Size(129, 31);
            txtSocialSecurityNumber.TabIndex = 12;
            // 
            // lblSocialSecurityNumber
            // 
            lblSocialSecurityNumber.AutoSize = true;
            lblSocialSecurityNumber.Location = new Point(424, 3);
            lblSocialSecurityNumber.Name = "lblSocialSecurityNumber";
            lblSocialSecurityNumber.Size = new Size(126, 25);
            lblSocialSecurityNumber.TabIndex = 11;
            lblSocialSecurityNumber.Text = "Henkilötunnus";
            // 
            // txtEmployeeID
            // 
            txtEmployeeID.Location = new Point(280, 3);
            txtEmployeeID.Name = "txtEmployeeID";
            txtEmployeeID.ReadOnly = true;
            txtEmployeeID.Size = new Size(68, 31);
            txtEmployeeID.TabIndex = 10;
            // 
            // lblEmployeeID
            // 
            lblEmployeeID.AutoSize = true;
            lblEmployeeID.Location = new Point(244, 3);
            lblEmployeeID.Name = "lblEmployeeID";
            lblEmployeeID.Size = new Size(30, 25);
            lblEmployeeID.TabIndex = 9;
            lblEmployeeID.Text = "ID";
            // 
            // lblWorkedHours
            // 
            lblWorkedHours.AutoSize = true;
            lblWorkedHours.Location = new Point(756, 9);
            lblWorkedHours.Name = "lblWorkedHours";
            lblWorkedHours.Size = new Size(61, 25);
            lblWorkedHours.TabIndex = 17;
            lblWorkedHours.Text = "Tunnit";
            // 
            // txtWorkedHours
            // 
            txtWorkedHours.Location = new Point(823, 9);
            txtWorkedHours.Name = "txtWorkedHours";
            txtWorkedHours.Size = new Size(100, 31);
            txtWorkedHours.TabIndex = 18;
            // 
            // btnCalculatePay
            // 
            btnCalculatePay.Location = new Point(756, 55);
            btnCalculatePay.Name = "btnCalculatePay";
            btnCalculatePay.Size = new Size(167, 41);
            btnCalculatePay.TabIndex = 19;
            btnCalculatePay.Text = "Laske palkka";
            btnCalculatePay.UseVisualStyleBackColor = true;
            btnCalculatePay.Click += btnCalculatePay_Click;
            // 
            // CreatePayslip
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnCalculatePay);
            Controls.Add(txtWorkedHours);
            Controls.Add(lblWorkedHours);
            Controls.Add(txtLastName);
            Controls.Add(lblLastName);
            Controls.Add(txtFirstName);
            Controls.Add(lblFirstName);
            Controls.Add(txtSocialSecurityNumber);
            Controls.Add(lblSocialSecurityNumber);
            Controls.Add(txtEmployeeID);
            Controls.Add(lblEmployeeID);
            Controls.Add(txtboxPayslip);
            Controls.Add(listEmployees);
            Name = "CreatePayslip";
            Size = new Size(997, 475);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listEmployees;
        private RichTextBox txtboxPayslip;
        private TextBox txtLastName;
        private Label lblLastName;
        private TextBox txtFirstName;
        private Label lblFirstName;
        private TextBox txtSocialSecurityNumber;
        private Label lblSocialSecurityNumber;
        private TextBox txtEmployeeID;
        private Label lblEmployeeID;
        private Label lblWorkedHours;
        private TextBox txtWorkedHours;
        private Button btnCalculatePay;
    }
}

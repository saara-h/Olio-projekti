using System.Data.Common;

namespace Palkanlaskenta_harjoitustyö
{
    partial class AddEmployee
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
            lblFirstName = new Label();
            txtLastName = new TextBox();
            lblLastName = new Label();
            lblBirthDate = new Label();
            txtAddress = new TextBox();
            lblAddress = new Label();
            lblJobTitle = new Label();
            txtSalary = new TextBox();
            lblSalary = new Label();
            txtTaxRate = new TextBox();
            lblTaxRate = new Label();
            lblPayType = new Label();
            comboJobTitle = new ComboBox();
            comboPayType = new ComboBox();
            btnAdd = new Button();
            btnEmpty = new Button();
            dtpBirthdate = new DateTimePicker();
            txtSocialSecurityNumber = new TextBox();
            lblSocialSecurityNumber = new Label();
            txtFirstName = new TextBox();
            lblEmployeeInfo = new Label();
            lblSalaryInfo = new Label();
            SuspendLayout();
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(54, 71);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(71, 25);
            lblFirstName.TabIndex = 1;
            lblFirstName.Text = "Etunimi";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(273, 99);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(253, 31);
            txtLastName.TabIndex = 4;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(273, 71);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(85, 25);
            lblLastName.TabIndex = 3;
            lblLastName.Text = "Sukunimi";
            // 
            // lblBirthDate
            // 
            lblBirthDate.AutoSize = true;
            lblBirthDate.Location = new Point(54, 148);
            lblBirthDate.Name = "lblBirthDate";
            lblBirthDate.Size = new Size(111, 25);
            lblBirthDate.TabIndex = 5;
            lblBirthDate.Text = "Syntymäaika";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(54, 261);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(474, 31);
            txtAddress.TabIndex = 8;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(54, 233);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(64, 25);
            lblAddress.TabIndex = 7;
            lblAddress.Text = "Osoite";
            // 
            // lblJobTitle
            // 
            lblJobTitle.AutoSize = true;
            lblJobTitle.Location = new Point(585, 71);
            lblJobTitle.Name = "lblJobTitle";
            lblJobTitle.Size = new Size(123, 25);
            lblJobTitle.TabIndex = 9;
            lblJobTitle.Text = "Tehtävänimike";
            // 
            // txtSalary
            // 
            txtSalary.Location = new Point(765, 180);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(93, 31);
            txtSalary.TabIndex = 12;
            // 
            // lblSalary
            // 
            lblSalary.AutoSize = true;
            lblSalary.Location = new Point(765, 150);
            lblSalary.Name = "lblSalary";
            lblSalary.Size = new Size(86, 25);
            lblSalary.TabIndex = 11;
            lblSalary.Text = "Palkka (€)";
            // 
            // txtTaxRate
            // 
            txtTaxRate.Location = new Point(746, 261);
            txtTaxRate.Name = "txtTaxRate";
            txtTaxRate.Size = new Size(82, 31);
            txtTaxRate.TabIndex = 14;
            // 
            // lblTaxRate
            // 
            lblTaxRate.AutoSize = true;
            lblTaxRate.Location = new Point(591, 261);
            lblTaxRate.Name = "lblTaxRate";
            lblTaxRate.Size = new Size(149, 25);
            lblTaxRate.TabIndex = 13;
            lblTaxRate.Text = "Veroprosentti (%)";
            // 
            // lblPayType
            // 
            lblPayType.AutoSize = true;
            lblPayType.Location = new Point(585, 150);
            lblPayType.Name = "lblPayType";
            lblPayType.Size = new Size(98, 25);
            lblPayType.TabIndex = 15;
            lblPayType.Text = "Palkkamalli";
            // 
            // comboJobTitle
            // 
            comboJobTitle.DropDownStyle = ComboBoxStyle.DropDownList;
            comboJobTitle.FormattingEnabled = true;
            comboJobTitle.Items.AddRange(new object[] { "Tehdastyöntekijä", "Kokoonpanija", "Esihenkilö", "Tilaustenkäsittelijä", "Varastotyöntekijä", "HR-assistentti" });
            comboJobTitle.Location = new Point(585, 99);
            comboJobTitle.Name = "comboJobTitle";
            comboJobTitle.Size = new Size(266, 33);
            comboJobTitle.TabIndex = 16;
            // 
            // comboPayType
            // 
            comboPayType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboPayType.FormattingEnabled = true;
            comboPayType.Items.AddRange(new object[] { "Kuukausipalkka", "Tuntipalkka" });
            comboPayType.Location = new Point(585, 178);
            comboPayType.Name = "comboPayType";
            comboPayType.Size = new Size(151, 33);
            comboPayType.TabIndex = 17;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(782, 409);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(104, 43);
            btnAdd.TabIndex = 18;
            btnAdd.Text = "Lisää";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEmpty
            // 
            btnEmpty.Location = new Point(652, 409);
            btnEmpty.Name = "btnEmpty";
            btnEmpty.Size = new Size(103, 43);
            btnEmpty.TabIndex = 19;
            btnEmpty.Text = "Tyhjää";
            btnEmpty.UseVisualStyleBackColor = true;
            btnEmpty.Click += btnEmpty_Click;
            // 
            // dtpBirthdate
            // 
            dtpBirthdate.Format = DateTimePickerFormat.Short;
            dtpBirthdate.Location = new Point(54, 176);
            dtpBirthdate.MaxDate = new DateTime(2026, 3, 12, 0, 0, 0, 0);
            dtpBirthdate.Name = "dtpBirthdate";
            dtpBirthdate.RightToLeft = RightToLeft.No;
            dtpBirthdate.Size = new Size(201, 31);
            dtpBirthdate.TabIndex = 22;
            dtpBirthdate.Value = new DateTime(2026, 3, 12, 0, 0, 0, 0);
            // 
            // txtSocialSecurityNumber
            // 
            txtSocialSecurityNumber.Location = new Point(273, 178);
            txtSocialSecurityNumber.Name = "txtSocialSecurityNumber";
            txtSocialSecurityNumber.Size = new Size(253, 31);
            txtSocialSecurityNumber.TabIndex = 23;
            // 
            // lblSocialSecurityNumber
            // 
            lblSocialSecurityNumber.AutoSize = true;
            lblSocialSecurityNumber.Location = new Point(273, 148);
            lblSocialSecurityNumber.Name = "lblSocialSecurityNumber";
            lblSocialSecurityNumber.Size = new Size(126, 25);
            lblSocialSecurityNumber.TabIndex = 24;
            lblSocialSecurityNumber.Text = "Henkilötunnus";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(54, 99);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(201, 31);
            txtFirstName.TabIndex = 2;
            // 
            // lblEmployeeInfo
            // 
            lblEmployeeInfo.AutoSize = true;
            lblEmployeeInfo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmployeeInfo.Location = new Point(54, 26);
            lblEmployeeInfo.Name = "lblEmployeeInfo";
            lblEmployeeInfo.Size = new Size(170, 32);
            lblEmployeeInfo.TabIndex = 25;
            lblEmployeeInfo.Text = "Henkilötiedot";
            // 
            // lblSalaryInfo
            // 
            lblSalaryInfo.AutoSize = true;
            lblSalaryInfo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSalaryInfo.Location = new Point(585, 26);
            lblSalaryInfo.Name = "lblSalaryInfo";
            lblSalaryInfo.Size = new Size(155, 32);
            lblSalaryInfo.TabIndex = 26;
            lblSalaryInfo.Text = "Palkkatiedot";
            // 
            // AddEmployee
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(lblSalaryInfo);
            Controls.Add(lblEmployeeInfo);
            Controls.Add(lblSocialSecurityNumber);
            Controls.Add(txtSocialSecurityNumber);
            Controls.Add(dtpBirthdate);
            Controls.Add(btnEmpty);
            Controls.Add(btnAdd);
            Controls.Add(comboPayType);
            Controls.Add(comboJobTitle);
            Controls.Add(lblPayType);
            Controls.Add(txtTaxRate);
            Controls.Add(lblTaxRate);
            Controls.Add(txtSalary);
            Controls.Add(lblSalary);
            Controls.Add(lblJobTitle);
            Controls.Add(txtAddress);
            Controls.Add(lblAddress);
            Controls.Add(lblBirthDate);
            Controls.Add(txtLastName);
            Controls.Add(lblLastName);
            Controls.Add(txtFirstName);
            Controls.Add(lblFirstName);
            Name = "AddEmployee";
            Size = new Size(997, 475);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listEmployees;
        private Label lblFirstName;
        private TextBox txtLastName;
        private Label lblLastName;
        private Label lblBirthDate;
        private TextBox txtAddress;
        private Label lblAddress;
        private Label lblJobTitle;
        private TextBox txtSalary;
        private Label lblSalary;
        private TextBox txtTaxRate;
        private Label lblTaxRate;
        private Label lblPayType;
        private ComboBox comboJobTitle;
        private ComboBox comboPayType;
        private Button btnAdd;
        private Button btnEmpty;
        private DateTimePicker dtpBirthdate;
        private TextBox txtSocialSecurityNumber;
        private Label lblSocialSecurityNumber;
        private TextBox txtFirstName;
        private Label lblEmployeeInfo;
        private Label lblSalaryInfo;
    }
}

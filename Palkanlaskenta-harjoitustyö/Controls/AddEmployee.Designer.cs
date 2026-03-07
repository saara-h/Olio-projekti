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
            txtFirstName = new TextBox();
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
            lblEmployeeID = new Label();
            textBox1 = new TextBox();
            dtpBirthdate = new DateTimePicker();
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
            // txtFirstName
            // 
            txtFirstName.Location = new Point(54, 99);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(190, 31);
            txtFirstName.TabIndex = 2;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(250, 99);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(293, 31);
            txtLastName.TabIndex = 4;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(250, 71);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(85, 25);
            lblLastName.TabIndex = 3;
            lblLastName.Text = "Sukunimi";
            // 
            // lblBirthDate
            // 
            lblBirthDate.AutoSize = true;
            lblBirthDate.Location = new Point(54, 133);
            lblBirthDate.Name = "lblBirthDate";
            lblBirthDate.Size = new Size(111, 25);
            lblBirthDate.TabIndex = 5;
            lblBirthDate.Text = "Syntymäaika";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(54, 223);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(489, 31);
            txtAddress.TabIndex = 8;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(54, 195);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(64, 25);
            lblAddress.TabIndex = 7;
            lblAddress.Text = "Osoite";
            // 
            // lblJobTitle
            // 
            lblJobTitle.AutoSize = true;
            lblJobTitle.Location = new Point(54, 257);
            lblJobTitle.Name = "lblJobTitle";
            lblJobTitle.Size = new Size(123, 25);
            lblJobTitle.TabIndex = 9;
            lblJobTitle.Text = "Tehtävänimike";
            // 
            // txtSalary
            // 
            txtSalary.Location = new Point(466, 287);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(82, 31);
            txtSalary.TabIndex = 12;
            // 
            // lblSalary
            // 
            lblSalary.AutoSize = true;
            lblSalary.Location = new Point(466, 257);
            lblSalary.Name = "lblSalary";
            lblSalary.Size = new Size(86, 25);
            lblSalary.TabIndex = 11;
            lblSalary.Text = "Palkka (€)";
            // 
            // txtTaxRate
            // 
            txtTaxRate.Location = new Point(209, 342);
            txtTaxRate.Name = "txtTaxRate";
            txtTaxRate.Size = new Size(71, 31);
            txtTaxRate.TabIndex = 14;
            // 
            // lblTaxRate
            // 
            lblTaxRate.AutoSize = true;
            lblTaxRate.Location = new Point(54, 342);
            lblTaxRate.Name = "lblTaxRate";
            lblTaxRate.Size = new Size(149, 25);
            lblTaxRate.TabIndex = 13;
            lblTaxRate.Text = "Veroprosentti (%)";
            // 
            // lblPayType
            // 
            lblPayType.AutoSize = true;
            lblPayType.Location = new Point(320, 257);
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
            comboJobTitle.Location = new Point(54, 285);
            comboJobTitle.Name = "comboJobTitle";
            comboJobTitle.Size = new Size(255, 33);
            comboJobTitle.TabIndex = 16;
            // 
            // comboPayType
            // 
            comboPayType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboPayType.FormattingEnabled = true;
            comboPayType.Items.AddRange(new object[] { "Kuukausipalkka", "Tuntipalkka" });
            comboPayType.Location = new Point(320, 285);
            comboPayType.Name = "comboPayType";
            comboPayType.Size = new Size(140, 33);
            comboPayType.TabIndex = 17;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(431, 418);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 34);
            btnAdd.TabIndex = 18;
            btnAdd.Text = "Lisää";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEmpty
            // 
            btnEmpty.Location = new Point(306, 418);
            btnEmpty.Name = "btnEmpty";
            btnEmpty.Size = new Size(112, 34);
            btnEmpty.TabIndex = 19;
            btnEmpty.Text = "Tyhjää";
            btnEmpty.UseVisualStyleBackColor = true;
            btnEmpty.Click += btnEmpty_Click;
            // 
            // lblEmployeeID
            // 
            lblEmployeeID.AutoSize = true;
            lblEmployeeID.Location = new Point(56, 30);
            lblEmployeeID.Name = "lblEmployeeID";
            lblEmployeeID.Size = new Size(30, 25);
            lblEmployeeID.TabIndex = 20;
            lblEmployeeID.Text = "ID";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(92, 27);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(33, 31);
            textBox1.TabIndex = 21;
            // 
            // dtpBirthdate
            // 
            dtpBirthdate.Format = DateTimePickerFormat.Short;
            dtpBirthdate.Location = new Point(54, 161);
            dtpBirthdate.MaxDate = new DateTime(2026, 3, 7, 0, 0, 0, 0);
            dtpBirthdate.Name = "dtpBirthdate";
            dtpBirthdate.RightToLeft = RightToLeft.No;
            dtpBirthdate.Size = new Size(150, 31);
            dtpBirthdate.TabIndex = 22;
            dtpBirthdate.Value = new DateTime(2026, 3, 7, 0, 0, 0, 0);
            // 
            // AddEmployee
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(dtpBirthdate);
            Controls.Add(textBox1);
            Controls.Add(lblEmployeeID);
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
            Size = new Size(668, 514);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listEmployees;
        private Label lblFirstName;
        private TextBox txtFirstName;
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
        private Label lblEmployeeID;
        private TextBox textBox1;
        private DateTimePicker dtpBirthdate;
    }
}

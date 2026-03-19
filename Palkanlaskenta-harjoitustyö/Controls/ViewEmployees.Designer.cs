namespace Palkanlaskenta_harjoitustyö.Controls
{
    partial class ViewEmployees
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
            lblEmployeeID = new Label();
            txtEmployeeID = new TextBox();
            txtSocialSecurityNumber = new TextBox();
            lblSocialSecurityNumber = new Label();
            lblFirstName = new Label();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            lblLastName = new Label();
            txtAddress = new TextBox();
            lblAddress = new Label();
            comboPayType = new ComboBox();
            comboJobTitle = new ComboBox();
            lblPayType = new Label();
            txtTaxRate = new TextBox();
            lblTaxRate = new Label();
            txtSalary = new TextBox();
            lblSalary = new Label();
            lblJobTitle = new Label();
            btnUndoChanges = new Button();
            btnUpdate = new Button();
            SuspendLayout();
            // 
            // listEmployees
            // 
            listEmployees.FormattingEnabled = true;
            listEmployees.ItemHeight = 25;
            listEmployees.Location = new Point(12, 15);
            listEmployees.Name = "listEmployees";
            listEmployees.Size = new Size(238, 479);
            listEmployees.TabIndex = 0;
            listEmployees.SelectedIndexChanged += listEmployees_SelectedIndexChanged;
            // 
            // lblEmployeeID
            // 
            lblEmployeeID.AutoSize = true;
            lblEmployeeID.Location = new Point(362, 28);
            lblEmployeeID.Name = "lblEmployeeID";
            lblEmployeeID.Size = new Size(30, 25);
            lblEmployeeID.TabIndex = 1;
            lblEmployeeID.Text = "ID";
            // 
            // txtEmployeeID
            // 
            txtEmployeeID.Location = new Point(398, 28);
            txtEmployeeID.Name = "txtEmployeeID";
            txtEmployeeID.ReadOnly = true;
            txtEmployeeID.Size = new Size(68, 31);
            txtEmployeeID.TabIndex = 2;
            // 
            // txtSocialSecurityNumber
            // 
            txtSocialSecurityNumber.Location = new Point(674, 25);
            txtSocialSecurityNumber.Name = "txtSocialSecurityNumber";
            txtSocialSecurityNumber.ReadOnly = true;
            txtSocialSecurityNumber.Size = new Size(129, 31);
            txtSocialSecurityNumber.TabIndex = 4;
            // 
            // lblSocialSecurityNumber
            // 
            lblSocialSecurityNumber.AutoSize = true;
            lblSocialSecurityNumber.Location = new Point(542, 28);
            lblSocialSecurityNumber.Name = "lblSocialSecurityNumber";
            lblSocialSecurityNumber.Size = new Size(126, 25);
            lblSocialSecurityNumber.TabIndex = 3;
            lblSocialSecurityNumber.Text = "Henkilötunnus";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(362, 76);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(71, 25);
            lblFirstName.TabIndex = 5;
            lblFirstName.Text = "Etunimi";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(362, 104);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.ReadOnly = true;
            txtFirstName.Size = new Size(176, 31);
            txtFirstName.TabIndex = 6;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(544, 104);
            txtLastName.Name = "txtLastName";
            txtLastName.ReadOnly = true;
            txtLastName.Size = new Size(259, 31);
            txtLastName.TabIndex = 8;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(544, 76);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(85, 25);
            lblLastName.TabIndex = 7;
            lblLastName.Text = "Sukunimi";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(361, 169);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(442, 31);
            txtAddress.TabIndex = 10;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(361, 141);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(64, 25);
            lblAddress.TabIndex = 9;
            lblAddress.Text = "Osoite";
            // 
            // comboPayType
            // 
            comboPayType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboPayType.FormattingEnabled = true;
            comboPayType.Items.AddRange(new object[] { "Kuukausipalkka", "Tuntipalkka" });
            comboPayType.Location = new Point(640, 242);
            comboPayType.Name = "comboPayType";
            comboPayType.Size = new Size(164, 33);
            comboPayType.TabIndex = 25;
            // 
            // comboJobTitle
            // 
            comboJobTitle.DropDownStyle = ComboBoxStyle.DropDownList;
            comboJobTitle.FormattingEnabled = true;
            comboJobTitle.Items.AddRange(new object[] { "Tehdastyöntekijä", "Kokoonpanija", "Esihenkilö", "Tilaustenkäsittelijä", "Varastotyöntekijä", "HR-assistentti" });
            comboJobTitle.Location = new Point(362, 242);
            comboJobTitle.Name = "comboJobTitle";
            comboJobTitle.Size = new Size(255, 33);
            comboJobTitle.TabIndex = 24;
            // 
            // lblPayType
            // 
            lblPayType.AutoSize = true;
            lblPayType.Location = new Point(640, 214);
            lblPayType.Name = "lblPayType";
            lblPayType.Size = new Size(98, 25);
            lblPayType.TabIndex = 23;
            lblPayType.Text = "Palkkamalli";
            // 
            // txtTaxRate
            // 
            txtTaxRate.Location = new Point(518, 318);
            txtTaxRate.Name = "txtTaxRate";
            txtTaxRate.Size = new Size(80, 31);
            txtTaxRate.TabIndex = 22;
            // 
            // lblTaxRate
            // 
            lblTaxRate.AutoSize = true;
            lblTaxRate.Location = new Point(508, 288);
            lblTaxRate.Name = "lblTaxRate";
            lblTaxRate.Size = new Size(149, 25);
            lblTaxRate.TabIndex = 21;
            lblTaxRate.Text = "Veroprosentti (%)";
            // 
            // txtSalary
            // 
            txtSalary.Location = new Point(362, 318);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(82, 31);
            txtSalary.TabIndex = 20;
            // 
            // lblSalary
            // 
            lblSalary.AutoSize = true;
            lblSalary.Location = new Point(362, 288);
            lblSalary.Name = "lblSalary";
            lblSalary.Size = new Size(86, 25);
            lblSalary.TabIndex = 19;
            lblSalary.Text = "Palkka (€)";
            // 
            // lblJobTitle
            // 
            lblJobTitle.AutoSize = true;
            lblJobTitle.Location = new Point(362, 214);
            lblJobTitle.Name = "lblJobTitle";
            lblJobTitle.Size = new Size(123, 25);
            lblJobTitle.TabIndex = 18;
            lblJobTitle.Text = "Tehtävänimike";
            // 
            // btnUndoChanges
            // 
            btnUndoChanges.Location = new Point(702, 398);
            btnUndoChanges.Name = "btnUndoChanges";
            btnUndoChanges.Size = new Size(117, 46);
            btnUndoChanges.TabIndex = 27;
            btnUndoChanges.Text = "Palauta";
            btnUndoChanges.UseVisualStyleBackColor = true;
            btnUndoChanges.Click += btnUndoChanges_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(825, 398);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(133, 46);
            btnUpdate.TabIndex = 26;
            btnUpdate.Text = "Päivitä tiedot";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // ViewEmployees
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnUndoChanges);
            Controls.Add(btnUpdate);
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
            Controls.Add(txtLastName);
            Controls.Add(lblLastName);
            Controls.Add(txtFirstName);
            Controls.Add(lblFirstName);
            Controls.Add(txtSocialSecurityNumber);
            Controls.Add(lblSocialSecurityNumber);
            Controls.Add(txtEmployeeID);
            Controls.Add(lblEmployeeID);
            Controls.Add(listEmployees);
            Name = "ViewEmployees";
            Size = new Size(997, 475);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listEmployees;
        private Label lblEmployeeID;
        private TextBox txtEmployeeID;
        private TextBox txtSocialSecurityNumber;
        private Label lblSocialSecurityNumber;
        private Label lblFirstName;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private Label lblLastName;
        private TextBox txtAddress;
        private Label lblAddress;
        private ComboBox comboPayType;
        private ComboBox comboJobTitle;
        private Label lblPayType;
        private TextBox txtTaxRate;
        private Label lblTaxRate;
        private TextBox txtSalary;
        private Label lblSalary;
        private Label lblJobTitle;
        private Button btnUndoChanges;
        private Button btnUpdate;
    }
}

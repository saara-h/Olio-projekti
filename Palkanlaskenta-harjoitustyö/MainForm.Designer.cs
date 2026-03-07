namespace Palkanlaskenta_harjoitustyö
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            MenuPanel = new Panel();
            btnCreatePayslip = new Button();
            btnUpdateEmployee = new Button();
            btnAddEmployee = new Button();
            btnHomeControl = new Button();
            ContentPanel = new Panel();
            MenuPanel.SuspendLayout();
            SuspendLayout();
            // 
            // MenuPanel
            // 
            MenuPanel.Controls.Add(btnCreatePayslip);
            MenuPanel.Controls.Add(btnUpdateEmployee);
            MenuPanel.Controls.Add(btnAddEmployee);
            MenuPanel.Controls.Add(btnHomeControl);
            MenuPanel.Dock = DockStyle.Top;
            MenuPanel.Location = new Point(0, 0);
            MenuPanel.Name = "MenuPanel";
            MenuPanel.Size = new Size(741, 56);
            MenuPanel.TabIndex = 0;
            // 
            // btnCreatePayslip
            // 
            btnCreatePayslip.Dock = DockStyle.Left;
            btnCreatePayslip.Location = new Point(492, 0);
            btnCreatePayslip.Name = "btnCreatePayslip";
            btnCreatePayslip.Size = new Size(160, 56);
            btnCreatePayslip.TabIndex = 3;
            btnCreatePayslip.Text = "Palkanlaskenta";
            btnCreatePayslip.UseVisualStyleBackColor = true;
            // 
            // btnUpdateEmployee
            // 
            btnUpdateEmployee.Dock = DockStyle.Left;
            btnUpdateEmployee.Location = new Point(316, 0);
            btnUpdateEmployee.Name = "btnUpdateEmployee";
            btnUpdateEmployee.Size = new Size(176, 56);
            btnUpdateEmployee.TabIndex = 2;
            btnUpdateEmployee.Text = "Henkilöstöhallinto";
            btnUpdateEmployee.UseVisualStyleBackColor = true;
            // 
            // btnAddEmployee
            // 
            btnAddEmployee.Dock = DockStyle.Left;
            btnAddEmployee.Location = new Point(155, 0);
            btnAddEmployee.Name = "btnAddEmployee";
            btnAddEmployee.Size = new Size(161, 56);
            btnAddEmployee.TabIndex = 1;
            btnAddEmployee.Text = "Uusi työntekijä";
            btnAddEmployee.UseVisualStyleBackColor = true;
            btnAddEmployee.Click += btnAddEmployee_Click;
            // 
            // btnHomeControl
            // 
            btnHomeControl.Dock = DockStyle.Left;
            btnHomeControl.Location = new Point(0, 0);
            btnHomeControl.Name = "btnHomeControl";
            btnHomeControl.Size = new Size(155, 56);
            btnHomeControl.TabIndex = 0;
            btnHomeControl.Text = "Etusivu";
            btnHomeControl.UseVisualStyleBackColor = true;
            btnHomeControl.Click += btnHomeControl_Click;
            // 
            // ContentPanel
            // 
            ContentPanel.Dock = DockStyle.Fill;
            ContentPanel.Location = new Point(0, 56);
            ContentPanel.Name = "ContentPanel";
            ContentPanel.Size = new Size(741, 499);
            ContentPanel.TabIndex = 1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(741, 555);
            Controls.Add(ContentPanel);
            Controls.Add(MenuPanel);
            Name = "MainForm";
            Text = "MainForm";
            MenuPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel MenuPanel;
        private Button btnUpdateEmployee;
        private Button btnAddEmployee;
        private Button btnHomeControl;
        private Panel ContentPanel;
        private Button btnCreatePayslip;
    }
}

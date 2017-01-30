namespace SalesBonus
{
    partial class MailOrder
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CalculateButton = new System.Windows.Forms.Button();
            this.PrintButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.EmployeeNameLabel = new System.Windows.Forms.Label();
            this.EmployeeIdLabel = new System.Windows.Forms.Label();
            this.HoursWorkedLabel = new System.Windows.Forms.Label();
            this.TotalSalesLabel = new System.Windows.Forms.Label();
            this.SalesBonusLabel = new System.Windows.Forms.Label();
            this.EmployeeNameTextBox = new System.Windows.Forms.TextBox();
            this.EmployeeIdTextBox = new System.Windows.Forms.TextBox();
            this.HoursWorkedTextBox = new System.Windows.Forms.TextBox();
            this.TotalSalesTextBox = new System.Windows.Forms.TextBox();
            this.SalesBonusTextBox = new System.Windows.Forms.TextBox();
            this.LanguagesGroupBox = new System.Windows.Forms.GroupBox();
            this.FrenchLangRadioButton = new System.Windows.Forms.RadioButton();
            this.EnglishLangRadioButton = new System.Windows.Forms.RadioButton();
            this.CompanyLogoPictureBox = new System.Windows.Forms.PictureBox();
            this.LanguagesGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CompanyLogoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(12, 326);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(75, 23);
            this.CalculateButton.TabIndex = 0;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // PrintButton
            // 
            this.PrintButton.Location = new System.Drawing.Point(171, 326);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(75, 23);
            this.PrintButton.TabIndex = 1;
            this.PrintButton.Text = "Print";
            this.PrintButton.UseVisualStyleBackColor = true;
            this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(285, 326);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 2;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // EmployeeNameLabel
            // 
            this.EmployeeNameLabel.AutoSize = true;
            this.EmployeeNameLabel.Location = new System.Drawing.Point(16, 137);
            this.EmployeeNameLabel.Name = "EmployeeNameLabel";
            this.EmployeeNameLabel.Size = new System.Drawing.Size(94, 13);
            this.EmployeeNameLabel.TabIndex = 3;
            this.EmployeeNameLabel.Text = "Employees\'s name";
            this.EmployeeNameLabel.Click += new System.EventHandler(this.EmployeeName_Click);
            // 
            // EmployeeIdLabel
            // 
            this.EmployeeIdLabel.AutoSize = true;
            this.EmployeeIdLabel.Location = new System.Drawing.Point(12, 171);
            this.EmployeeIdLabel.Name = "EmployeeIdLabel";
            this.EmployeeIdLabel.Size = new System.Drawing.Size(67, 13);
            this.EmployeeIdLabel.TabIndex = 4;
            this.EmployeeIdLabel.Text = "Employee ID";
            this.EmployeeIdLabel.Click += new System.EventHandler(this.EmployeeId_Click);
            // 
            // HoursWorkedLabel
            // 
            this.HoursWorkedLabel.AutoSize = true;
            this.HoursWorkedLabel.Location = new System.Drawing.Point(12, 208);
            this.HoursWorkedLabel.Name = "HoursWorkedLabel";
            this.HoursWorkedLabel.Size = new System.Drawing.Size(76, 13);
            this.HoursWorkedLabel.TabIndex = 5;
            this.HoursWorkedLabel.Text = "Hours Worked";
            this.HoursWorkedLabel.Click += new System.EventHandler(this.HoursWorked_Click);
            // 
            // TotalSalesLabel
            // 
            this.TotalSalesLabel.AutoSize = true;
            this.TotalSalesLabel.Location = new System.Drawing.Point(12, 245);
            this.TotalSalesLabel.Name = "TotalSalesLabel";
            this.TotalSalesLabel.Size = new System.Drawing.Size(60, 13);
            this.TotalSalesLabel.TabIndex = 6;
            this.TotalSalesLabel.Text = "Total Sales";
            this.TotalSalesLabel.Click += new System.EventHandler(this.TotalSales_Click);
            // 
            // SalesBonusLabel
            // 
            this.SalesBonusLabel.AutoSize = true;
            this.SalesBonusLabel.Location = new System.Drawing.Point(16, 283);
            this.SalesBonusLabel.Name = "SalesBonusLabel";
            this.SalesBonusLabel.Size = new System.Drawing.Size(66, 13);
            this.SalesBonusLabel.TabIndex = 7;
            this.SalesBonusLabel.Text = "Sales Bonus";
            this.SalesBonusLabel.Click += new System.EventHandler(this.SalesBonus_Click);
            // 
            // EmployeeNameTextBox
            // 
            this.EmployeeNameTextBox.Location = new System.Drawing.Point(162, 134);
            this.EmployeeNameTextBox.Name = "EmployeeNameTextBox";
            this.EmployeeNameTextBox.Size = new System.Drawing.Size(210, 20);
            this.EmployeeNameTextBox.TabIndex = 8;
            // 
            // EmployeeIdTextBox
            // 
            this.EmployeeIdTextBox.Location = new System.Drawing.Point(162, 175);
            this.EmployeeIdTextBox.Name = "EmployeeIdTextBox";
            this.EmployeeIdTextBox.Size = new System.Drawing.Size(136, 20);
            this.EmployeeIdTextBox.TabIndex = 9;
            // 
            // HoursWorkedTextBox
            // 
            this.HoursWorkedTextBox.Location = new System.Drawing.Point(162, 212);
            this.HoursWorkedTextBox.Name = "HoursWorkedTextBox";
            this.HoursWorkedTextBox.Size = new System.Drawing.Size(136, 20);
            this.HoursWorkedTextBox.TabIndex = 10;
            // 
            // TotalSalesTextBox
            // 
            this.TotalSalesTextBox.Location = new System.Drawing.Point(162, 242);
            this.TotalSalesTextBox.Name = "TotalSalesTextBox";
            this.TotalSalesTextBox.Size = new System.Drawing.Size(136, 20);
            this.TotalSalesTextBox.TabIndex = 11;
            // 
            // SalesBonusTextBox
            // 
            this.SalesBonusTextBox.Location = new System.Drawing.Point(162, 280);
            this.SalesBonusTextBox.Name = "SalesBonusTextBox";
            this.SalesBonusTextBox.ReadOnly = true;
            this.SalesBonusTextBox.Size = new System.Drawing.Size(136, 20);
            this.SalesBonusTextBox.TabIndex = 12;
            // 
            // LanguagesGroupBox
            // 
            this.LanguagesGroupBox.Controls.Add(this.FrenchLangRadioButton);
            this.LanguagesGroupBox.Controls.Add(this.EnglishLangRadioButton);
            this.LanguagesGroupBox.Location = new System.Drawing.Point(171, 13);
            this.LanguagesGroupBox.Name = "LanguagesGroupBox";
            this.LanguagesGroupBox.Size = new System.Drawing.Size(189, 100);
            this.LanguagesGroupBox.TabIndex = 13;
            this.LanguagesGroupBox.TabStop = false;
            this.LanguagesGroupBox.Text = "Languages";
            this.LanguagesGroupBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // FrenchLangRadioButton
            // 
            this.FrenchLangRadioButton.AutoSize = true;
            this.FrenchLangRadioButton.Location = new System.Drawing.Point(7, 44);
            this.FrenchLangRadioButton.Name = "FrenchLangRadioButton";
            this.FrenchLangRadioButton.Size = new System.Drawing.Size(65, 17);
            this.FrenchLangRadioButton.TabIndex = 1;
            this.FrenchLangRadioButton.Text = "Francais";
            this.FrenchLangRadioButton.UseVisualStyleBackColor = true;
            this.FrenchLangRadioButton.CheckedChanged += new System.EventHandler(this.FrenchLangRadioButton_CheckedChanged);
            // 
            // EnglishLangRadioButton
            // 
            this.EnglishLangRadioButton.AutoSize = true;
            this.EnglishLangRadioButton.Checked = true;
            this.EnglishLangRadioButton.Location = new System.Drawing.Point(7, 20);
            this.EnglishLangRadioButton.Name = "EnglishLangRadioButton";
            this.EnglishLangRadioButton.Size = new System.Drawing.Size(59, 17);
            this.EnglishLangRadioButton.TabIndex = 0;
            this.EnglishLangRadioButton.TabStop = true;
            this.EnglishLangRadioButton.Text = "English";
            this.EnglishLangRadioButton.UseVisualStyleBackColor = true;
            this.EnglishLangRadioButton.CheckedChanged += new System.EventHandler(this.EnglishLangRadioButton_CheckedChanged);
            // 
            // CompanyLogoPictureBox
            // 
            this.CompanyLogoPictureBox.Image = global::SalesBonus.Properties.Resources.Sharp5;
            this.CompanyLogoPictureBox.Location = new System.Drawing.Point(19, 13);
            this.CompanyLogoPictureBox.Name = "CompanyLogoPictureBox";
            this.CompanyLogoPictureBox.Size = new System.Drawing.Size(134, 100);
            this.CompanyLogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.CompanyLogoPictureBox.TabIndex = 14;
            this.CompanyLogoPictureBox.TabStop = false;
            this.CompanyLogoPictureBox.Click += new System.EventHandler(this.CompanyLogo_Click);
            // 
            // MailOrder
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.CompanyLogoPictureBox);
            this.Controls.Add(this.LanguagesGroupBox);
            this.Controls.Add(this.SalesBonusTextBox);
            this.Controls.Add(this.TotalSalesTextBox);
            this.Controls.Add(this.HoursWorkedTextBox);
            this.Controls.Add(this.EmployeeIdTextBox);
            this.Controls.Add(this.EmployeeNameTextBox);
            this.Controls.Add(this.SalesBonusLabel);
            this.Controls.Add(this.TotalSalesLabel);
            this.Controls.Add(this.HoursWorkedLabel);
            this.Controls.Add(this.EmployeeIdLabel);
            this.Controls.Add(this.EmployeeNameLabel);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.PrintButton);
            this.Controls.Add(this.CalculateButton);
            this.Name = "MailOrder";
            this.Text = "Sales Bonus";
            this.LanguagesGroupBox.ResumeLayout(false);
            this.LanguagesGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CompanyLogoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button PrintButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Label EmployeeNameLabel;
        private System.Windows.Forms.Label EmployeeIdLabel;
        private System.Windows.Forms.Label HoursWorkedLabel;
        private System.Windows.Forms.Label TotalSalesLabel;
        private System.Windows.Forms.Label SalesBonusLabel;
        private System.Windows.Forms.TextBox EmployeeNameTextBox;
        private System.Windows.Forms.TextBox EmployeeIdTextBox;
        private System.Windows.Forms.TextBox HoursWorkedTextBox;
        private System.Windows.Forms.TextBox TotalSalesTextBox;
        private System.Windows.Forms.TextBox SalesBonusTextBox;
        private System.Windows.Forms.GroupBox LanguagesGroupBox;
        private System.Windows.Forms.RadioButton FrenchLangRadioButton;
        private System.Windows.Forms.RadioButton EnglishLangRadioButton;
        private System.Windows.Forms.PictureBox CompanyLogoPictureBox;
    }
}


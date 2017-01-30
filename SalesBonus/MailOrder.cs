using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesBonus
{
    /// <summary>
    /// This class creates a form to calculate the sales bonus of each employee and it extends
    /// from the 'Form' class
    /// </summary>
    public partial class MailOrder : Form
    {
        public MailOrder()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This method clears the contents of the text boxes except those of the 'Total Sales' text box
        /// when the clear button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearButton_Click(object sender, EventArgs e)
        {
            //clearing the values in the text boxes
            EmployeeIdTextBox.Clear();
            EmployeeNameTextBox.Clear();
            HoursWorkedTextBox.Clear();
            SalesBonusTextBox.Clear();
        }
        /// <summary>
        /// This method prints a message in a dialog box on the screen when the print button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PrintButton_Click(object sender, EventArgs e)
        {
            //printing a message to the screen
            MessageBox.Show("The form is being sent to the printer");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void SalesBonus_Click(object sender, EventArgs e)
        {

        }

        private void CompanyLogo_Click(object sender, EventArgs e)
        {

        }

        private void EmployeeName_Click(object sender, EventArgs e)
        {

        }

        private void EmployeeId_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// This method checks that only valid data is entered in the 'Hours Worked' text box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HoursWorked_Click(object sender, EventArgs e)
        {
            string hours = HoursWorkedTextBox.Text;
            //converting hours worked into an 'int' data type
            int hour = Convert.ToInt32(hours);
            //checking if the hours worked value does not lie in the range of 0-160 and hence displaying appropriate messages
            if (hour > 160)
                MessageBox.Show("The number of hours worked cannot be greater than 160");
            else if (hour < 0)
                MessageBox.Show("The number of hours worked cannot be negative");
        }
        /// <summary>
        /// This method accepts the total sales of the company as entered by the user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TotalSales_Click(object sender, EventArgs e)
        {
            string totalSales = TotalSalesTextBox.Text;

        }

        private void EnglishLangRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FrenchLangRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            
        }
        /// <summary>
        /// This method calculates the sales bonus of an employee when the calculate button is clicked 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalculateButton_Click(object sender, EventArgs e)
        {
            //converting hours worked to a double value
            double hoursWorked = Convert.ToDouble(HoursWorkedTextBox.Text);
            //calculating the bonus amount and converting it into a double value
            double bonusAmount = Convert.ToDouble(TotalSalesTextBox.Text) * 0.02;
            //calculating the bonus earned by the employee which is a double value
            double bonusEarned = (hoursWorked / 160) * bonusAmount;
            //converting the value of bonus earned from double to string because the text box takes a string value
            SalesBonusTextBox.Text = Convert.ToString(bonusEarned);
        }
    }
}

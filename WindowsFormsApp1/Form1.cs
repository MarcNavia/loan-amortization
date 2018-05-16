// Application Name: Loan Amortization
// App Developer: Marc Navia on 2/27/2018
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        } 
        //Declaring the global variables to be used in multiple methods
        double acceptedInterest, acceptedPayment, finalTotalInterest, finalTotalPayment ;

        private void calculateButton_Click(object sender, EventArgs e)
        {
            //Declaring the variables
            double rate, loan, principalPayment, interest, fullPayment, rebate;
            //Declaring variables to 0 to hold future values
            double totalInterest= 0, totalPrincipal= 0, totalPayment= 0;
            int numberOfMonths =  0;
            int months;

            try
            {
                //Taking the user inputed data from the textbox and inputing into the two variables
                double.TryParse(loanAmountTextBox.Text, out loan);
                double.TryParse(annualAprTextBox.Text, out rate);

                //If there are no values in the textboxes return  an error messages to the user to input values. Sets focus back to loan
                if ((loan == 0) || (rate == 0))
                {
                    MessageBox.Show("Please enter a value for loan and rate.", "Error Message", MessageBoxButtons.RetryCancel
                        , MessageBoxIcon.Error);
                    loanAmountTextBox.Focus();
                }

                //Conditional logic where whatever radio button is checked returns the respective value into the numberOfMonths Variable
                if (sixRadioButton.Checked)
                    numberOfMonths = 6;
                else if (twelveRadioButton.Checked)
                    numberOfMonths = 12;
                else if (eightTeenRadiobutton.Checked)
                    numberOfMonths = 18;
                else if (twentyFourRadioButton.Checked)
                    numberOfMonths = 24;
                
                //Takes inputed rebate value and stores in the variable rebate
                double.TryParse(rebateTextBox.Text, out rebate);

                //Calculates the loan value
                loan = loan - rebate;

                //Converting the rate variable from a percent into a decimal
                rate = rate / 100;

                //Format code for the five columns of the listbox
                string formatCode = "{0,5}{1,12}{2,12}{3,12}{4,12}";

                //Calculating the principal payment
                principalPayment = rate / 12 * (loan + 0 * Math.Pow(1 + rate / 12, numberOfMonths)) / ((Math.Pow(1 + rate
                    / 12, numberOfMonths) - 1) * (1 + rate / 12 * 0));

                //Intrest payment calculation
                interest = loan * (rate / 12);

                for (months = 1; months <= numberOfMonths; months = months + 1)
                {
                    //The payment that the client must pay for the month
                    fullPayment = principalPayment + interest;

                    //calculating the loan balance
                    loan = loan - principalPayment;

                    //Formating the information
                    monthListBox.Items.Add(string.Format(formatCode, months, interest.ToString("C2"), principalPayment.ToString("C2"), 
                        fullPayment.ToString("C2"), loan.ToString("C2")));

                    //the three variables adds the respective value for eachs time the loop executes
                    totalInterest += interest;
                    totalPrincipal += principalPayment;
                    totalPayment += fullPayment;

                    //calculaing the monthy interest and principal payment
                    interest = loan * (rate / 12);
                    principalPayment = fullPayment - interest;

                }
                //Display the final three totals on the lastline of the listbox
                     monthListBox.Items.Add(string.Format(" "));
                     monthListBox.Items.Add(string.Format(formatCode,"Total", totalInterest.ToString("C2"), totalPrincipal.ToString("C2"),
                         totalPayment.ToString("C2"), " "));

                //Placeholder variables to store the total principal and also the total interest for the use of the acceptButton
                acceptedPayment = totalPrincipal;
                acceptedInterest = totalInterest;
            }   
            catch (Exception err)
            {
                //Returns a error message if a problem is caught
                MessageBox.Show(err.Message);
            }
           
        }

        private void rebateCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            //Enables the rebateTextBox if a checked is applied
            rebateTextBox.Enabled = true;
        }

        private void loanAmountTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Disallows anything but digits, control characters and periods.
            if (!char.IsControl(e.KeyChar)
                && !char.IsDigit(e.KeyChar)
                && e.KeyChar != '.')
            {
                e.Handled = true;
                return;
            }
        }

        private void annualAprTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Disallows anything but digits, control characters and periods.
            if (!char.IsControl(e.KeyChar)
                           && !char.IsDigit(e.KeyChar)
                           && e.KeyChar != '.')
            {
                e.Handled = true;
                return;
            }
        }

        private void rebateTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Disallows anything but digits, control characters and periods.
            if (!char.IsControl(e.KeyChar)
               && !char.IsDigit(e.KeyChar)
               && e.KeyChar != '.')
            {
                e.Handled = true;
                return;
            }
        }

        private void loanAmountTextBox_TextChanged(object sender, EventArgs e)
        {
            //If the loanAmountTextBox values are changed clears the monthsListBox
            monthListBox.Items.Clear();
        }

        private void annualAprTextBox_TextChanged(object sender, EventArgs e)
        {
            //If the annualAprTextBox values are changed clears the monthsListBox

            monthListBox.Items.Clear();
        }

        private void rebateTextBox_TextChanged(object sender, EventArgs e)
        {
            //If the rebateTextBox values are changed clears the monthsListBox
            monthListBox.Items.Clear();
        }

        private void sixRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //If the sixRadtioButton is checked then the monthsListBox values are cleared
            monthListBox.Items.Clear();
        }

        private void twelveRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //If the twelveRadtioButton is checked then the monthsListBox values are cleared
            monthListBox.Items.Clear();
        }

        private void eightTeenRadiobutton_CheckedChanged(object sender, EventArgs e)
        {
            //If the eighTeenRadtioButton is checked then the monthsListBox values are cleared

            monthListBox.Items.Clear();
        }

        private void twentyFourRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //If the twentyFourRadtioButton is checked then the monthsListBox values are cleared
            monthListBox.Items.Clear();
        }

        private void loanAmountTextBox_Click(object sender, EventArgs e)
        {
            //selects all values in the loanAmountTextBox when the user clicks it
            loanAmountTextBox.SelectAll();
        }

        private void annualAprTextBox_Click(object sender, EventArgs e)
        {
            //selects all values in the annualAprTextBox when the user clicks it
            annualAprTextBox.SelectAll();
        }

        private void loanAmountTextBox_Enter(object sender, EventArgs e)
        {
            //selects all values in the loanAmountTextBox when the user tabs to it
            loanAmountTextBox.SelectAll();
        }

        private void annualAprTextBox_Enter(object sender, EventArgs e)
        {
            //selects all values in the annualAprTextBox when the user tabs to it
            annualAprTextBox.SelectAll();
        }

        private void rebateTextBox_Click(object sender, EventArgs e)
        {
            //selects all values in the rebateTextBox when the user clicks it
            rebateTextBox.SelectAll();
        }

        private void rebateTextBox_Enter(object sender, EventArgs e)
        {
            //selects all values in the rebateTextBox when the user tabs to it
            rebateTextBox.SelectAll();
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            //Clears the form back to its orginal state
            monthListBox.Items.Clear();
            loanAmountTextBox.Clear();
            annualAprTextBox.Clear();
            rebateTextBox.Clear();

            //Setting the radio button and checkbox to its defualt state
            this.sixRadioButton.Checked = true;
            this.rebateCheckBox.Checked = false;
            this.rebateTextBox.Enabled = false;

            //Setting focus on the loan amount textbox
            loanAmountTextBox.Focus();

            //Accumlates the accepted payments and interest
            finalTotalInterest += acceptedInterest;
            finalTotalPayment += acceptedPayment;
        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            //sends the accumulated accepted payments and interest to the two labels
            totalLoansLabel.Text = finalTotalPayment.ToString("C2");
            totalInterestLabel.Text = finalTotalInterest.ToString("C2");
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Exits the application with a confirmation
            DialogResult dialog = MessageBox.Show("Are you sure you want to exit the application?", this.Text,
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            //If yes is selected, closes the application
            if (dialog == DialogResult.Yes)
                this.Close();
     
        }
    }
}

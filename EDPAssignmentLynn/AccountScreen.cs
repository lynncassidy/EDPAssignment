using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EDPLibrary.Database; //gives access to a class called login handler
using EDPLibrary.Banking;  // gives access to all customer account information etc.

namespace EDPAssignmentLynn
{  
    public partial class AccountScreen : UserControl
    {  
        private Customer customer;

        // Get customer object into Accounts page/screen
        // Using constructor populate the fields

        public AccountScreen(Customer incomingCustomer)
        {
            InitializeComponent(); //Makes all components on screen, must be called first
            this.customer = incomingCustomer;
            UpdateAccountBalance();
            
        }

        private void OnDepositClicked(object sender, EventArgs e)
        {
            try
            {
                //txtBoxDeposit.Text = customer.GetAccounts()[0].Balance + txtBoxBalance.Text(Int32.Parse)
                decimal depositAmount = decimal.Parse(txtBoxDeposit.Text);
                customer.GetAccounts()[0].Deposit(depositAmount);
                UpdateAccountBalance();
            }
            catch (ArgumentException ae)
            {
                MessageBox.Show("Error occured: " + ae.ParamName);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter numbers only");
            }

        }

        private void UpdateAccountBalance()
        {
            txtBoxBalance.Text = customer.GetAccounts()[0].Balance.ToString();
        }
        private void OnWithdrawClicked(object sender, EventArgs e)
        {
            try
            {
                decimal withdrawAmount = decimal.Parse(txtBoxWithdraw.Text);
                customer.GetAccounts()[0].Withdraw(withdrawAmount);
                UpdateAccountBalance();
            }
            catch(ArgumentException ae)
            {
                MessageBox.Show("Error occured: " + ae.ParamName);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter numbers only");
            }
        }


        private void OnLogoutClicked(object sender, EventArgs e)
        {
            
            LoginHandler.Logout(customer);
            LoginScreen loginUser = new LoginScreen();
            MainWindow.GetInstance().PanelController.Controls.Add(loginUser);
            MainWindow.GetInstance().PanelController.Controls.Remove(this);
        }
    }
}

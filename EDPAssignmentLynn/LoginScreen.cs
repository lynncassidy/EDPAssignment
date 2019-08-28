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
    public partial class LoginScreen : UserControl
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void OnLoginClicked(object sender, EventArgs e)
        {   
            //in order to check what user has entered need store entries in variables.

            string enteredEmail = txtBoxEmail.Text;
            string enteredPassword = txtBoxPassword.Text;

            //LoginHandler lives in EDP library.Database & handles logging in and out for application
            // Takes customer object from login handler and stores reference to it in customer.
            // If the email & password check out it will give you a customer object.
            // Need to put in try catch here to handle incorrect entries
            Customer customer = LoginHandler.Login(enteredEmail, enteredPassword);



        }

        private void OnExitClicked(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

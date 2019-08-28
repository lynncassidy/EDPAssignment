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
            try
            {
            Customer customer = LoginHandler.Login(enteredEmail, enteredPassword);
            }
            catch(Exception ex)
            {
                Console.Write("Your account details cannot be found, try again");
            }

            


        }
        //Exits application
        private void OnExitClicked(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Brings up customer
        private void onNextClicked(object sender, EventArgs e)
        {
            AccountScreen accounts = new AccountScreen();
            MainWindow.GetInstance().PanelController.Controls.Remove(this);
            MainWindow.GetInstance().PanelController.Controls.Add(AccountScreen);



            /*    Character character = new Character(inputTxtName.Text,
                  CharacterUtils.GetClass(characterSelectedPortrait.Tag.ToString()),
                  characterSelectedPortrait.Image);
    ​
                //Create our CharacterConfig UserControl
                CharacterConfig gints = new CharacterConfig(character);
    ​
                MainWindow.GetInstance().ContentPanel.Controls.Remove(this);
            MainWindow.GetInstance().ContentPanel.Controls.Add(gints);*/
        }
    }
}

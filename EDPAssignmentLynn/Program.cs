using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using EDPLibrary.Database;
using EDPLibrary.Banking;

namespace EDPAssignmentLynn
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           // Application.Run(new MainWindow());

            //Creating the main window form (container of containers)
            MainWindow mainForm = MainWindow.GetInstance();

            //Creating the userConntrol
            LoginScreen loginUser = new LoginScreen();

            //To be put in next button
            //Singleton - each screen has access to mainform
            //AccountScreen accounts = new AccountScreen();
            //MainWindow.GetInstance().PanelController.Controls.Remove(this);
            //MainWindow.GetInstance().PanelController.Controls.Add(AccountScreen)

            //Adding user control to the form
            mainForm.PanelController.Controls.Add(loginUser);
            Application.Run(mainForm);
        }
    }


}

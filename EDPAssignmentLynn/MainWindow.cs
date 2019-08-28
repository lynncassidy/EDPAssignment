﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EDPLibrary.Database;
using EDPLibrary.Banking;

namespace EDPAssignmentLynn
{
    public partial class MainWindow : Form
    {
        private static MainWindow mainWindow = null;
        public MainWindow()
        {
            InitializeComponent();
        }

        public static MainWindow GetInstance()
        {

            if (mainWindow != null)
            {
                return mainWindow;
            }
            mainWindow = new MainWindow();
            return mainWindow;
        }
        

        
    }
}

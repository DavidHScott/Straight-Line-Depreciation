//**********************************************************************
//  
//  Program    : Depreciation.cs
//  Author     : David Scott
//  Student ID : 3352323
//  Course ID  : CMIS 214
//  Assessment : Assignment 2, Practical Exercise (Unit 4)
//  Date       : January 5, 2020
//
//  Purpose : This application calculates the value of an asset over a
//            period of time using straight-line depreciation. The program
//            takes input from three textboxes (the present value, the
//            salvage value and the depreciation period in years), and
//            calculates the rate of depreciation, and then lists the
//            value of the item for every year until it reaches the salvage
//            value
//
//**********************************************************************

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Depreciation
{
    public partial class Depreciation : Form
    {
        public Depreciation()
        {
            InitializeComponent();
        }

        // When the user clicks the "About" menu button, the program opens the "About" form
        private void mnuOpenAboutForm_Click(object sender, EventArgs e)
        {
            // Create a new form object from the About form class, and open it as a dialog box
            Form aboutForm = new frmAbout();
            aboutForm.ShowDialog();
        }

        // When the user clicks the "Calculate" button, the program takes the inputs to calculate
        // the rate of depreciation, and then display the value each year until the salvage value
        // is reached
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Create the variables used in the calculation
            double dblPresentValue;
            double dblSalvageValue;
            int intDepreciationPeriod;

            // Make sure the user entered valid numbers in the input fields, and parse those
            // inputs into the variables usable in calculations
            if(!double.TryParse(inputPresentValue.Text, out dblPresentValue))
            {
                // If the inputted value is not a number, show a message box, and select the
                // problem textbox
                MessageBox.Show("Please enter a valid number in the Present value field.", "Entry Error");
                inputPresentValue.Select();

                return;
            }
            if (!double.TryParse(inputSalvageValue.Text, out dblSalvageValue))
            {
                // If the inputted value is not a number, show a message box, and select the
                // problem textbox
                MessageBox.Show("Please enter a valid number in the Salvage value field.", "Entry Error");
                inputSalvageValue.Select();

                return;
            }
            if (!int.TryParse(inputDepreciationPeriod.Text, out intDepreciationPeriod))
            {
                // If the inputted value is not a number, show a message box, and select the
                // problem textbox
                MessageBox.Show("Please enter a valid number in the Depreciation period field.", "Entry Error");
                inputDepreciationPeriod.Select();

                return;
            }

            // Check if the present value is greater than the salvage value
            if(dblPresentValue <= dblSalvageValue)
            {
                // If the salvage value isn't lesser than the present value, show a message
                // box, and select the salvage value textbox
                MessageBox.Show("The salvage value must be less than the present value", "Entry Error");
                inputSalvageValue.Select();

                return;
            }

            // Calculate teh depreciation rate ((current value - salvage value) / estimated
            // lifespan of the asset)
            double DepreciationRate = (dblPresentValue - dblSalvageValue) / intDepreciationPeriod;

            // Add the present value of the asset to the listbox
            lstDepreciationPerYear.Items.Add(dblPresentValue + " (Present value)");

            // For each period of time, subtract the depreciation rate from the value, and add
            // the new value to the listbox
            for (int i = 0; i < intDepreciationPeriod; i++)
            {
                dblPresentValue -= DepreciationRate;

                lstDepreciationPerYear.Items.Add(dblPresentValue);
            }

        }

        // When the user clicks the "reset" button all the inputs and outputs are cleared
        private void btnReset_Click(object sender, EventArgs e)
        {
            // Clear the "text" properties of the inputs
            inputPresentValue.Text = "";
            inputSalvageValue.Text = "";
            inputDepreciationPeriod.Text = "";

            // Clear the items in the listbox
            lstDepreciationPerYear.Items.Clear();
        }

        // When the user clicks the "Exit" button, close the application
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

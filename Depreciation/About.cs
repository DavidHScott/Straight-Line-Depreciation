//**********************************************************************
//  
//  Program    : About.cs
//  Author     : David Scott
//  Student ID : 3352323
//  Course ID  : CMIS 214
//  Assessment : Assignment 2, Practical Exercise (Unit 4)
//  Date       : January 5, 2020
//
//  Purpose : This is a simple "about" form. There is a button to
//            close the form.
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
    public partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();
        }

        // Close the form (not the whole application though) when the
        // user clicks the "Close" button
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

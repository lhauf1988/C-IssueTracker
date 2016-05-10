//Pos409
//1/12/2016
//Lucas Hauf, Joey Almeida
//this project was made so that a user could enter an issue into the application for review, and to organize and fix the issues


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IssueTracker
{
    public partial class frmLoginScreen : Form
    {
        public string UserName; 
        public frmLoginScreen()
        {
            InitializeComponent();
            this.CenterToScreen();
        }
        
       
        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            UserName = txtUserName.Text;
            frmIssueTracker MyIssueTracker = new frmIssueTracker();
            this.Hide();           
            MyIssueTracker.Show();
            MyIssueTracker.lblUser.Text = txtUserName.Text;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
    }
}

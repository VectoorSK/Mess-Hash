using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;
using System.Security.Cryptography;

namespace MessHash
{
    public partial class RegistrationPage : Form
    {
        public RegistrationPage()
        {
            InitializeComponent();
            IntPtr hwnd = this.Handle;
            this.Top = Screen.PrimaryScreen.WorkingArea.Height / 2 - this.Height / 2;
            this.Left = Screen.PrimaryScreen.WorkingArea.Width / 2 - this.Width / 2;
        }


        private void RegistrationPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void GoToLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage LoginForm = new LoginPage();
            LoginForm.ShowDialog();
        }
    }
}

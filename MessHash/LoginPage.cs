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
    public partial class LoginPage : Form
    {
        string userFromRegister = "";

        public LoginPage()
        {
            InitializeComponent();
            IntPtr hwnd = this.Handle;
            this.Top = Screen.PrimaryScreen.WorkingArea.Height/2 - this.Height/2;
            this.Left = Screen.PrimaryScreen.WorkingArea.Width/2 - this.Width/2;
        }

        public void getValue(string userFromRegister)
        {
            this.userFromRegister = userFromRegister;
        }

        private void LogIn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Profile profileForm = new Profile();
            profileForm.ShowDialog();
        }

        private void RegisterLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void GoToRegistration_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrationPage registerForm = new RegistrationPage();
            registerForm.ShowDialog();
        }
    }
}

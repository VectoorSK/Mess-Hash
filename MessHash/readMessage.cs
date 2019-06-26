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

namespace MessHash
{
    public partial class readMessage : Form
    {
        public string username;
        public int usernameID;
        public readMessage()
        {
            InitializeComponent();
            IntPtr hwnd = this.Handle;
            this.Top = Screen.PrimaryScreen.WorkingArea.Height / 2 - this.Height / 2;
            this.Left = Screen.PrimaryScreen.WorkingArea.Width / 2 - this.Width / 2;
        }

        private void GoToMessage_Click(object sender, EventArgs e)
        {
            this.Hide();
            newMessage newMessForm = new newMessage();
            newMessForm.ShowDialog();
        }

        private void GoToProfile_Click(object sender, EventArgs e)
        {
            this.Hide();
            Profile profileForm = new Profile();
            profileForm.ShowDialog();
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage loginForm = new LoginPage();
            loginForm.ShowDialog();
        }

        private void ReadMessage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

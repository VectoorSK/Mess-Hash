using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessHash
{
    public partial class Profile : Form
    {
        string username;
        public Profile()
        {
            InitializeComponent();
            IntPtr hwnd = this.Handle;
            this.Top = Screen.PrimaryScreen.WorkingArea.Height / 2 - this.Height / 2;
            this.Left = Screen.PrimaryScreen.WorkingArea.Width / 2 - this.Width / 2;
        }

        public void getValue(string val)
        {
            username = val.ToString();
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage form = new LoginPage();
            form.ShowDialog();
        }

        private void Profile_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void SendMessage_Click(object sender, EventArgs e)
        {
            this.Hide();
            newMessage newMessForm = new newMessage();
            newMessForm.ShowDialog();
        }

        private void OpenReadMessage_Click(object sender, EventArgs e)
        {
            this.Hide();
            readMessage readForm = new readMessage();
            readForm.ShowDialog();
        }
    }
}

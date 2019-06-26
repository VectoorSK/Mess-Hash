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
    public partial class newMessage : Form
    {
        public string senderNickname = null;
        public string receiverNickname = null;
        public int senderID;
        public int receiverID;
        public newMessage()
        {
            InitializeComponent();
            IntPtr hwnd = this.Handle;
            this.Top = Screen.PrimaryScreen.WorkingArea.Height / 2 - this.Height / 2;
            this.Left = Screen.PrimaryScreen.WorkingArea.Width / 2 - this.Width / 2;
        }

        public void getValues(string senderUser, string receiverUser)
        {
            senderNickname = senderUser.ToString();
            receiverNickname = receiverUser.ToString();
        }

        private void OpenReadMessage_Click(object sender, EventArgs e)
        {
            this.Hide();
            readMessage readForm = new readMessage();
            readForm.ShowDialog();
        }

        private void GoToProfile_Click(object sender, EventArgs e)
        {
            this.Hide();
            Profile profilForm = new Profile();
            profilForm.ShowDialog();
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage loginForm = new LoginPage();
            loginForm.ShowDialog();
        }

        private void NewMessage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

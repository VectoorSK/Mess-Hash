namespace MessHash
{
    partial class LoginPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            this.labelLogUsername = new System.Windows.Forms.Label();
            this.labelLogPassword = new System.Windows.Forms.Label();
            this.logUsername = new System.Windows.Forms.TextBox();
            this.logPassword = new System.Windows.Forms.TextBox();
            this.logIn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.GoToRegistration = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelLogUsername
            // 
            this.labelLogUsername.AutoSize = true;
            this.labelLogUsername.Location = new System.Drawing.Point(94, 136);
            this.labelLogUsername.Name = "labelLogUsername";
            this.labelLogUsername.Size = new System.Drawing.Size(77, 17);
            this.labelLogUsername.TabIndex = 15;
            this.labelLogUsername.Text = "Username:";
            // 
            // labelLogPassword
            // 
            this.labelLogPassword.AutoSize = true;
            this.labelLogPassword.Location = new System.Drawing.Point(94, 170);
            this.labelLogPassword.Name = "labelLogPassword";
            this.labelLogPassword.Size = new System.Drawing.Size(73, 17);
            this.labelLogPassword.TabIndex = 16;
            this.labelLogPassword.Text = "Password:";
            // 
            // logUsername
            // 
            this.logUsername.Location = new System.Drawing.Point(177, 136);
            this.logUsername.Name = "logUsername";
            this.logUsername.Size = new System.Drawing.Size(159, 22);
            this.logUsername.TabIndex = 17;
            // 
            // logPassword
            // 
            this.logPassword.Location = new System.Drawing.Point(177, 167);
            this.logPassword.Name = "logPassword";
            this.logPassword.PasswordChar = '*';
            this.logPassword.Size = new System.Drawing.Size(159, 22);
            this.logPassword.TabIndex = 18;
            // 
            // logIn
            // 
            this.logIn.BackColor = System.Drawing.SystemColors.Control;
            this.logIn.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.logIn.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.logIn.FlatAppearance.BorderSize = 2;
            this.logIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logIn.Location = new System.Drawing.Point(177, 198);
            this.logIn.Name = "logIn";
            this.logIn.Size = new System.Drawing.Size(159, 33);
            this.logIn.TabIndex = 19;
            this.logIn.Text = "LOGIN";
            this.logIn.UseVisualStyleBackColor = false;
            this.logIn.Click += new System.EventHandler(this.LogIn_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(13, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(478, 57);
            this.label3.TabIndex = 32;
            this.label3.Text = "Mess\'Hash";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GoToRegistration
            // 
            this.GoToRegistration.BackColor = System.Drawing.SystemColors.Control;
            this.GoToRegistration.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.GoToRegistration.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.GoToRegistration.FlatAppearance.BorderSize = 2;
            this.GoToRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoToRegistration.Location = new System.Drawing.Point(177, 240);
            this.GoToRegistration.Name = "GoToRegistration";
            this.GoToRegistration.Size = new System.Drawing.Size(159, 33);
            this.GoToRegistration.TabIndex = 34;
            this.GoToRegistration.Text = "REGISTRATION";
            this.GoToRegistration.UseVisualStyleBackColor = false;
            this.GoToRegistration.Click += new System.EventHandler(this.GoToRegistration_Click);
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 287);
            this.Controls.Add(this.GoToRegistration);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.logIn);
            this.Controls.Add(this.logPassword);
            this.Controls.Add(this.logUsername);
            this.Controls.Add(this.labelLogPassword);
            this.Controls.Add(this.labelLogUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LoginPage";
            this.Text = "Mess\'Hash";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RegisterLogin_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelLogUsername;
        private System.Windows.Forms.Label labelLogPassword;
        private System.Windows.Forms.TextBox logUsername;
        private System.Windows.Forms.TextBox logPassword;
        private System.Windows.Forms.Button logIn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button GoToRegistration;
    }
}


namespace MessHash
{
    partial class newMessage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(newMessage));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.senderUsername = new System.Windows.Forms.TextBox();
            this.receiverUsername = new System.Windows.Forms.TextBox();
            this.messageContent = new System.Windows.Forms.RichTextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.goToProfile = new System.Windows.Forms.Button();
            this.logOutButton = new System.Windows.Forms.Button();
            this.encMethod1 = new System.Windows.Forms.RadioButton();
            this.encMethod2 = new System.Windows.Forms.RadioButton();
            this.encMethod3 = new System.Windows.Forms.RadioButton();
            this.encMethod4 = new System.Windows.Forms.RadioButton();
            this.encryptionKey = new System.Windows.Forms.TextBox();
            this.labelEncKey = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.openReadMessage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial Black", 15.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(776, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "NEW MESSAGE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "From:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(607, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "To:";
            // 
            // senderUsername
            // 
            this.senderUsername.Location = new System.Drawing.Point(67, 63);
            this.senderUsername.Name = "senderUsername";
            this.senderUsername.ReadOnly = true;
            this.senderUsername.Size = new System.Drawing.Size(143, 22);
            this.senderUsername.TabIndex = 3;
            // 
            // receiverUsername
            // 
            this.receiverUsername.Location = new System.Drawing.Point(645, 63);
            this.receiverUsername.Name = "receiverUsername";
            this.receiverUsername.Size = new System.Drawing.Size(143, 22);
            this.receiverUsername.TabIndex = 4;
            // 
            // messageContent
            // 
            this.messageContent.Location = new System.Drawing.Point(12, 91);
            this.messageContent.Name = "messageContent";
            this.messageContent.Size = new System.Drawing.Size(776, 122);
            this.messageContent.TabIndex = 5;
            this.messageContent.Text = "";
            // 
            // sendButton
            // 
            this.sendButton.BackColor = System.Drawing.SystemColors.Control;
            this.sendButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.sendButton.FlatAppearance.BorderSize = 2;
            this.sendButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendButton.Location = new System.Drawing.Point(641, 281);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(147, 57);
            this.sendButton.TabIndex = 6;
            this.sendButton.Text = "SEND MESSAGE";
            this.sendButton.UseVisualStyleBackColor = false;
            // 
            // goToProfile
            // 
            this.goToProfile.BackColor = System.Drawing.SystemColors.Control;
            this.goToProfile.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.goToProfile.FlatAppearance.BorderSize = 2;
            this.goToProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goToProfile.Location = new System.Drawing.Point(12, 5);
            this.goToProfile.Name = "goToProfile";
            this.goToProfile.Size = new System.Drawing.Size(85, 34);
            this.goToProfile.TabIndex = 7;
            this.goToProfile.Text = "PROFILE";
            this.goToProfile.UseVisualStyleBackColor = false;
            this.goToProfile.Click += new System.EventHandler(this.GoToProfile_Click);
            // 
            // logOutButton
            // 
            this.logOutButton.BackColor = System.Drawing.SystemColors.Control;
            this.logOutButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.logOutButton.FlatAppearance.BorderSize = 2;
            this.logOutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutButton.Location = new System.Drawing.Point(713, 5);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(75, 34);
            this.logOutButton.TabIndex = 29;
            this.logOutButton.Text = "Log out";
            this.logOutButton.UseVisualStyleBackColor = false;
            this.logOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // encMethod1
            // 
            this.encMethod1.AutoSize = true;
            this.encMethod1.Location = new System.Drawing.Point(409, 254);
            this.encMethod1.Name = "encMethod1";
            this.encMethod1.Size = new System.Drawing.Size(66, 21);
            this.encMethod1.TabIndex = 30;
            this.encMethod1.TabStop = true;
            this.encMethod1.Text = "Cesar";
            this.encMethod1.UseVisualStyleBackColor = true;
            // 
            // encMethod2
            // 
            this.encMethod2.AutoSize = true;
            this.encMethod2.Location = new System.Drawing.Point(409, 290);
            this.encMethod2.Name = "encMethod2";
            this.encMethod2.Size = new System.Drawing.Size(86, 21);
            this.encMethod2.TabIndex = 31;
            this.encMethod2.TabStop = true;
            this.encMethod2.Text = "Vigenere";
            this.encMethod2.UseVisualStyleBackColor = true;
            // 
            // encMethod3
            // 
            this.encMethod3.AutoSize = true;
            this.encMethod3.Location = new System.Drawing.Point(506, 254);
            this.encMethod3.Name = "encMethod3";
            this.encMethod3.Size = new System.Drawing.Size(97, 21);
            this.encMethod3.TabIndex = 32;
            this.encMethod3.TabStop = true;
            this.encMethod3.Text = "Triple DES";
            this.encMethod3.UseVisualStyleBackColor = true;
            // 
            // encMethod4
            // 
            this.encMethod4.AutoSize = true;
            this.encMethod4.Location = new System.Drawing.Point(506, 290);
            this.encMethod4.Name = "encMethod4";
            this.encMethod4.Size = new System.Drawing.Size(57, 21);
            this.encMethod4.TabIndex = 33;
            this.encMethod4.TabStop = true;
            this.encMethod4.Text = "RSA";
            this.encMethod4.UseVisualStyleBackColor = true;
            // 
            // encryptionKey
            // 
            this.encryptionKey.Location = new System.Drawing.Point(641, 253);
            this.encryptionKey.Name = "encryptionKey";
            this.encryptionKey.Size = new System.Drawing.Size(147, 22);
            this.encryptionKey.TabIndex = 34;
            // 
            // labelEncKey
            // 
            this.labelEncKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEncKey.Location = new System.Drawing.Point(642, 229);
            this.labelEncKey.Name = "labelEncKey";
            this.labelEncKey.Size = new System.Drawing.Size(119, 21);
            this.labelEncKey.TabIndex = 35;
            this.labelEncKey.Text = "Encryption Key:";
            this.labelEncKey.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(406, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 17);
            this.label5.TabIndex = 36;
            this.label5.Text = "Select encryption method:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // openReadMessage
            // 
            this.openReadMessage.BackColor = System.Drawing.SystemColors.Control;
            this.openReadMessage.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.openReadMessage.FlatAppearance.BorderSize = 2;
            this.openReadMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openReadMessage.Location = new System.Drawing.Point(12, 281);
            this.openReadMessage.Name = "openReadMessage";
            this.openReadMessage.Size = new System.Drawing.Size(147, 57);
            this.openReadMessage.TabIndex = 37;
            this.openReadMessage.Text = "MY MESSAGES";
            this.openReadMessage.UseVisualStyleBackColor = false;
            this.openReadMessage.Click += new System.EventHandler(this.OpenReadMessage_Click);
            // 
            // newMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 350);
            this.Controls.Add(this.openReadMessage);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelEncKey);
            this.Controls.Add(this.encryptionKey);
            this.Controls.Add(this.encMethod4);
            this.Controls.Add(this.encMethod3);
            this.Controls.Add(this.encMethod2);
            this.Controls.Add(this.encMethod1);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.goToProfile);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.messageContent);
            this.Controls.Add(this.receiverUsername);
            this.Controls.Add(this.senderUsername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "newMessage";
            this.Text = "Mess\'Hash";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NewMessage_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox senderUsername;
        private System.Windows.Forms.TextBox receiverUsername;
        private System.Windows.Forms.RichTextBox messageContent;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.Button goToProfile;
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.RadioButton encMethod1;
        private System.Windows.Forms.RadioButton encMethod2;
        private System.Windows.Forms.RadioButton encMethod3;
        private System.Windows.Forms.RadioButton encMethod4;
        private System.Windows.Forms.TextBox encryptionKey;
        private System.Windows.Forms.Label labelEncKey;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button openReadMessage;
    }
}
namespace MessHash
{
    partial class readMessage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(readMessage));
            this.dataGridMessage = new System.Windows.Forms.DataGridView();
            this.goToProfile = new System.Windows.Forms.Button();
            this.logOutButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridFriend = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.answerText = new System.Windows.Forms.RichTextBox();
            this.answerButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.encMethod1 = new System.Windows.Forms.RadioButton();
            this.encMethod2 = new System.Windows.Forms.RadioButton();
            this.encMethod3 = new System.Windows.Forms.RadioButton();
            this.encMethod4 = new System.Windows.Forms.RadioButton();
            this.encryptionKey = new System.Windows.Forms.TextBox();
            this.labelEncKey = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.GoToMessage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMessage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFriend)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridMessage
            // 
            this.dataGridMessage.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridMessage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMessage.Location = new System.Drawing.Point(165, 120);
            this.dataGridMessage.Name = "dataGridMessage";
            this.dataGridMessage.RowHeadersWidth = 51;
            this.dataGridMessage.RowTemplate.Height = 24;
            this.dataGridMessage.Size = new System.Drawing.Size(295, 273);
            this.dataGridMessage.TabIndex = 0;
            // 
            // goToProfile
            // 
            this.goToProfile.BackColor = System.Drawing.SystemColors.Control;
            this.goToProfile.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.goToProfile.FlatAppearance.BorderSize = 2;
            this.goToProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goToProfile.Location = new System.Drawing.Point(15, 5);
            this.goToProfile.Name = "goToProfile";
            this.goToProfile.Size = new System.Drawing.Size(85, 34);
            this.goToProfile.TabIndex = 8;
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
            this.logOutButton.Location = new System.Drawing.Point(757, 5);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(75, 34);
            this.logOutButton.TabIndex = 29;
            this.logOutButton.Text = "Log out";
            this.logOutButton.UseVisualStyleBackColor = false;
            this.logOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "Select discussion:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridFriend
            // 
            this.dataGridFriend.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridFriend.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFriend.Location = new System.Drawing.Point(12, 120);
            this.dataGridFriend.Name = "dataGridFriend";
            this.dataGridFriend.RowHeadersWidth = 51;
            this.dataGridFriend.RowTemplate.Height = 24;
            this.dataGridFriend.Size = new System.Drawing.Size(147, 273);
            this.dataGridFriend.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(165, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(295, 20);
            this.label2.TabIndex = 33;
            this.label2.Text = "Messages:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // answerText
            // 
            this.answerText.Location = new System.Drawing.Point(466, 120);
            this.answerText.Name = "answerText";
            this.answerText.Size = new System.Drawing.Size(366, 119);
            this.answerText.TabIndex = 34;
            this.answerText.Text = "";
            // 
            // answerButton
            // 
            this.answerButton.BackColor = System.Drawing.SystemColors.Control;
            this.answerButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.answerButton.FlatAppearance.BorderSize = 2;
            this.answerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerButton.Location = new System.Drawing.Point(682, 336);
            this.answerButton.Name = "answerButton";
            this.answerButton.Size = new System.Drawing.Size(150, 57);
            this.answerButton.TabIndex = 35;
            this.answerButton.Text = "ANSWER";
            this.answerButton.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(466, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(366, 20);
            this.label3.TabIndex = 36;
            this.label3.Text = "Answer:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(466, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 17);
            this.label5.TabIndex = 44;
            this.label5.Text = "Select encryption method:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // encMethod1
            // 
            this.encMethod1.AutoSize = true;
            this.encMethod1.Location = new System.Drawing.Point(524, 276);
            this.encMethod1.Name = "encMethod1";
            this.encMethod1.Size = new System.Drawing.Size(66, 21);
            this.encMethod1.TabIndex = 38;
            this.encMethod1.TabStop = true;
            this.encMethod1.Text = "Cesar";
            this.encMethod1.UseVisualStyleBackColor = true;
            // 
            // encMethod2
            // 
            this.encMethod2.AutoSize = true;
            this.encMethod2.Location = new System.Drawing.Point(524, 308);
            this.encMethod2.Name = "encMethod2";
            this.encMethod2.Size = new System.Drawing.Size(86, 21);
            this.encMethod2.TabIndex = 39;
            this.encMethod2.TabStop = true;
            this.encMethod2.Text = "Vigenere";
            this.encMethod2.UseVisualStyleBackColor = true;
            // 
            // encMethod3
            // 
            this.encMethod3.AutoSize = true;
            this.encMethod3.Location = new System.Drawing.Point(524, 341);
            this.encMethod3.Name = "encMethod3";
            this.encMethod3.Size = new System.Drawing.Size(97, 21);
            this.encMethod3.TabIndex = 40;
            this.encMethod3.TabStop = true;
            this.encMethod3.Text = "Triple DES";
            this.encMethod3.UseVisualStyleBackColor = true;
            // 
            // encMethod4
            // 
            this.encMethod4.AutoSize = true;
            this.encMethod4.Location = new System.Drawing.Point(524, 372);
            this.encMethod4.Name = "encMethod4";
            this.encMethod4.Size = new System.Drawing.Size(57, 21);
            this.encMethod4.TabIndex = 41;
            this.encMethod4.TabStop = true;
            this.encMethod4.Text = "RSA";
            this.encMethod4.UseVisualStyleBackColor = true;
            // 
            // encryptionKey
            // 
            this.encryptionKey.Location = new System.Drawing.Point(682, 275);
            this.encryptionKey.Name = "encryptionKey";
            this.encryptionKey.Size = new System.Drawing.Size(150, 22);
            this.encryptionKey.TabIndex = 42;
            // 
            // labelEncKey
            // 
            this.labelEncKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEncKey.Location = new System.Drawing.Point(682, 252);
            this.labelEncKey.Name = "labelEncKey";
            this.labelEncKey.Size = new System.Drawing.Size(150, 20);
            this.labelEncKey.TabIndex = 43;
            this.labelEncKey.Text = "Encryption Key:";
            this.labelEncKey.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Arial Black", 15.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(15, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(817, 29);
            this.label4.TabIndex = 45;
            this.label4.Text = "DISCUSSION";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.UseCompatibleTextRendering = true;
            // 
            // GoToMessage
            // 
            this.GoToMessage.BackColor = System.Drawing.SystemColors.Control;
            this.GoToMessage.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.GoToMessage.FlatAppearance.BorderSize = 2;
            this.GoToMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoToMessage.Location = new System.Drawing.Point(15, 45);
            this.GoToMessage.Name = "GoToMessage";
            this.GoToMessage.Size = new System.Drawing.Size(85, 34);
            this.GoToMessage.TabIndex = 46;
            this.GoToMessage.Text = "NEW +";
            this.GoToMessage.UseVisualStyleBackColor = false;
            this.GoToMessage.Click += new System.EventHandler(this.GoToMessage_Click);
            // 
            // readMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 405);
            this.Controls.Add(this.GoToMessage);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelEncKey);
            this.Controls.Add(this.encryptionKey);
            this.Controls.Add(this.encMethod4);
            this.Controls.Add(this.encMethod3);
            this.Controls.Add(this.encMethod2);
            this.Controls.Add(this.encMethod1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.answerButton);
            this.Controls.Add(this.answerText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridFriend);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.goToProfile);
            this.Controls.Add(this.dataGridMessage);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "readMessage";
            this.Text = "Mess\'Hash";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ReadMessage_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMessage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFriend)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridMessage;
        private System.Windows.Forms.Button goToProfile;
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridFriend;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox answerText;
        private System.Windows.Forms.Button answerButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton encMethod1;
        private System.Windows.Forms.RadioButton encMethod2;
        private System.Windows.Forms.RadioButton encMethod3;
        private System.Windows.Forms.RadioButton encMethod4;
        private System.Windows.Forms.TextBox encryptionKey;
        private System.Windows.Forms.Label labelEncKey;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button GoToMessage;
    }
}
namespace MessHash
{
    partial class Profile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profile));
            this.dataGridFriend = new System.Windows.Forms.DataGridView();
            this.labelInfo = new System.Windows.Forms.Label();
            this.displayInfo = new System.Windows.Forms.RichTextBox();
            this.labelFriendList = new System.Windows.Forms.Label();
            this.sendMessage = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.titleAddFriend = new System.Windows.Forms.Label();
            this.LabelAddFriendUsername = new System.Windows.Forms.Label();
            this.addFriendUsername = new System.Windows.Forms.TextBox();
            this.addFriend = new System.Windows.Forms.Button();
            this.delFriend = new System.Windows.Forms.Button();
            this.openReadMessage = new System.Windows.Forms.Button();
            this.logOutButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.alertNoFriend = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFriend)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridFriend
            // 
            this.dataGridFriend.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridFriend.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFriend.Location = new System.Drawing.Point(12, 239);
            this.dataGridFriend.Name = "dataGridFriend";
            this.dataGridFriend.RowHeadersWidth = 51;
            this.dataGridFriend.RowTemplate.Height = 24;
            this.dataGridFriend.Size = new System.Drawing.Size(776, 211);
            this.dataGridFriend.TabIndex = 0;
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfo.Location = new System.Drawing.Point(12, 71);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(115, 29);
            this.labelInfo.TabIndex = 1;
            this.labelInfo.Text = "User info:";
            // 
            // displayInfo
            // 
            this.displayInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.displayInfo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.displayInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayInfo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.displayInfo.Location = new System.Drawing.Point(143, 74);
            this.displayInfo.Name = "displayInfo";
            this.displayInfo.ReadOnly = true;
            this.displayInfo.Size = new System.Drawing.Size(267, 109);
            this.displayInfo.TabIndex = 2;
            this.displayInfo.Text = "";
            // 
            // labelFriendList
            // 
            this.labelFriendList.AutoSize = true;
            this.labelFriendList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFriendList.Location = new System.Drawing.Point(12, 207);
            this.labelFriendList.Name = "labelFriendList";
            this.labelFriendList.Size = new System.Drawing.Size(125, 29);
            this.labelFriendList.TabIndex = 3;
            this.labelFriendList.Text = "Friend list:";
            this.labelFriendList.UseMnemonic = false;
            // 
            // sendMessage
            // 
            this.sendMessage.BackColor = System.Drawing.SystemColors.Control;
            this.sendMessage.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.sendMessage.FlatAppearance.BorderSize = 2;
            this.sendMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendMessage.Location = new System.Drawing.Point(622, 455);
            this.sendMessage.Name = "sendMessage";
            this.sendMessage.Size = new System.Drawing.Size(166, 45);
            this.sendMessage.TabIndex = 20;
            this.sendMessage.Text = "NEW MESSAGE";
            this.sendMessage.UseVisualStyleBackColor = false;
            this.sendMessage.Click += new System.EventHandler(this.SendMessage_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(416, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(3, 124);
            this.label1.TabIndex = 21;
            // 
            // titleAddFriend
            // 
            this.titleAddFriend.AutoSize = true;
            this.titleAddFriend.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleAddFriend.Location = new System.Drawing.Point(425, 71);
            this.titleAddFriend.Name = "titleAddFriend";
            this.titleAddFriend.Size = new System.Drawing.Size(148, 29);
            this.titleAddFriend.TabIndex = 22;
            this.titleAddFriend.Text = "Add a friend:";
            // 
            // LabelAddFriendUsername
            // 
            this.LabelAddFriendUsername.AutoSize = true;
            this.LabelAddFriendUsername.Location = new System.Drawing.Point(425, 112);
            this.LabelAddFriendUsername.Name = "LabelAddFriendUsername";
            this.LabelAddFriendUsername.Size = new System.Drawing.Size(77, 17);
            this.LabelAddFriendUsername.TabIndex = 23;
            this.LabelAddFriendUsername.Text = "Username:";
            // 
            // addFriendUsername
            // 
            this.addFriendUsername.Location = new System.Drawing.Point(508, 109);
            this.addFriendUsername.Name = "addFriendUsername";
            this.addFriendUsername.Size = new System.Drawing.Size(166, 22);
            this.addFriendUsername.TabIndex = 24;
            // 
            // addFriend
            // 
            this.addFriend.BackColor = System.Drawing.SystemColors.Control;
            this.addFriend.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.addFriend.FlatAppearance.BorderSize = 2;
            this.addFriend.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addFriend.Location = new System.Drawing.Point(508, 137);
            this.addFriend.Name = "addFriend";
            this.addFriend.Size = new System.Drawing.Size(166, 45);
            this.addFriend.TabIndex = 25;
            this.addFriend.Text = "ADD TO FRIENDLIST";
            this.addFriend.UseVisualStyleBackColor = false;
            // 
            // delFriend
            // 
            this.delFriend.BackColor = System.Drawing.SystemColors.Control;
            this.delFriend.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.delFriend.FlatAppearance.BorderSize = 2;
            this.delFriend.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delFriend.Location = new System.Drawing.Point(12, 456);
            this.delFriend.Name = "delFriend";
            this.delFriend.Size = new System.Drawing.Size(166, 45);
            this.delFriend.TabIndex = 26;
            this.delFriend.Text = "DELETE FRIEND";
            this.delFriend.UseVisualStyleBackColor = false;
            // 
            // openReadMessage
            // 
            this.openReadMessage.BackColor = System.Drawing.SystemColors.Control;
            this.openReadMessage.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.openReadMessage.FlatAppearance.BorderSize = 2;
            this.openReadMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openReadMessage.Location = new System.Drawing.Point(317, 455);
            this.openReadMessage.Name = "openReadMessage";
            this.openReadMessage.Size = new System.Drawing.Size(185, 45);
            this.openReadMessage.TabIndex = 27;
            this.openReadMessage.Text = "SHOW MY MESSAGES";
            this.openReadMessage.UseVisualStyleBackColor = false;
            this.openReadMessage.Click += new System.EventHandler(this.OpenReadMessage_Click);
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
            this.logOutButton.TabIndex = 28;
            this.logOutButton.Text = "Log out";
            this.logOutButton.UseVisualStyleBackColor = false;
            this.logOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Arial Black", 15.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(12, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(776, 29);
            this.label4.TabIndex = 46;
            this.label4.Text = "PROFILE";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.UseCompatibleTextRendering = true;
            // 
            // alertNoFriend
            // 
            this.alertNoFriend.AutoSize = true;
            this.alertNoFriend.BackColor = System.Drawing.SystemColors.Control;
            this.alertNoFriend.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alertNoFriend.ForeColor = System.Drawing.Color.Black;
            this.alertNoFriend.Location = new System.Drawing.Point(13, 248);
            this.alertNoFriend.Name = "alertNoFriend";
            this.alertNoFriend.Size = new System.Drawing.Size(236, 20);
            this.alertNoFriend.TabIndex = 47;
            this.alertNoFriend.Text = "You don\'t have any friends yet.";
            this.alertNoFriend.Visible = false;
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 512);
            this.Controls.Add(this.alertNoFriend);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.openReadMessage);
            this.Controls.Add(this.delFriend);
            this.Controls.Add(this.addFriend);
            this.Controls.Add(this.addFriendUsername);
            this.Controls.Add(this.LabelAddFriendUsername);
            this.Controls.Add(this.titleAddFriend);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sendMessage);
            this.Controls.Add(this.labelFriendList);
            this.Controls.Add(this.displayInfo);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.dataGridFriend);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Profile";
            this.Text = "Mess\'Hash";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Profile_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFriend)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridFriend;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.RichTextBox displayInfo;
        private System.Windows.Forms.Label labelFriendList;
        private System.Windows.Forms.Button sendMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label titleAddFriend;
        private System.Windows.Forms.Label LabelAddFriendUsername;
        private System.Windows.Forms.TextBox addFriendUsername;
        private System.Windows.Forms.Button addFriend;
        private System.Windows.Forms.Button delFriend;
        private System.Windows.Forms.Button openReadMessage;
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label alertNoFriend;
    }
}
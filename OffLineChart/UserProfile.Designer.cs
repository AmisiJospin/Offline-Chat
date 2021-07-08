namespace OffLineChart
{
    partial class UserProfile
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
            this.OutBoxButton = new System.Windows.Forms.Button();
            this.InBoxButton = new System.Windows.Forms.Button();
            this.PersonalLabel = new System.Windows.Forms.Label();
            this.UserProfilePanel = new System.Windows.Forms.Panel();
            this.FindFriendsButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.FriendListPanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.FriendListView = new System.Windows.Forms.ListView();
            this.PersonalPanel = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.AgeLabel = new System.Windows.Forms.Label();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.GenderLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UserProfilePanel.SuspendLayout();
            this.FriendListPanel.SuspendLayout();
            this.PersonalPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // OutBoxButton
            // 
            this.OutBoxButton.Location = new System.Drawing.Point(22, 67);
            this.OutBoxButton.Name = "OutBoxButton";
            this.OutBoxButton.Size = new System.Drawing.Size(90, 33);
            this.OutBoxButton.TabIndex = 0;
            this.OutBoxButton.Text = "OUTBOX";
            this.OutBoxButton.UseVisualStyleBackColor = true;
            // 
            // InBoxButton
            // 
            this.InBoxButton.Location = new System.Drawing.Point(492, 67);
            this.InBoxButton.Name = "InBoxButton";
            this.InBoxButton.Size = new System.Drawing.Size(75, 33);
            this.InBoxButton.TabIndex = 1;
            this.InBoxButton.Text = "INBOX";
            this.InBoxButton.UseVisualStyleBackColor = true;
            this.InBoxButton.Click += new System.EventHandler(this.InBoxButton_Click);
            // 
            // PersonalLabel
            // 
            this.PersonalLabel.AutoSize = true;
            this.PersonalLabel.Location = new System.Drawing.Point(256, 118);
            this.PersonalLabel.Name = "PersonalLabel";
            this.PersonalLabel.Size = new System.Drawing.Size(75, 17);
            this.PersonalLabel.TabIndex = 2;
            this.PersonalLabel.Text = "UserName";
            // 
            // UserProfilePanel
            // 
            this.UserProfilePanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.UserProfilePanel.Controls.Add(this.FindFriendsButton);
            this.UserProfilePanel.Controls.Add(this.label5);
            this.UserProfilePanel.Controls.Add(this.FriendListPanel);
            this.UserProfilePanel.Controls.Add(this.PersonalPanel);
            this.UserProfilePanel.Controls.Add(this.label2);
            this.UserProfilePanel.Controls.Add(this.OutBoxButton);
            this.UserProfilePanel.Controls.Add(this.PersonalLabel);
            this.UserProfilePanel.Controls.Add(this.InBoxButton);
            this.UserProfilePanel.Location = new System.Drawing.Point(22, 12);
            this.UserProfilePanel.Name = "UserProfilePanel";
            this.UserProfilePanel.Size = new System.Drawing.Size(618, 570);
            this.UserProfilePanel.TabIndex = 3;
            // 
            // FindFriendsButton
            // 
            this.FindFriendsButton.Location = new System.Drawing.Point(467, 528);
            this.FindFriendsButton.Name = "FindFriendsButton";
            this.FindFriendsButton.Size = new System.Drawing.Size(111, 36);
            this.FindFriendsButton.TabIndex = 7;
            this.FindFriendsButton.Text = "FindFriends";
            this.FindFriendsButton.UseVisualStyleBackColor = true;
            this.FindFriendsButton.Click += new System.EventHandler(this.FindFriendsButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(256, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "UserProfile";
            // 
            // FriendListPanel
            // 
            this.FriendListPanel.Controls.Add(this.label4);
            this.FriendListPanel.Controls.Add(this.FriendListView);
            this.FriendListPanel.Location = new System.Drawing.Point(339, 234);
            this.FriendListPanel.Name = "FriendListPanel";
            this.FriendListPanel.Size = new System.Drawing.Size(228, 288);
            this.FriendListPanel.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "FriendList";
            // 
            // FriendListView
            // 
            this.FriendListView.Location = new System.Drawing.Point(15, 48);
            this.FriendListView.Name = "FriendListView";
            this.FriendListView.Size = new System.Drawing.Size(188, 223);
            this.FriendListView.TabIndex = 0;
            this.FriendListView.UseCompatibleStateImageBehavior = false;
            this.FriendListView.View = System.Windows.Forms.View.Details;
            this.FriendListView.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // PersonalPanel
            // 
            this.PersonalPanel.Controls.Add(this.label15);
            this.PersonalPanel.Controls.Add(this.label14);
            this.PersonalPanel.Controls.Add(this.label13);
            this.PersonalPanel.Controls.Add(this.label12);
            this.PersonalPanel.Controls.Add(this.NameLabel);
            this.PersonalPanel.Controls.Add(this.AgeLabel);
            this.PersonalPanel.Controls.Add(this.UserNameLabel);
            this.PersonalPanel.Controls.Add(this.GenderLabel);
            this.PersonalPanel.Controls.Add(this.label3);
            this.PersonalPanel.Location = new System.Drawing.Point(22, 234);
            this.PersonalPanel.Name = "PersonalPanel";
            this.PersonalPanel.Size = new System.Drawing.Size(285, 288);
            this.PersonalPanel.TabIndex = 4;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(15, 92);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(45, 17);
            this.label15.TabIndex = 14;
            this.label15.Text = "Name";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(15, 136);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(33, 17);
            this.label14.TabIndex = 13;
            this.label14.Text = "Age";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(15, 176);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 17);
            this.label13.TabIndex = 12;
            this.label13.Text = "Gender";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 224);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 17);
            this.label12.TabIndex = 11;
            this.label12.Text = "UserName";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(176, 92);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(28, 17);
            this.NameLabel.TabIndex = 9;
            this.NameLabel.Text = ".....";
            // 
            // AgeLabel
            // 
            this.AgeLabel.AutoSize = true;
            this.AgeLabel.Location = new System.Drawing.Point(176, 136);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Size = new System.Drawing.Size(28, 17);
            this.AgeLabel.TabIndex = 8;
            this.AgeLabel.Text = ".....";
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Location = new System.Drawing.Point(176, 224);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(28, 17);
            this.UserNameLabel.TabIndex = 6;
            this.UserNameLabel.Text = ".....";
            // 
            // GenderLabel
            // 
            this.GenderLabel.AutoSize = true;
            this.GenderLabel.Location = new System.Drawing.Point(176, 176);
            this.GenderLabel.Name = "GenderLabel";
            this.GenderLabel.Size = new System.Drawing.Size(28, 17);
            this.GenderLabel.TabIndex = 5;
            this.GenderLabel.Text = ".....";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Personal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(256, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Details";
            // 
            // UserProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 601);
            this.Controls.Add(this.UserProfilePanel);
            this.Name = "UserProfile";
            this.Text = "UserProfile";
            this.UserProfilePanel.ResumeLayout(false);
            this.UserProfilePanel.PerformLayout();
            this.FriendListPanel.ResumeLayout(false);
            this.FriendListPanel.PerformLayout();
            this.PersonalPanel.ResumeLayout(false);
            this.PersonalPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button OutBoxButton;
        private System.Windows.Forms.Button InBoxButton;
        private System.Windows.Forms.Label PersonalLabel;
        private System.Windows.Forms.Panel UserProfilePanel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel FriendListPanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView FriendListView;
        private System.Windows.Forms.Panel PersonalPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label AgeLabel;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.Label GenderLabel;
        private System.Windows.Forms.Button FindFriendsButton;
    }
}
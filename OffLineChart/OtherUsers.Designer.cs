namespace OffLineChart
{
    partial class OtherUsers
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
            this.PeopleListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PeoplesPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.PersonalPanel = new System.Windows.Forms.Panel();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.AgeLabel = new System.Windows.Forms.Label();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.GenderLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.UserDetailsPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.PeoplesPanel.SuspendLayout();
            this.PersonalPanel.SuspendLayout();
            this.UserDetailsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // PeopleListView
            // 
            this.PeopleListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.PeopleListView.Location = new System.Drawing.Point(17, 91);
            this.PeopleListView.Name = "PeopleListView";
            this.PeopleListView.Size = new System.Drawing.Size(283, 452);
            this.PeopleListView.TabIndex = 0;
            this.PeopleListView.UseCompatibleStateImageBehavior = false;
            this.PeopleListView.View = System.Windows.Forms.View.Details;
            this.PeopleListView.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.PeopleListView_ItemSelectionChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "List";
            // 
            // PeoplesPanel
            // 
            this.PeoplesPanel.Controls.Add(this.label1);
            this.PeoplesPanel.Controls.Add(this.PeopleListView);
            this.PeoplesPanel.Location = new System.Drawing.Point(33, 61);
            this.PeoplesPanel.Name = "PeoplesPanel";
            this.PeoplesPanel.Size = new System.Drawing.Size(336, 555);
            this.PeoplesPanel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "People Using The App ";
            // 
            // PersonalPanel
            // 
            this.PersonalPanel.Controls.Add(this.ConnectButton);
            
            this.PersonalPanel.Controls.Add(this.label15);
            this.PersonalPanel.Controls.Add(this.label14);
            this.PersonalPanel.Controls.Add(this.label13);
            this.PersonalPanel.Controls.Add(this.label12);
            this.PersonalPanel.Controls.Add(this.NameLabel);
            this.PersonalPanel.Controls.Add(this.AgeLabel);
            this.PersonalPanel.Controls.Add(this.UserNameLabel);
            this.PersonalPanel.Controls.Add(this.GenderLabel);
            this.PersonalPanel.Controls.Add(this.label3);
            this.PersonalPanel.Location = new System.Drawing.Point(18, 79);
            this.PersonalPanel.Name = "PersonalPanel";
            this.PersonalPanel.Size = new System.Drawing.Size(269, 464);
            this.PersonalPanel.TabIndex = 5;
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(12, 432);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(75, 23);
            this.ConnectButton.TabIndex = 16;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // CancelButton
            // 
            //this.CancelButton.Location = new System.Drawing.Point(167, 432);
            //this.CancelButton.Name = "CancelButton";
            //this.CancelButton.Size = new System.Drawing.Size(75, 23);
            //this.CancelButton.TabIndex = 15;
            //this.CancelButton.Text = "Cancel";
            //this.CancelButton.UseVisualStyleBackColor = true;
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
            this.label14.Location = new System.Drawing.Point(15, 173);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(33, 17);
            this.label14.TabIndex = 13;
            this.label14.Text = "Age";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(15, 256);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 17);
            this.label13.TabIndex = 12;
            this.label13.Text = "Gender";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 354);
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
            this.AgeLabel.Location = new System.Drawing.Point(176, 173);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Size = new System.Drawing.Size(28, 17);
            this.AgeLabel.TabIndex = 8;
            this.AgeLabel.Text = ".....";
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Location = new System.Drawing.Point(176, 354);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(28, 17);
            this.UserNameLabel.TabIndex = 6;
            this.UserNameLabel.Text = ".....";
            // 
            // GenderLabel
            // 
            this.GenderLabel.AutoSize = true;
            this.GenderLabel.Location = new System.Drawing.Point(176, 256);
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
            // UserDetailsPanel
            // 
            this.UserDetailsPanel.Controls.Add(this.label2);
            this.UserDetailsPanel.Controls.Add(this.PersonalPanel);
            this.UserDetailsPanel.Location = new System.Drawing.Point(393, 61);
            this.UserDetailsPanel.Name = "UserDetailsPanel";
            this.UserDetailsPanel.Size = new System.Drawing.Size(322, 555);
            this.UserDetailsPanel.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "User Details";
            // 
            // OtherUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(749, 650);
            this.Controls.Add(this.UserDetailsPanel);
            this.Controls.Add(this.PeoplesPanel);
            this.Name = "OtherUsers";
            this.Text = "OtherUsers";
            this.PeoplesPanel.ResumeLayout(false);
            this.PeoplesPanel.PerformLayout();
            this.PersonalPanel.ResumeLayout(false);
            this.PersonalPanel.PerformLayout();
            this.UserDetailsPanel.ResumeLayout(false);
            this.UserDetailsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView PeopleListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Panel PeoplesPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PersonalPanel;
        private System.Windows.Forms.Button ConnectButton;
       
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label AgeLabel;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.Label GenderLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel UserDetailsPanel;
        private System.Windows.Forms.Label label2;
    }
}
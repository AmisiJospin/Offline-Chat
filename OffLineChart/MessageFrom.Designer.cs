namespace OffLineChart
{
    partial class MessageFrom
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
            this.MessageFromPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.FromLabel = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.ReplyButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MessageFromPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MessageFromPanel
            // 
            this.MessageFromPanel.Controls.Add(this.label3);
            this.MessageFromPanel.Controls.Add(this.FromLabel);
            this.MessageFromPanel.Controls.Add(this.CloseButton);
            this.MessageFromPanel.Controls.Add(this.ReplyButton);
            this.MessageFromPanel.Controls.Add(this.label2);
            this.MessageFromPanel.Controls.Add(this.label1);
            this.MessageFromPanel.Location = new System.Drawing.Point(33, 53);
            this.MessageFromPanel.Name = "MessageFromPanel";
            this.MessageFromPanel.Size = new System.Drawing.Size(720, 600);
            this.MessageFromPanel.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(298, 311);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "..............";
            // 
            // FromLabel
            // 
            this.FromLabel.AutoSize = true;
            this.FromLabel.Location = new System.Drawing.Point(86, 70);
            this.FromLabel.Name = "FromLabel";
            this.FromLabel.Size = new System.Drawing.Size(28, 17);
            this.FromLabel.TabIndex = 5;
            this.FromLabel.Text = ".....";
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(611, 544);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 33);
            this.CloseButton.TabIndex = 4;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // ReplyButton
            // 
            this.ReplyButton.Location = new System.Drawing.Point(433, 544);
            this.ReplyButton.Name = "ReplyButton";
            this.ReplyButton.Size = new System.Drawing.Size(86, 33);
            this.ReplyButton.TabIndex = 3;
            this.ReplyButton.Text = "Reply";
            this.ReplyButton.UseVisualStyleBackColor = true;
            this.ReplyButton.Click += new System.EventHandler(this.ReplyButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Message";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "From:";
            // 
            // MessageFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(787, 707);
            this.Controls.Add(this.MessageFromPanel);
            this.Name = "MessageFrom";
            this.Text = "MessageFrom";
            this.MessageFromPanel.ResumeLayout(false);
            this.MessageFromPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MessageFromPanel;
        private System.Windows.Forms.Label FromLabel;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button ReplyButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}
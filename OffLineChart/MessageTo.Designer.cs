namespace OffLineChart
{
    partial class MessageTo
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
            this.MessageToPanel = new System.Windows.Forms.Panel();
            this.ToTextBox = new System.Windows.Forms.TextBox();
            this.FromLabel = new System.Windows.Forms.Label();
            this.SendButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MessageToPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MessageToPanel
            // 
            this.MessageToPanel.Controls.Add(this.ToTextBox);
            this.MessageToPanel.Controls.Add(this.FromLabel);
            this.MessageToPanel.Controls.Add(this.SendButton);
            this.MessageToPanel.Controls.Add(this.label2);
            this.MessageToPanel.Controls.Add(this.label1);
            this.MessageToPanel.Location = new System.Drawing.Point(27, 35);
            this.MessageToPanel.Name = "MessageToPanel";
            this.MessageToPanel.Size = new System.Drawing.Size(720, 600);
            this.MessageToPanel.TabIndex = 0;
            // 
            // ToTextBox
            // 
            this.ToTextBox.Location = new System.Drawing.Point(34, 182);
            this.ToTextBox.Multiline = true;
            this.ToTextBox.Name = "ToTextBox";
            this.ToTextBox.Size = new System.Drawing.Size(652, 330);
            this.ToTextBox.TabIndex = 6;
            // 
            // FromLabel
            // 
            this.FromLabel.AutoSize = true;
            this.FromLabel.Location = new System.Drawing.Point(130, 70);
            this.FromLabel.Name = "FromLabel";
            this.FromLabel.Size = new System.Drawing.Size(28, 17);
            this.FromLabel.TabIndex = 5;
            this.FromLabel.Text = ".....";
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(611, 544);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(75, 23);
            this.SendButton.TabIndex = 4;
            this.SendButton.Text = "Send";
            this.SendButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Type Here";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Replying to:";
            // 
            // MessageTo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(791, 680);
            this.Controls.Add(this.MessageToPanel);
            this.Name = "MessageTo";
            this.Text = "MessageTo";
            this.MessageToPanel.ResumeLayout(false);
            this.MessageToPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MessageToPanel;
        private System.Windows.Forms.Label FromLabel;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ToTextBox;
    }
}
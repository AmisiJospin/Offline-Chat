namespace OffLineChart
{
    partial class InBox
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
			this.InBoxPanel = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.InBoxListView = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.InBoxPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// InBoxPanel
			// 
			this.InBoxPanel.Controls.Add(this.label1);
			this.InBoxPanel.Controls.Add(this.InBoxListView);
			this.InBoxPanel.Location = new System.Drawing.Point(23, 22);
			this.InBoxPanel.Name = "InBoxPanel";
			this.InBoxPanel.Size = new System.Drawing.Size(640, 650);
			this.InBoxPanel.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(281, 31);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(50, 17);
			this.label1.TabIndex = 1;
			this.label1.Text = "INBOX";
			// 
			// InBoxListView
			// 
			this.InBoxListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
			this.InBoxListView.HideSelection = false;
			this.InBoxListView.Location = new System.Drawing.Point(48, 77);
			this.InBoxListView.Name = "InBoxListView";
			this.InBoxListView.Size = new System.Drawing.Size(567, 543);
			this.InBoxListView.TabIndex = 0;
			this.InBoxListView.UseCompatibleStateImageBehavior = false;
			this.InBoxListView.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "                   LIST";
			this.columnHeader1.Width = 162;
			// 
			// InBox
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(709, 713);
			this.Controls.Add(this.InBoxPanel);
			this.Name = "InBox";
			this.Text = "InBox";
			this.InBoxPanel.ResumeLayout(false);
			this.InBoxPanel.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel InBoxPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView InBoxListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}
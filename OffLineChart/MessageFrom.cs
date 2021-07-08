using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OffLineChart
{
    public partial class MessageFrom : Form
    {
        public MessageFrom()
        {
            InitializeComponent();
        }

        private void ReplyButton_Click(object sender, EventArgs e)
        {
            MessageTo mt = new MessageTo();
            this.Hide();
            mt.Show();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            UserProfile user = new UserProfile();
            this.Hide();
            user.Show();
        }
    }
}

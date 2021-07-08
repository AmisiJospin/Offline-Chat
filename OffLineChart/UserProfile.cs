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
    public partial class UserProfile : Form
    {
        public UserProfile()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void InBoxButton_Click(object sender, EventArgs e)
        {
            InBox i = new InBox();
            this.Hide();
            i.ShowDialog();
        }

        private void FindFriendsButton_Click(object sender, EventArgs e)
        {
            OtherUsers ot = new OtherUsers();
            this.Hide();
            ot.Show();
        }
    }
}

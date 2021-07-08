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
    public partial class OtherUsers : Form
    {
        public OtherUsers()
        {
            InitializeComponent();

            AddAllUsers();
           
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            UserProfile us = new UserProfile();
            this.Hide();
            us.Show();
        }

        private void PeopleListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {

        }

        public void AddAllUsers() 
        {
            for (int i = 0; i < AppDataCare.registeredUSer.Count; i++)
            {
                if (!AppDataCare.currentUser.Equals(AppDataCare.registeredUSer[i].userName))
                {
                    PeopleListView.Items.Add(AppDataCare.registeredUSer[i].name);
                }
            }
        }
    }
}

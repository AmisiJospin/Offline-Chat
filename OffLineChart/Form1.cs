using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace OffLineChart
{
    public partial class LoginForm : Form
    {


        Register User = new Register();
     //public static   List<Keeper> Details = new List<Keeper>();
        string fullpath = @"ClientsInfo.apd";

        public LoginForm()
        {
            InitializeComponent();

            AppDataCare.readData();
          
           
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            Register r = new Register();
            this.Hide();
            r.Show();
           

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            Login();

           
           
        }

        public void Login()
        {
            for (int i = 0; i < AppDataCare.registeredUSer.Count; i++)
            {

                Register rg = new Register();

                if (LuserNameBox.Text.Equals(AppDataCare.registeredUSer[i].userName) && LpasswordBox.Text.Equals(AppDataCare.registeredUSer[i].password))
                {
                    AppDataCare.currentUser = AppDataCare.registeredUSer[i].userName;

                    UserProfile u = new UserProfile();
                    this.Hide();
                    u.ShowDialog();

                    break;

                }


                else if (i == (User.Details.Count - 1))
                {
                    MessageBox.Show("Either your password and/or username are incorrect or You are not registered with us!! ");
                }

            }
        }


    }
}

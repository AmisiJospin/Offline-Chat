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
    public partial class Register : Form
    {

       public List<Keeper> Details = new List<Keeper>();
        string fullpath = @"ClientsInfo.apd";
        public Register()
        {
            InitializeComponent();
           
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            LoginForm up = new LoginForm();
            this.Hide();
            up.Show();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            GetRegister();

            //Save();

           

        }

        public void GetRegister()
        {
            if (RpasswordBox.Text.Equals(RconfirmBox.Text))
            {

                AppDataCare.registeredUSer.Add(new Keeper(RfullnameBox.Text, RageBox.Text, RgenderBox.Text, RdobBox.Text, RuserNameBox.Text, RpasswordBox.Text));
                LoginForm lf = new LoginForm();
                this.Hide();
                lf.Show();

                AppDataCare.SaveToDatabase();
 
            }

            else
            {
                MessageBox.Show("The first and second Passwords are not The Same!!");
            }



        }

        public void Save()
        {

            try
            {
                StreamWriter writer = new StreamWriter(fullpath);
                for (int i = 0; i < Details.Count; i++)
                {
                    RegistrationInfo(Details[i], writer);
                }

                writer.Close();
            }
            catch (Exception ei)
            {
                MessageBox.Show(ei.Message);
            }
        }


        public void RegistrationInfo(Keeper ri, StreamWriter writer)
        {

            writer.WriteLine("CLIENT INFO");

            writer.WriteLine("Name: " + ri.name);
            writer.WriteLine("Gender: " + ri.gender);
            writer.WriteLine("Age: " + ri.age);
            writer.WriteLine("Date Of Birth: " + ri.dob);
            writer.WriteLine("User Name: " + ri.userName);
            writer.WriteLine("Password: " + ri.password);
            writer.WriteLine("");
            writer.WriteLine("");

        }


        public void readData()
        {
            try
            {
                StreamReader reader = new StreamReader(fullpath);
                string line = "";

                while ((line = reader.ReadLine()) != null)
                {
                    string allData = "";

                    if (line.Equals("CLIENT INFO"))
                    {


                        for (int i = 0; i < 6; i++)
                        {
                            string temp = reader.ReadLine();
                            string[] temps = temp.Split(':');
                            allData += temps[1].Trim() + ",";
                        }
                        reader.ReadLine();
                        reader.ReadLine();
                        string[] temps2 = allData.Split(',');

                        Details.Add(new Keeper(temps2[0], temps2[1], temps2[2], temps2[3], temps2[4], temps2[5]));

                    }
                }
                reader.Close();
            }
            catch (Exception read)
            {
                MessageBox.Show("Error Report: " + read.Message);
            }
        }

    }
}
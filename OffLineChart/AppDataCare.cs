using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;


namespace OffLineChart
{
    public class AppDataCare
    {


        //Data about current users 
        public static string currentUser = "";
        public static string currentUserId = "";


        //General Application 
        public static string database = "registered.csv";

        public static List<Keeper> registeredUSer = new List<Keeper>();

        public static  void SaveToDatabase()
        {

            
            try
            {
                StreamWriter writer = new StreamWriter(database);
                for (int i = 0; i < registeredUSer.Count; i++)
                {
                    RegistrationInfo(registeredUSer[i], writer);

                }

                writer.Close();
            }
            catch (Exception ei)
            {
                //MessageBox.Show(ei.Message);
            }
        }


        public static  void RegistrationInfo(Keeper ri, StreamWriter writer)
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


        public static void readData()
        {
            try
            {
                StreamReader reader = new StreamReader(database);
                
                string line = "";

                while ((line = reader.ReadLine()) != null)
                {
                    string allData = "";


                    if (line.Equals("CLIENT INFO"))
                    {

                        for (int i = 0; i < 6; i++)
                        {
                            string temp = reader.ReadLine(); //String temp = "Name:Otaniel Kazimoto"
                            string[] temps = temp.Split(':'); //String[] temps = "Name", "Otaniel Kazimoto"
                            allData += temps[1].Trim() + ","; // "Otaniel Kazimoto,Male,23,"
                        }
                        reader.ReadLine();
                        reader.ReadLine();
                        string[] temps2 = allData.Split(','); //String[] temp2 = {"Otaniel Kazimoto", "Male", "23"...}

                        registeredUSer.Add(new Keeper(temps2[0], temps2[1], temps2[2], temps2[3], temps2[4], temps2[5]));


                    }
                }
                reader.Close();
            }
            catch (Exception read)
            {
                //MessageBox.Show("Error Report: " + read.Message);
            }
        }
    }
}

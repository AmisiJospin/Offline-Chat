using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

//namespace OffLineChart
//{
//    public class DataKeeper
    //{
    //   // public static List<Keeper> Details = new List<Keeper>();
    //    public static string fullPath = @"c:\users\New Student Intake\Desktop\ClientsInfo.apd";
    //    public static Keeper[] Details = new Keeper[7];
    //   public static Keeper[] serverTemp = new Keeper[5];


    //    public static void RegisterUser(string name, string age, string gender, string dob, string userName, string password)
    //    {
    //        for (int i = 0; i < Details.Length; i++)
    //        {
    //            if (Details[i] == null)
    //            {
    //                Details[i] = new Keeper();

    //                Details[i].name = name;
    //                Details[i].age = age;
    //                Details[i].gender = gender;
    //                Details[i].dob = dob;
    //                Details[i].password = password;

    //            }
    //        }
    //    }



    //    public static void RegistrationInfo(Keeper ri, StreamWriter writer)
    //    {

    //        writer.WriteLine("CLIENT INFO");

    //        writer.WriteLine("Name: " + ri.name);
    //        writer.WriteLine("Gender: " + ri.gender);
    //        writer.WriteLine("Age: " + ri.age);
    //        writer.WriteLine("Date Of Birth: " + ri.dob);
    //        writer.WriteLine("User Name: " + ri.userName);
    //        writer.WriteLine("Password: " + ri.password);
    //        writer.WriteLine("");
    //        writer.WriteLine("");

    //    }
    //    public static void WriteMethod()
    //    {

    //        try
    //        {
    //            StreamWriter writer = new StreamWriter(fullPath);
    //            for (int i = 0; i < DataKeeper.Details.Length; i++)
    //            {
    //                if (DataKeeper.Details[i] != null)
    //                {
    //                    if (DataKeeper.Details[i].name != null)
    //                    {
    //                        RegistrationInfo(DataKeeper.Details[i], writer);
    //                    }
    //                }
    //            }

    //            writer.Close();
    //        }
    //        catch (Exception ei)
    //        {

    //        }
    //    }

    //    public static void readUserData()
    //    {
    //        try
    //        {
    //            StreamReader reader = new StreamReader(fullPath);
    //            string line = "";

    //            while ((line = reader.ReadLine()) != null)
    //            {
    //                string allData = "";

    //                if (line.Equals("CLIENT INFO"))
    //                {
    //                    string o = reader.ReadLine();

    //                    for (int i = 0; i < 5; i++)
    //                    {
    //                        string temp = reader.ReadLine();
    //                        string[] temps = temp.Split(':');
    //                        allData += temps[1].Trim() + ",";
    //                    }
    //                    reader.ReadLine();
    //                    reader.ReadLine();
    //                    string[] temps2 = allData.Split(',');

    //                    //Server.Add(new CodeEngin(temps2[0], temps2[1], temps2[2], temps2[3], temps2[4]));

    //                    for (int a = 0; a < DataKeeper.Details.Length; a++)
    //                    {
    //                        if (DataKeeper.Details[a] == null)
    //                        {
    //                            DataKeeper.Details[a] = new Keeper();
    //                            DataKeeper.Details[a].name = temps2[0];
    //                            DataKeeper.Details[a].gender = temps2[1];
    //                            DataKeeper.Details[a].age = temps2[2];
    //                            DataKeeper.Details[a].dob = temps2[3];
    //                            DataKeeper.Details[a].password = temps2[4];
    //                            break;
    //                        }
    //                    }

    //                }
    //            }
    //            reader.Close();
    //        }
    //        catch (Exception read)
    //        {

    //        }
    //    }

    //        public static void Login(string userName,string password)
    //        {
    //            for (int i = 0; i < Details.Length; i++)
    //            {

    //                Register rg = new Register();

    //                //if (Details != null)
    //                //{
    //                if (Details[i].userName.Equals(userName) && Details[i].password.Equals(password))
    //                {
    //                    UserProfile u = new UserProfile();
                        
    //                    u.ShowDialog();
    //                    break;

    //                }


    //                else 
    //                {
    //                    MessageBox.Show("Either your password and/or username are incorrect or You are not registered with us!! ");
    //                }
    //                //} 
    //            }
    //        }
    //        public static void GetProfileInfo(string name, string age, string gender,string userName)
    //        {
    //            for (int i = 0; i <Details.Length; i++)
    //            {
    //                if (Details[i] != null)
    //                {
    //                    name = Details[i].name;
    //                    age = Details[i].age;
    //                    gender = Details[i].gender;
    //                    userName = Details[i].userName;
    //                }
    //            }
    //        }

    //        public void DisplayInfo()
    //        {
    //            PeopleListView.Items.Clear();
    //            try
    //            {
    //                for (int i = 0; i <= Details.Length; i++)
    //                {
    //                    if (Details[i] != null)
    //                    {
    //                        if (Details[i].name != null)
    //                        {
    //                            PeopleListView.Items.Add(Details[i].ToString());
    //                        }
    //                    }
    //                }
    //            }
    //            catch (Exception)
    //            {


    //            }

    //        }

     
       


           
    



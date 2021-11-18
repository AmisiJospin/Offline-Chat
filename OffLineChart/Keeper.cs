using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace OffLineChart
{
   public class Keeper
    {

        //variables for register form
        public string name;
        public string age;
        public string gender;
        public string dob;
        public string userName;
        public string password;


         // You need to add your own method here!!

        public Keeper() { }

        public Keeper(string name, string age, string gender, string dob, string userName, string password)
        {
            //variables for register form
            this.name = name;
            this.age = age;
            this.gender = gender;
            this.dob = dob;
            this.userName = userName;
            this.password = password;


        }
    }
}

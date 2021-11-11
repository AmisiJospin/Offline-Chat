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
    public partial class MessageTo : Form
    {
        public static string name = "";
        public MessageTo()
        {
            InitializeComponent();
            name = "Jospin Amisi"
        }
        
        public static void ShowNames(){
            for(int n= 0; n < 10; n++){
                string newName = name + " " + n;
            }
        }
    }
}

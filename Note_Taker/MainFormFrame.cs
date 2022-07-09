using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Note_Taker
{
    public partial class MainFormFrame : Form
    {
        public MainFormFrame()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            


            using (StreamWriter sw = File.CreateText(@"C:\Users\OwenR\source\repos\Note_Taker\Files\Test.txt"))
            {
                string strVal;

                strVal = TextArea.Text;

                sw.WriteLine(strVal);
            }
        }
    }
}

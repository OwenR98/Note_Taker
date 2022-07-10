﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace Note_Taker
{
    public partial class MainFormFrame : Form
    {
        public MainFormFrame()
        {
            InitializeComponent();
        }

        /// <summary>
        /// On click of the save button, carry out this logic.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveButton_Click(object sender, EventArgs e)
        {
            // Get the current date and time when the file is saved.
            string currentDateTime = DateTime.Now.ToString() + ".txt";

            // Magic filepath to the files folder for now, this will change in the future.
            string filePath = @"C:\Users\OwenR\source\repos\Note_Taker\Files\";

            // Replace all colons with hyphens as the file path wont accept colons.
            currentDateTime = Regex.Replace(currentDateTime, @":", "-");

            // Replace all forward slashes in the datetime with hyphens as it reads this as back slashes which returns an
            // incorrect file path.
            currentDateTime = Regex.Replace(currentDateTime, @"/", "-");

            // Create a new text file and name it using the above logic.
            // Then take the content of the main text area and put this into the text file.
            using (StreamWriter sw = File.CreateText(Path.Combine(filePath, currentDateTime)))
            {
                string strVal;

                strVal = TextArea.Text;

                sw.WriteLine(strVal);
            }
        }
    }
}

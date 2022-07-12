using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;


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
        /// <param name="sender">No idea, Windows form stuff.</param>
        /// <param name="e">Also no idea, Windows form stuff.</param>
        private void SaveButton_Click(object sender, EventArgs e)
        {
            // set the default extension as .txt.
            string userDecidedPath;
            saveFileDialog1.DefaultExt = ".txt";
            saveFileDialog1.AddExtension = true;
            
            // Ensure the file path is valid, if it is then use it.
            switch (saveFileDialog1.ShowDialog())
            {
                case DialogResult.OK:
                    userDecidedPath = saveFileDialog1.FileName;
                    break;

                case DialogResult.Cancel:
                    return;

                default:
                    throw new Exception($"The file path '{saveFileDialog1.FileName}' was not valid, please try again.");

            }

            // Create a new text file and name it using the above logic.
            // Then take the content of the main text area and put this into the text file.
            using (StreamWriter sw = File.CreateText(userDecidedPath))
            {
                string strVal;

                strVal = TextArea.Text;

                sw.WriteLine(strVal);
            }
        }

        /// <summary>
        /// On click of the clear text button, wipe all text from the textarea.
        /// </summary>
        /// <param name="sender">Microsoft stuff.</param>
        /// <param name="e">More Microsoft stuff.</param>
        private void ClearTextButton_Click(object sender, EventArgs e)
        {
            TextArea.Text = "";
        }
    }
}

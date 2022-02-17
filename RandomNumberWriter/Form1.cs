using RandomNumberWriter.FileGeneration;
using RandomNumberWriter.NumberGeneration;
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

/**
* Date
* CSC 153
* Your Name
* Program description
*/

namespace RandomNumberWriter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Generate_File_Click(object sender, EventArgs e)
        {
            string requstedNumberText = numberInputTextBox.Text;

            int requstedAmount = ProvideNumbers.TextToNum(requstedNumberText, this); //this is passed so the only Form1 performs UI actions when an error is found in user input. 

            if (requstedAmount == -1)  {
                return; //-1 is returned when any non valid input is caught in the TextToNum method 
            }

            List<int> generatedNumbers = ProvideNumbers.grabRandoms(requstedAmount);

            ConstructFile.RandomNumber(generatedNumbers, this); 
        }

        public void DisplayErrorMessage(string message)
        {
            statusLabel.Text = ("status: " + message);
        }
    }
}

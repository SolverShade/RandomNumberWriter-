using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace RandomNumberWriter.FileGeneration
{
    public static class ConstructFile
    {
        public static void RandomNumber(List<int> generatedNumbers, Form1 form)
        {
            StreamWriter outputFile = File.CreateText("RandomNumbers.txt");

            try
            {              
                if (form.saveFile.ShowDialog() == DialogResult.OK)
                {
                    outputFile = File.CreateText(form.saveFile.FileName); //stuff
                }               
            }
            catch(Exception ex)
            {
                form.DisplayErrorMessage("Invalid File Location/Name");
            }

            foreach (int num in generatedNumbers)
            {
                outputFile.WriteLine(num.ToString());
            }

            outputFile.Close();
        }
    }
}

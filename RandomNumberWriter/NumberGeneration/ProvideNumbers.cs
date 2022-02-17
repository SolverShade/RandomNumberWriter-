using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumberWriter.NumberGeneration
{
    static public class ProvideNumbers
    {
        static public int TextToNum(string text, Form1 form)
        {
            bool parsed = int.TryParse(text, out int convertedNum);

            if (parsed && convertedNum > 0) 
            {
                return convertedNum;
            }
            else
            {
                form.DisplayErrorMessage("Please Enter a Valid Amount to Be Generated. Must Be Above 0 And An Interger");
                return -1;
            }
        }


        static public List<int> grabRandoms(int amount)
        {
            Random rand = new Random();

            List<int> generatedNumbers = new List<int>(); 

            for (int RequstedIndex = 0; RequstedIndex < amount; RequstedIndex++)
            {
                int nextNum = rand.Next(1, 100);
                generatedNumbers.Add(nextNum);
            }

            return (generatedNumbers);
        }
    }
}

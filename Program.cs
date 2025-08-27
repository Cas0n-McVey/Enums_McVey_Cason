using System;
using System.IO;

namespace Enums_McVey_Cason
{
    // Uses months to increase the number and assign a month plus, make Jan equals 1 to increase the number like Feb is 2
    enum Months
    {
        Jan = 1,
        Feb,
        Mar,
        Apr,
        May,
        Jun,
        Jul,
        Aug,
        Sep,
        Oct,
        Nov,
        Dec
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Makes Months an integer to paint 12 as Dec and assign my birth day and year
            int myBirthMonth = (int)Months.Dec;
            int myBirthDay = 9;
            int myBirthYear = 2006;

            // My string paints my birth month, day, and year
            string myBirthDate = $"My birthday is on {myBirthMonth}/{myBirthDay}/{myBirthYear}";

            // WriteAllText writes text from a file and paints it with ReadAllText
            File.WriteAllText("myFile.txt", "This is my text file!\n");
            Console.WriteLine(File.ReadAllText("myFile.txt"));

            // AppendAllText append some words that I wanted to use and Read all texts
            File.AppendAllText("myFile.txt", "WooHoo more text added to file!\n");
            Console.WriteLine(File.ReadAllText("myFile.txt"));

            // If copies the myFile.txt with newFile.Txt if it isn't exists and else replace myFile.txt with newFile.txt and has a backupFile
            if(!File.Exists("newFile.txt"))
            {
                File.Copy("myFile.txt", "newFile.txt");
            }
            else
            {
                File.Replace("newFile.txt", "myFile.txt", "backupFile.txt");
            }
            
            // Append my file with my myBirthDate string and read all text from newFile.txt
            File.AppendAllText("newFile.txt", myBirthDate);
            Console.WriteLine(File.ReadAllText("newFile.txt"));
        }
    }
}

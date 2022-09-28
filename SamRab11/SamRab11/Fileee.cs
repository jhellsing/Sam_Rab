using System;
using System.Text.RegularExpressions;
using System.IO;

namespace SamRab11
{
    public class Fileee
    {
        public async void fileee()
        {
            string path = @"C:\Users\Student.POLCOL\Desktop\егоровсуперегоровкласс.txt";
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = await reader.ReadLineAsync()) != null)
                {
                    Console.WriteLine(line);
                }
            }


        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileReader
{
    class FileReader
    {
        static void Main(string[] args)
        {
        
            //Create an instance of StreamReader to read from a file
            StreamReader reader = new StreamReader("..\\..\\Sample.txt");
            using (reader)
            {

                int lineNumber = 0;

                //read first line from the text file
                string line = reader.ReadLine();

                //read the other lines from the text file
                while (line != null)
                {
                    lineNumber++;
                    Console.WriteLine("Line {0}: {1}", lineNumber, line);
                    line = reader.ReadLine();
                }

            }
      

        }
    }
}



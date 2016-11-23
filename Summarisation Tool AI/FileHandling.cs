using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Summarisation_Tool_AI
{
    class FileImport
    {
        static void locationCheck(string fileLocation)
        {
            if (File.Exists(fileLocation))
            {
                var fN = new List<DataList>();
            }
            else
            {
                Console.WriteLine("Please enter a valid file name");
                string nFilename =Console.ReadLine();
                // need to implement a catch if invalid filename is entered
                
            }
        }
        static void fileToList()
        {
            //import's data
        }

    }
    public class TXTFileReader
    {
        StreamReader dataFile;

        public void txtFileReader(string filename)
        {
            string path = ("x");
            dataFile = new StreamReader("" + "");
            dataFile.ReadLine();
        }
    }
}

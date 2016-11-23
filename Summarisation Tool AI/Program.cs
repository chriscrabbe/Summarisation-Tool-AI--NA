/*Author: Christopher Crabbe
 * SID: 1409111
 * MOD:004553
 * Artificial Intelligence Assignment
 * Project Name: Summarisation_Tool_AI
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summarisation_Tool_AI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter File name");
            string fileName = Console.ReadLine();
            //fileName.c
            //location check
            Console.WriteLine("Please enter summarisation factor");
            int sF = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please wait while file is summarised");
            //import file stop list
            //import weight list
            //import file
            //strip of punc and stop words
            //assign rank
            //reorder factor in weight
            //run analytics
            //display all
            
        }
        //static void fileToList(string fileLocation)
        //{
        //    List<string> inputList = new List<string>();
        //    List<string> stopWords = new List<string>();
        //    for (int i = 0; i < inputList.Count; i++)
        //    {
        //        for (int j = 0; j < stopWords.Count; j++)
        //        {
        //            inputList[i].CompareTo(stopWords[j]);

        //        }
        //    }
        //}
    }
}

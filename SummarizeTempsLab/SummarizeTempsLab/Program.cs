using System;
using System.IO;

namespace SummarizeTempsLab
{
    class Program
    {
        static void Main(string[] args)
        {string filepath = "temps.txt"

                if (File.Exists(filepath)) ;
            { using (StreamReader sr = File.OpenText(filepath)) ;
                string line = "";
                while ((line = sr.ReadLine()) != null) ;
                {


                }

            }
            // temperature data is in temps.txt
        }
    }
}

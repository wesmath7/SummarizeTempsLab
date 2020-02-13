using System;
using System.IO;

namespace SummarizeTempsLab
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename;
            Console.WriteLine("Enter a filename");

            filename = Console.ReadLine();

            if (File.Exists(filename)) 
            {
                Console.WriteLine("File exist");
                Console.WriteLine("Enter threshold");
                string input;
                int threshold;
                input = Console.ReadLine();
                threshold = int.Parse(input);

                int sumtemps = 0;
                int numabove = 0;
                int numbelow = 0;
                double average;

                using (StreamReader sr = File.OpenText(filename))
                {

                    string line = sr.ReadLine();
                    int temp;

                    while (line != null)
                    {
                        temp = int.Parse(line);
                        sumtemps += temp;

                        if (temp >= threshold)
                        {
                            numabove += 1;
                        }
                        else
                        {
                            numbelow += 1;
                        }

                        line = sr.ReadLine();
                    }
                }
                Console.WriteLine("Temperatures above " + numabove);
                Console.WriteLine("Temperatures below " + numbelow);
                average = sumtemps / (numabove + numbelow);
                Console.WriteLine("The average temperature is " + average);
            }
            else
            {
                Console.WriteLine("The file does not exist");
            }
        }
    }
}

using System;
using System.IO;

namespace jenkins
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = @"default.html";
            StreamReader file = new StreamReader(filename);
            string line;

            while ((line = file.ReadLine()) != null) {
                Console.WriteLine($"{line.ToUpper()}");
            }
            file.Close();
            Console.WriteLine("End of file...");
        }
    }
}

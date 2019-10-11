using System;
using System.IO;

namespace jenkins
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = @"";
            StreamReader file = new StreamReader(filename);
            string line;

            while ((line = file.Read()) != null) {
                Console.WriteLine($"{line.ToUpper()}");
            }
            Console.WriteLine("End of file...");
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reading_and_Writing_Files
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press any key to begin");
            string path = @"TextFile.txt";

            string greetings = "Hello Traveler\nHow are you doing?\nPlease write your name down below: " + Environment.NewLine;
            string name;
            File.WriteAllText(path, greetings);
            Console.ReadKey();
            for(int i = 0; i < greetings.Length; i++)
            {
                Console.Write(greetings[i]);
            }
            name = Console.ReadLine();  
            File.WriteAllText(path, name);
            Console.Write("Hello\n");
            
            for(int i = 0;i < name.Length; i++)
            {
                Console.Write(name[i]);
               
            } 
            File.ReadAllText(path);
            Console.Write("\n");
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}

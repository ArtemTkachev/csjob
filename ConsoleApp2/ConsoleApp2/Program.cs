using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Hello, World!");
            Console.Beep();
            string question = Console.ReadLine();
            int size = sizeof(int);
            Console.WriteLine(size);
            Console.ReadKey();
            
        }
    }
}

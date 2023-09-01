
using System;


namespace ConsoleAppDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            for(int i=0; i < 5; i++)
            {
                Console.WriteLine("''''''''''''''''''''");
            }
            Console.Write("What is your file")
            Console.Write("'''''")
            Console.Write("What is your name?:");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello {name}");
            //Console.Write("Hello Again");
        }
    }
}


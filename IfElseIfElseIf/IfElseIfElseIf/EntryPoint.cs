using System;

class EntryPoint
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter your first number: ");
        int firstNum = int.Parse(Console.ReadLine());

        Console.WriteLine("Please enter your second number: ");
        int secondNum = int.Parse(Console.ReadLine());

        if (firstNum < secondNum)
        {
            Console.WriteLine("Of course, {0} is smaller than {1}", firstNum, secondNum);
        }
        else if (firstNum == secondNum)
        {
            Console.WriteLine("The numbers are equal!");
        }
        else if (true)
        {
            // Replace true condition and add code to run if new condition is met
            // as many times as necessary
        }
        else
        {
            Console.WriteLine("Oh yeah, {0} is smaller than {1}", firstNum, secondNum);
        }
    }
}
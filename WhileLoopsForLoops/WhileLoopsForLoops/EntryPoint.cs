using System;

class EntryPoint
{
    static void Main(string[] args)
    {

        int firstNum = 0;
        int secondNum = 10;
        // While Loop printing from 0-10
        while(firstNum <= secondNum)
        {
            Console.WriteLine("While Loop Output is: " + firstNum);
            firstNum++;
        }

        
        int thirdNum = 11;

        
        int fourthNum = 10;

        for(int i = 0; i < fourthNum; i++)
        {
            Console.WriteLine("For Loop Output is: " + (thirdNum + i));
        }

    }
}
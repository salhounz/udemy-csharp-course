using System;

class EntryPoint
{
    static void Main(string[] args)
    {
        string firstStr = "Hello ";
        string secondStr = "my name is ";
        string thirdStr = "Salhounz!";

        // Varying String Concatentation Methods

        // Ex. Console.WriteLine(firstStr + secondStr + thirdStr);
        // Ex. Console.WriteLine("Well, okay. {0} I just want to say {1} not {2}", firstStr, secondStr, thirdStr);


        // Section 2.10 Introduction to Arrays

        string strArr = "array";

        Console.WriteLine(strArr);
        // Accessing string strArr at index 0
        Console.WriteLine(strArr[0]);

        string[] newStrArr = { "hello", "this", "is", "astring", "arraayy" };

        Console.WriteLine(newStrArr[1]);
        // Outputs the length of newStrArr which is 5
        Console.WriteLine(newStrArr.Length);

        int[] intArr = { 1, 4, 55, 6 };

        Console.WriteLine(intArr[2]);

        // Accessing intArr at index 0 and assigning a new value of 456
        intArr[0] = 456;


    }
}
using System;

/*
 * Logical Operators
 * 
 * AND -  &&
 * OR  -  ||
 * XOR -  ^
 * NOT -  !
 */


class EntryPoint
{
    static void Main(string[] args)
    {
        bool isTrue = true;
        bool isFalse = false;

        Console.WriteLine(isTrue && isFalse);
        Console.WriteLine(isTrue || isFalse);
        Console.WriteLine(isTrue ^ isFalse);
        Console.WriteLine(!isTrue);

        // What is executed first and should be result?
        Console.WriteLine((isTrue || isFalse) && isFalse);
    }
}
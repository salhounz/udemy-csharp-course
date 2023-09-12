using System;
// used to minimize boilerplate code
// Ex. Console.ReadLine() vs. System.Console.ReadLine()

class EntryPoint
{
    static void Main()
    {
        // holds 32 bit postiive/negative numbers 
        int myInt = 5;

        // Output Min and Max values for int data type
        Console.WriteLine(int.MinValue);
        Console.WriteLine(int.MaxValue);

        // unsigned int
        // 32 bit positive numbers
        uint myUInt = 10;

        // unsigned
        // 8 bit numbers
        // 0 to 255
        byte myByte = 255;

        // signed 
        // 8 bit numbers
        // - 128 to 127
        sbyte mySignedByte = -128;

        // signed
        // 64 bit positive/negative numbers
        long myLong = 1234123412343;

        // unsigned
        // 64 bit positive numbers
        ulong myUnsignedLong = 123412341234;

    }
}
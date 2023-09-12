using System;

class EntryPoint
{
    /*
     * Arithmetic Operators
     *   Plus +
     *   Minus -
     *   Multiply *
     *   Divide /
     *   Modulo %
     *   ++
     *   --
     */
    static void Main(string[] args)
    {
        int a = 5;
        int b = 7;

        int addition = a + b;
        int subtraction = b - a;
        int multiplication = a * b;
        double division = a / b;
        int modulo = b % a;

        Console.WriteLine("Addition Result: {0}", addition);
        Console.WriteLine("Subtraction Result: {0}", subtraction);
        Console.WriteLine("Multiplication Result: {0}", multiplication);
        Console.WriteLine("Division Result: {0}", division);
        Console.WriteLine("Modulo Result: {0}", modulo);

        a++;
        b--;
        Console.WriteLine("a++ result: {0}", a);
        Console.WriteLine("b-- result: {0}", b);

    }
}
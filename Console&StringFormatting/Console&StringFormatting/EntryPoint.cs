using System;

class EntryPoint
{
    static void Main(string[] args)
    {
        // does not append newline character at the end of output
        Console.Write("Hello!");
        // appends newline character at the end
        Console.WriteLine("Hello...");


        // Section 3.12 String Formatting

        string freshJuice = "Lets make fresh juice from bananas";
        string berries = "strawberries";
        int five = 500;

        Console.WriteLine("{0} and {1}.", freshJuice, berries);
        Console.WriteLine();
        // Add 5 spaces before berries output
        // 17 is used as berries contains 12 characters + 5 prepended spaces = 17
        Console.WriteLine("{0, 17}", berries);

        // Output is printed from X space backwards
        // Ex. int five (500) is printed starting at the 10th space
        // so that there will be 7 spaces prior which differs
        // from String formatting
        Console.WriteLine("{0, 10}", five);


    }
}
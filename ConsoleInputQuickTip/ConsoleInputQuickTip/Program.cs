
class Program
{
    static void Main(string[] args)
        //Single Line Comment

        /*
         *  Multi Line Comment
         */
    {
        int age = 0;

        while (true)
        {
            Console.WriteLine("Please enter an age to continue: ");
            age = int.Parse(Console.ReadLine());

            if (age <= 21 && age >= 10)
            {
                break;
            }

            Console.WriteLine("Please input an age between 10 and 21!\n");
            Thread.Sleep(1000);

        }

        Console.WriteLine($"You selected a correct age of {age}!");

        

    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            int[] numbers = { 10, 20, 30 };
            Console.WriteLine("Accessing an element beyond the array size:");
            Console.WriteLine(numbers[3]);
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine("Exception Details:");
            Console.WriteLine("Message: " + ex.Message);
            Console.WriteLine("StackTrace: " + ex.StackTrace);
            Console.WriteLine("Source: " + ex.Source);
        }
    }
}

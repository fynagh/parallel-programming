using System;

class Program
{
    static void Main(string[] args)
    {
            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());

            if (age < 18)
            {
                throw new AgeBelowEighteenException("Age must be 18 or above.");
            }

            Console.WriteLine("You are eligible.");
    }
}

public class AgeBelowEighteenException : Exception
{
    public AgeBelowEighteenException(string message) : base(message)
    {
        Console.WriteLine("Try again");
    }
}

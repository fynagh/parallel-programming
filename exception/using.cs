using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            using (StreamReader reader = new StreamReader("example.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine("The file 'example.txt' was not found.");
            Console.WriteLine("Exception details: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }
}

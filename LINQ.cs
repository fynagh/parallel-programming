using System;
using System.Collections.Generic; 
using System.Linq; 

class Program
{
    static void Main(string[] args)
    {
        int[] scores = {30, 45, 68, 92, 88};
        IEnumerable<int> scoreQuery =
            from score in scores
            where score < 65
            select score;
        foreach (var i in scoreQuery)
        {
            Console.Write(i + " ");
        }


       // 1. Məlumat mənbəyini əldə etmək
        int[] numbers = { 3, 10, 17, 25, 27, 45, 66, 73 };

        // 2. Sorğunu yaratmaq
        var numQuery =
            from num in numbers
            where (num % 3) == 0
            select num;

        // 3. Sorğunu icra etmək
        foreach (int num in numQuery)
        {
            Console.Write(num + " ");
        }


       int[] numbers = { 1, 2, 3, 4, 5 };

        var query = 
        from num in numbers
        select num * num;

        foreach (var result in query)
        {
            Console.WriteLine(result);
        } 



        string[] words = { "red", "black", "yellow", "box", "paper" };

        IEnumerable<string> query = from word in words
                                    where word.Length > 3
                                    select word;

        foreach (string str in query)
        {
            Console.WriteLine(str);
        }


        List<int> nums = new List<int> { 5, 2, 8, 1, 9, 3 };
        var sortedNums = from num in nums
                            orderby num ascending
                            select num;
        foreach (var num in sortedNums)
        {
            Console.WriteLine(num);
        }


        List<int> nums = new List<int> { 12, 23, 43, 56, 44, 29, 94 };

        var groupedNums = from num in nums
                             	group num by num % 2 == 0 ? "Even" : "Odd";

        foreach (var group in groupedNums)
        {
            Console.WriteLine($"Group: {group.Key}");
            foreach (var num in group)
            {
                Console.WriteLine($"  Number: {num}");
            }
        }
    }
}

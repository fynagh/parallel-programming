using System;
using System.Collections.Generic;
using System.Threading.Tasks;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        //Foreach
        List<int> numberList = new List<int> { 1, 2, 3, 4, 5 };
        foreach (int number in numberList)
        {
            Console.WriteLine(number);
        }

        //For
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
        for (int i = 0; i < numbers.Count; i++)
        {
            Console.WriteLine(numbers[i]);
        }

        //While
        Stack<int> numberStack = new Stack<int>();
        
        numberStack.Push(1);
        numberStack.Push(2);
        numberStack.Push(3);
        numberStack.Push(4);
        numberStack.Push(5);
        
        Console.WriteLine("Popping elements from the stack:");
        
        while (numberStack.Count > 0)
        {
            Console.WriteLine(numberStack.Pop());
        }


        //LINQ
        SortedList<string, int> sortedList = new SortedList<string, int>();
        sortedList.Add("Alice", 30);
        sortedList.Add("Bob", 25);
        sortedList.Add("Charlie", 35);
        sortedList.Add("David", 40);

        var filteredPairs = sortedList.Where(pair => pair.Value > 30);


        foreach (var pair in filteredPairs)
        {
            Console.WriteLine($"Name: {pair.Key}, Age: {pair.Value}");
        }

      
        //IEnumerator
        SortedDictionary<string, int> sortedDictionary = new SortedDictionary<string, int>();

        sortedDictionary.Add("Alice", 30);
        sortedDictionary.Add("Charlie", 35);
        sortedDictionary.Add("David", 40);
        sortedDictionary.Add("Bob", 25);

        IEnumerator<KeyValuePair<string, int>> enumerator = sortedDictionary.GetEnumerator();

        while (enumerator.MoveNext())
        {
            KeyValuePair<string, int> pair = enumerator.Current;
            Console.WriteLine($"Key: {pair.Key}, Value: {pair.Value}");
        }
      

        //Parallel.ForEach
        LinkedList<int> linkedList = new LinkedList<int>();
        linkedList.AddLast(1);
        linkedList.AddLast(2);
        linkedList.AddLast(3);
        linkedList.AddLast(4);
        linkedList.AddLast(5);

        Parallel.ForEach(linkedList, (num) =>
        {
            Console.WriteLine($"Processing {num} on thread {Task.CurrentId}");
        });

        //
    }
}

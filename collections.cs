using System;
using System.Collections;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //List
        List<int> numbersList = new List<int>();
        numbersList.Add(1);
        numbersList.Add(2);
        numbersList.Add(3); 
        Console.WriteLine(numbersList[0]);
        
        //Dictionary
        Dictionary<string, int> ages = new Dictionary<string, int>();
        ages.Add("Alice", 30);
        ages.Add("Bob", 25);
        Console.WriteLine(ages["Alice"]);
        
        //HashSet
        HashSet<string> names = new HashSet<string>();
        names.Add("Alice");
        names.Add("Bob");
        names.Add("Alice"); // Təkrar adın əlavə edilməsi (iqnor edilir)
            foreach (var item in names) 
            {
                Console.WriteLine(item);
            }
        
        //Queue
        Queue<string> tasksQueue = new Queue<string>();
        tasksQueue.Enqueue("Task 1");
        tasksQueue.Enqueue("Task 2");
        Console.WriteLine("Dequeued Task: " + tasksQueue.Dequeue()); //"Dequeue" metodu növbənin əvvəlindəki elementi götürür və silir
        Console.WriteLine("Dequeued Task: " + tasksQueue.Dequeue());
        
        //Stack
        Stack<int> numberStack = new Stack<int>();
        numberStack.Push(1);
        numberStack.Push(2);
        Console.WriteLine("Popped Number: " + numberStack.Pop()); //Pop metodu növbənin sonuncu elementi götürür və silir.
        Console.WriteLine("Popped Number: " + numberStack.Pop());
    }
}

using System;
using System.Collections;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //Massiv
        int[] numbers = new int[5]; // Ölçüsü 5 olan tam ədədlər massivi yaradır
        numbers [0] = 1; // Birinci elementə dəyər təyin edilməsi
        numbers [1] = 2; // İkinci elementə dəyər təyin edilməsi
        Console.WriteLine(numbers[0]); 

        //List
        List<int> numbersList = new List<int>(); // Tam ədədlərin boş siyahısını yaradır
        numbersList.Add(1); // Siyahıya elementlərin əlavə edilməsi
        numbersList.Add(2);
        Console.WriteLine(numbers[1]); 

        //ArrayList
        ArrayList arrayList = new ArrayList(); // Tam ədədlərin boş siyahısını yaradır
        arrayList.Add(1); // Elementə dəyər təyin edilməsi
        arrayList.Add("Two");
        arrayList.Add(3.0);

            foreach (var item in arrayList) //Siyahıdakı hər bir elementi çağırır 
            {
                Console.WriteLine(item);
            }
        
        //AraryList kimi List
        List<object> list = new List<object>();
        list.Add(1);
        list.Add("Two");
        list.Add(3.0);

            foreach (var item in list) //Siyahıdakı hər bir elementi çağırır 
            {
                Console.WriteLine(item); 
            }
    }
}

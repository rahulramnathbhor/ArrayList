using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace ArrayList1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add(24);
            list.Add(10);
            list.Add(20);
            list.Add(3);
            list.Add(2);    
            list.Add(30);
            list.Add(10);
            list.Insert(1, 15);
            list.Insert(5, 56);
            list.IndexOf(10); 
            list.LastIndexOf(10);
            list.Remove(30);
            list.RemoveAt(4);

            list.Sort();
            list.Reverse();
           //  list.Clear();
            Console.WriteLine($"Capacity of list is: {list.Capacity}");
            Console.WriteLine($"Count total element in List is : {list.Count}");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }


        }

    }
}

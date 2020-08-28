using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;


namespace Custom_List_Class_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<T>
            List<int> myList = new List<int>();

            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.Add(4);
            myList.Add(5);
            myList.Remove(3);
            myList.Remove(5);
            myList.Add(8);
            myList.Add(16);
            myList.Add(32);
            myList.Add(64);
            myList.RemoveAt(0);
            CustomList<int> customList = new CustomList<int>();
            CustomList<int> customList2 = new CustomList<int>();
            customList.Add(1);
            customList.Add(2);
            customList.Add(3);
            customList.Add(4);
            customList.Add(5);
            customList.Remove(3);
            customList.Remove(5);
            customList.Add(8);
            customList.Add(16);
            customList2.Add(1);
            customList2.Add(2);
            customList2.Add(3);
            customList2.Add(4);
            customList2.Add(5);
            customList2.Remove(3);
            customList2.Remove(4);
            customList2.Remove(5);
            customList2.Add(8);
            customList2.Add(512);

           
            
            foreach (var _items in myList)
            {
                Console.WriteLine(_items);
            }

            Console.ReadLine();

            //foreach (var _items in customList)
            //{
            //    Console.WriteLine(_items);
            //}

            //Console.ReadLine();

        }
    }
}

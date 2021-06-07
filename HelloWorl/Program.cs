using System;
using System.Linq;

namespace HelloWorl
{
    class Program
    {

        static void Main(string[] args)
        {
            MyArray();
        }
        static void MyArray()
        {

            Console.WriteLine("Enter the numbers in the array");

            int[] Mynum = { 8, 10, 22, 52, 44, 78 };

            Console.WriteLine($"the length of the array Mynum is {Mynum.Length}");
            Console.WriteLine($"\nthe array in ascending order");
            Array.Sort(Mynum);
           
            
            foreach (int i in Mynum)
            {
                Console.Write($" {i}");
            }

            Console.WriteLine($"\n\nthe maximum number in the array Mynum is {Mynum.Max()}");
            Console.WriteLine($"\nthe minimum number in the array Mynum is {Mynum.Min()}");

        }
        /*static void PrimeNum(int a ,int b)
        {

            for (int i=0)
        }*/

    }

        }
    

  

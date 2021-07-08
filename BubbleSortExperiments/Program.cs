using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment4;

namespace BubbleSortExperiments
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDatabase db = new MyDatabase();
            View.PrintAllTShirts(db.TShirts, "Unsorted TShirts");

            var a = db.TShirts.ToArray();



            //int[] a = { 3, 0, 2, 5, -1, 4, 1 };


            //Console.WriteLine("Original array :");
            //foreach (int aa in a)
            //    Console.Write(aa + " ");

            TShirt temp;
            for (int p = 0; p <= a.Length - 2; p++)
            {
                for (int i = 0; i <= a.Length - 2; i++)
                {
                    if (a[i].Color > a[i + 1].Color) //Compare based on value
                    {
                        temp = a[i + 1];
                        a[i + 1] = a[i];
                        a[i] = temp;
                    }
                }
            }

            View.PrintAllTShirts(a.ToList(), "Sorted By Color");
            //Console.WriteLine("\n" + "Sorted array :");
            //foreach (int aa in a)
            //    Console.Write(aa + " ");
            //Console.Write("\n");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a = 0;
            //int b = new int();
            //double f = new double();
            //float goo = new float();
            //bool loo = new bool();


            Pixel a = new Pixel();
            Console.WriteLine(a);
            Console.WriteLine(a.Red);
            Console.WriteLine(a.Blue);
            Console.WriteLine(a.Green);

            Pixel b = new Pixel(100,120,35);
            Console.WriteLine(b.Red);
            Console.WriteLine(b.Blue);
            Console.WriteLine(b.Green);
        }
    }


    //είναι value type
    //δεν έχει finalizer/destructor
    struct Pixel //Βασική προϋπόθεση σε ένα struct είναι κάθε field ή property να αρχικοποιείται (αν δεν δηλώσω constructor, ο default τους δίνει 0)
    {
        public byte Red;
        public byte Blue;
        public byte Green;

        public Pixel(byte red, byte blue, byte green) //ο constructor πρέπει να έχει παραμέτρους (τουλάχιστον 1)
        {
            Red = red;
            Blue = blue;
            Green = green;
        }
    }
}

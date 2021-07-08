
using System;
using System.Collections.Generic;

namespace Assignment4
{
    public class View
    {
        public static void PrintAllTShirts(List<TShirt> tshirts, string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(message);
            Console.WriteLine($"{"Size",-15} {"Color",-15} {"Fabric",-15}");
            Console.ResetColor();
            foreach (var tshirt in tshirts)
            {
                Console.WriteLine($"{tshirt.Size,-15} {tshirt.Color,-15} {tshirt.Fabric,-15}");
            }
            
        }
    }
}

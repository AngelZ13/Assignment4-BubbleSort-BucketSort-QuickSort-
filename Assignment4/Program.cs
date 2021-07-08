
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment4.SortingAlgorithms;

namespace Assignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDatabase db = new MyDatabase();
            //View.PrintAllTShirts(db.TShirts.OrderBy(x=>x.Size).ToList(), "All T-Shirts");
            //View.PrintAllTShirts(db.TShirts.OrderBy(x=>x.Fabric).ToList(), "All T-Shirts");
            //View.PrintAllTShirts(db.TShirts.OrderBy(x=>x.Color).ToList(), "All T-Shirts");
            //View.PrintAllTShirts(db.TShirts.OrderByDescending(x=>x.Color).ToList(), "All T-Shirts");
            //View.PrintAllTShirts(db.TShirts.OrderByDescending(x=>x.Size).ToList(), "All T-Shirts");
            //View.PrintAllTShirts(db.TShirts.OrderByDescending(x=>x.Fabric).ToList(), "All T-Shirts");
            //View.PrintAllTShirts(db.TShirts.OrderByDescending(x=>x.Size).ThenBy(x=>x.Color).ThenByDescending(x=>x.Fabric).ToList(), "All T-Shirts ordered by Size (descending) then by color (ascending) and then by fabric (descending)");


            string choice;
            var tshirts = db.TShirts;
            do
            {
                Console.WriteLine("Choose Algorithm");
                Console.WriteLine("1 - Order By Size Ascending with Bubble Sort");
                Console.WriteLine("2 - Order By Size Descending with Bubble Sort");
                Console.WriteLine("3 - Order By Color Ascending with Quick Sort");
                Console.WriteLine("4 - Order By Color Descending with Quick Sort");
                Console.WriteLine("5 - Order By Fabric Ascending with Bucket Sort");
                Console.WriteLine("5 - Order By Fabric Descending with Bucket Sort");
                Console.WriteLine("7 - Order By Size Color Fabric Ascending with Bubble Sort");
                Console.WriteLine("8 - Order By Size Color Fabric Descending with Bubble Sort");
                Console.WriteLine("E - Exit");

                choice = Console.ReadLine();
                string message = "";
                Console.Clear();

                if (choice == "1")
                {
                    BubbleSort.OrderBySizeAscending(tshirts);
                    message = "Order By Size Ascending with Bubble Sort";
                }
                else if (choice == "2")
                {
                    BubbleSort.OrderBySizeDescending(tshirts);
                    message = "Order By Size Descending with Bubble Sort";

                }
                else if (choice == "3")
                {
                    QuickSort.OrderByColorAscending(tshirts,0,tshirts.Count-1);
                    message = "Order By Color Ascending with Quick Sort";

                }
                else if (choice == "4")
                {
                    QuickSort.OrderByColorDescending(tshirts, 0, tshirts.Count - 1);
                    message = "Order By Color Descending with Quick Sort";

                }
                else if (choice == "5")
                {
                    BucketSort.OrderByFabricAscending(tshirts);
                    message = "Order By Fabric Ascending with Bucket Sort";
                }
                else if (choice == "6")
                {
                    BucketSort.OrderByFabricDescending(tshirts);
                    message = "Order By Fabric Descending with Bucket Sort";
                }
                else if (choice == "7")
                {
                    BubbleSort.OrderBySizeColorFabricAscending(tshirts);
                    message = "Order By Size Color Fabric Ascending with Bubble Sort";

                }
                else if (choice == "8")
                {
                    BubbleSort.OrderBySizeColorFabricDescending(tshirts);
                    message = "Order By Size Color Fabric Descending with Bubble Sort";

                }
                else if (choice != "e" && choice != "E")
                {
                    Console.WriteLine("Wrong Choice!!!");
                    continue;
                }
                if (choice != "e" && choice != "E")
                {
                    View.PrintAllTShirts(tshirts, message);
                }
            } while (choice != "e" && choice != "E");

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4.SortingAlgorithms
{
    public class BubbleSort
    {
        public static void OrderBySizeAscending(List<TShirt> tshirts)
        {
            TShirt temp;
            for (int p = 0; p <= tshirts.Count - 2; p++)
            {
                for (int i = 0; i <= tshirts.Count - 2; i++)
                {
                    if (tshirts[i].Size > tshirts[i + 1].Size) 
                    {
                        temp = tshirts[i + 1];
                        tshirts[i + 1] = tshirts[i];
                        tshirts[i] = temp;
                    }
                }
            }
        }

        public static void OrderBySizeDescending(List<TShirt> tshirts)
        {
            TShirt temp;
            for (int p = 0; p <= tshirts.Count - 2; p++)
            {
                for (int i = 0; i <= tshirts.Count - 2; i++)
                {
                    if (tshirts[i].Size < tshirts[i + 1].Size)
                    {
                        temp = tshirts[i + 1];
                        tshirts[i + 1] = tshirts[i];
                        tshirts[i] = temp;
                    }
                }
            }
        }

        public static void OrderBySizeColorFabricAscending(List<TShirt> tshirts)
        {
            TShirt temp;
            for (int p = 0; p <= tshirts.Count - 2; p++)
            {
                for (int i = 0; i <= tshirts.Count - 2; i++)
                {
                    if (tshirts[i].Fabric > tshirts[i + 1].Fabric)
                    {
                        temp = tshirts[i + 1];
                        tshirts[i + 1] = tshirts[i];
                        tshirts[i] = temp;
                    }

                    if (tshirts[i].Color > tshirts[i + 1].Color)
                    {
                        temp = tshirts[i + 1];
                        tshirts[i + 1] = tshirts[i];
                        tshirts[i] = temp;
                    }

                    if (tshirts[i].Size > tshirts[i + 1].Size)
                    {
                        temp = tshirts[i + 1];
                        tshirts[i + 1] = tshirts[i];
                        tshirts[i] = temp;
                    }
                }
            }
        }

        public static void OrderBySizeColorFabricDescending(List<TShirt> tshirts)
        {
            TShirt temp;
            for (int p = 0; p <= tshirts.Count - 2; p++)
            {
                for (int i = 0; i <= tshirts.Count - 2; i++)
                {
                    if (tshirts[i].Fabric < tshirts[i + 1].Fabric)
                    {
                        temp = tshirts[i + 1];
                        tshirts[i + 1] = tshirts[i];
                        tshirts[i] = temp;
                    }

                    if (tshirts[i].Color < tshirts[i + 1].Color)
                    {
                        temp = tshirts[i + 1];
                        tshirts[i + 1] = tshirts[i];
                        tshirts[i] = temp;
                    }

                    if (tshirts[i].Size < tshirts[i + 1].Size)
                    {
                        temp = tshirts[i + 1];
                        tshirts[i + 1] = tshirts[i];
                        tshirts[i] = temp;
                    }
                }
            }
        }







    }
}

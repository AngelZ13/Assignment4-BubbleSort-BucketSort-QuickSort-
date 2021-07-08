using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4.SortingAlgorithms
{
    public class QuickSort
    {
        public static void OrderByColorAscending(List<TShirt> tshirts, int low, int high)
        {
            if (low < high)
            {
                int pi = PartitionAscending(tshirts, low, high);
                OrderByColorAscending(tshirts, low, pi - 1);
                OrderByColorAscending(tshirts, pi + 1, high);
            }
        }

        public static int PartitionAscending(List<TShirt> tshirts, int low, int high)
        {
            TShirt pivot = tshirts[high];
            int i = (low - 1);
            for (int j = low; j < high; j++)
            {
                if (tshirts[j].Color < pivot.Color)
                {
                    i++;
                    TShirt temp = tshirts[i];
                    tshirts[i] = tshirts[j];
                    tshirts[j] = temp;
                }
            }
            TShirt temp1 = tshirts[i + 1];
            tshirts[i + 1] = tshirts[high];
            tshirts[high] = temp1;
            return i + 1; ;
        }

        public static void OrderByColorDescending(List<TShirt> tshirts, int low, int high)
        {
            if (low < high)
            {
                int pi = PartitionDescending(tshirts, low, high);
                OrderByColorDescending(tshirts, low, pi - 1);
                OrderByColorDescending(tshirts, pi + 1, high);
            }
        }

        public static int PartitionDescending(List<TShirt> tshirts, int low, int high)
        {
            TShirt pivot = tshirts[high];
            int i = (low - 1);
            for (int j = low; j < high; j++)
            {
                if (tshirts[j].Color > pivot.Color)
                {
                    i++;
                    TShirt temp = tshirts[i];
                    tshirts[i] = tshirts[j];
                    tshirts[j] = temp;
                }
            }
            TShirt temp1 = tshirts[i + 1];
            tshirts[i + 1] = tshirts[high];
            tshirts[high] = temp1;
            return i + 1; ;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4.SortingAlgorithms
{
    public class BucketSort
    {
        public static void OrderByFabricAscending(List<TShirt> tshirts)
        {
            List<List<TShirt>> buckets = new List<List<TShirt>>();
            InitializeBuckets(buckets);

            Scatter(tshirts, buckets);

            int i = 0;
            foreach (List<TShirt> bucket in buckets)
            {
                foreach (TShirt d in bucket)
                {
                    tshirts[i++] = d;
                }
            }
        }

        public static void OrderByFabricDescending(List<TShirt> tshirts)
        {
            List<List<TShirt>> buckets = new List<List<TShirt>>();
            InitializeBuckets(buckets);

            ScatterDescending(tshirts, buckets);

            int i = 0;
            foreach (List<TShirt> bucket in buckets)
            {
                foreach (TShirt d in bucket)
                {
                    tshirts[i++] = d;
                }
            }
        }


        public static void Scatter(List<TShirt> tshirts, List<List<TShirt>> buckets)
        {
            foreach (TShirt tshirt in tshirts)
            {
                int bucketNumber = GetBucketNumber(tshirt);
                buckets[bucketNumber].Add(tshirt);
            }
        }

        public static void ScatterDescending(List<TShirt> tshirts, List<List<TShirt>> buckets)
        {
            int fabricLength = Enum.GetNames(typeof(Fabric)).Length;
            foreach (TShirt tshirt in tshirts)
            {
                int bucketNumber = GetBucketNumberDescending(tshirt, fabricLength);
                buckets[bucketNumber].Add(tshirt);
            }
        }

        public static int GetBucketNumber(TShirt tshirt)
        {
            int bucketNumber = (int)tshirt.Fabric;
            return bucketNumber;
        }

        public static int GetBucketNumberDescending(TShirt tshirt, int fabriclength)
        {
            int bucketNumber = fabriclength - ((int)tshirt.Fabric + 1);
            return bucketNumber;
        }

        public static void InitializeBuckets(List<List<TShirt>> buckets)
        {

            var size = Enum.GetNames(typeof(Fabric)).Length;

            for (int i = 0; i < size; i++)
            {
                List<TShirt> a = new List<TShirt>();
                buckets.Add(a);
            }
        }
    }
}

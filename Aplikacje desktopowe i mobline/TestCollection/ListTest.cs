using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCollection
{
    class ListTest
    {
        public void Test()
        {
            List<int>listOfInts = new List<int>();
            Console.WriteLine("jak długa jest lista" + listOfInts.Count);

            Random random = new Random();
            for( int i=0; i<10; i++)
            {
                listOfInts.Add(random.Next(0, 21));
            }

            Console.WriteLine("lisat wylosowwala liczby ");
            for (int i = 0; i < listOfInts.Count; i++)
            {
                Console.Write(listOfInts[i]+" ");
            }

            Console.WriteLine( " ");
            List<double> listOfdouble = new List<double>();
            for (int i = 0; i < 10; i++)
            {
                listOfdouble.Add(random.Next(0, 21));
            }
            for (int i = 0; i < 10; i++)
            {
                listOfdouble.Add(Math.Round(random.NextDouble() * 20, 2));
            }
            foreach (var item in listOfdouble)
            {
                Console.Write(item + "  ");
            }
            Console.WriteLine("maks " + MaxForInts(listOfInts)); 
            Console.WriteLine("maks " + MaxForAllTypes<int>(listOfInts)); //automatyczne szczytanie typu(nie trzeba podawac <int> bo lista juz sie domysli ze to int)
            Console.WriteLine("maks " + MaxForDouble(listOfdouble));  
            Console.WriteLine("maks " + MaxForAllTypes<double>(listOfdouble));
        }
        private int MaxForInts(List<int> list)
        {
            int max = list[0];
            foreach (var item in list)
            {
                if(item>max)
                {
                    max = item;
                }
                
            }
            return max;
        }
        private double MaxForDouble(List<double> list)
        {
            double max = list[0];
            foreach (var item in list)
            {
                if (item > max)
                {
                    max = item;
                }

            }
            return max;
        }
        private T MaxForAllTypes <T>  (List<T> list)
        {
            T max = list[0];
            foreach (T item in list)
            {
                if (item > max)
                {
                    max = item;
                }

            }
            return max;
        }
    }
}

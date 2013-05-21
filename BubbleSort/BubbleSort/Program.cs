using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BubbleSort
{
    public class Program
    {
        static void Main(string[] args)
        {
        }

        /// <summary>
        /// Method of bubble sort
        /// </summary>
        /// <typeparam name="T">type of array</typeparam>
        /// <param name="SizeOfArray">Size of array</param>
        /// <param name="Array">Array</param>
        /// <param name="comparer">Comparator</param>
        public static void BSort<T>(int SizeOfArray, ref T[] Array, Comparator<T> comparer)
        {
            int i,j;
            for (i = 0 ; i < SizeOfArray ; i++)
            for (j = SizeOfArray-1 ; j > i ; j--)
            if (comparer.Compare(Array[j], Array[j-1]))
            {
                T tmp = Array[j];
                Array[j]= Array[j-1];
                Array[j-1] = tmp;
            }
        }
    }
}

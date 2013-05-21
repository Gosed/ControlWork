using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BubbleSort
{
    public class Comparator<T>
    {
        /// <summary>
        /// Comparer
        /// </summary>
        /// <param name="first">first element</param>
        /// <param name="second">second element</param>
        /// <returns>true if first > second</returns>
        public bool Compare(T first, T second)
        {
            int num1 = first.GetHashCode();
            int num2 = second.GetHashCode();
            return num1 > num2;
        }
        
    }
}

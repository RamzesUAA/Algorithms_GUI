using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsBL.Algorithms
{
    public class LinearSearching
    {
        public int linearSearching(int[] array, int element, out int numberOfComparisons)
        {
            numberOfComparisons = 0;
            for (int i = 1; i < array.Length; ++i)
            {
                numberOfComparisons++;
                if (array[i] == element)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}

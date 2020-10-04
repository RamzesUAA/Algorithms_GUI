using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsBL.Algorithms
{
    public class SelectionSort : SortBase
    {
        public void selectionSort(double[] arr)
        {
            for (int i = 0; i < arr.Length - 1; ++i)
            {
                int min = i;
                for (int j = (i + 1); j < arr.Length; ++j)
                {
                    if (arr[min] < arr[j])
                    {
                        min = j;
                    }
                }
                Swap(ref arr[min], ref arr[i]);
            }
        }
    }
}

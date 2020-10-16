using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsBL.Algorithms
{
    public class ShellSort : SortBase
    {
        public void shellSort(double[] arr, ref string str) 
        {
            //відстань між елементами, які порівнюються
            var d = arr.Length / 2;
            while (d >= 1)
            {
                for (var i = d; i < arr.Length; i++)
                {
                    var j = i;
                    while ((j >= d) && (arr[j - d] > arr[j]))
                    {
                        Swap(ref arr[j], ref arr[j - d]);
                        j = j - d;
                    }
                }

                d = d / 2;
            }
        }
    }
}

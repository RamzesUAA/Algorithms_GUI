using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsBL.Algorithms
{
    public class BubbleSort : SortBase
    {
        public void bubbleSort(double[] arr, ref string steps)
        {
            steps = "";
            int size = arr.Length;
            int counter = 0;
            for (int i = 0; i < size; i++)
            {
                bool F = false;
                for (int j = 0; j < size - i - 1; j++)
                {
                    if (arr[j] < arr[j + 1])
                    {
                        
                        Swap(ref arr[j], ref arr[j + 1]);
                        F = true;
                    }
                    ++counter;
                    steps += $"Step {counter}: ";
                    foreach(var item in arr)
                    {
                        steps += $"{item}   ";
                    }
                    steps += "\n";
                }
                if (F == false) break;
            }
        }
        //--------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------
        public void bubbleSort(int[] arr)
        {
            
            int size = arr.Length;
            for (int i = 0; i < size; i++)
            {
                bool F = false;
                for (int j = 0; j < size - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {

                        Swap(ref arr[j], ref arr[j + 1]);
                        F = true;
                    }
                }
                if (F == false) break;
            }
        }
    }
}

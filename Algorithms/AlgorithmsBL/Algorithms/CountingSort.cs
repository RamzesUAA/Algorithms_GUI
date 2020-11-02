using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsBL.Algorithms
{
    public class CountingSort
    {
        public void countingSort(double[] array, ref string str)
        {
            double[] sortedArray = new double[array.Length];

            // find smallest and largest value
            double minVal = array[0];
            double maxVal = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < minVal) minVal = array[i];
                else if (array[i] > maxVal) maxVal = array[i];
            }

        
            // init array of frequencies
            int index = (int)((maxVal - minVal) * 10 + 1);
            int[] counts = new int[index];
            str += $"\nMax element {maxVal}";
            str += $"\nMin element {minVal}";

            // init the frequencies
            for (int i = 0; i < array.Length; i++)
            {
                int indexF = (int)(array[i]*10-minVal*10);
                counts[indexF]++;
            }

            // recalculate
            counts[0]--;
            for (int i = 1; i < counts.Length; i++)
            {
                counts[i] = counts[i] + counts[i - 1];
            }

            // Sort the array
            for (int i = array.Length - 1; i >= 0; i--)
            {
                int indexR = (int)(array[i] * 10 - minVal * 10);
                sortedArray[counts[indexR]--] = array[i];
            }
         
            str += $"\nSorted array :";
            int counter = 0;
            foreach (double aa in sortedArray)
            {
                array[counter] = aa;
                str += $"{aa} ";
                counter++;
            }
            str += "\n";
        }



        public void countingSort(int[] array)
        {
            int[] sortedArray = new int[array.Length];

            int minVal = array[0];
            int maxVal = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < minVal) minVal = array[i];
                else if (array[i] > maxVal) maxVal = array[i];
            }

            int index = (maxVal - minVal) + 1;
            int[] counts = new int[index];
        
            for (int i = 0; i < array.Length; i++)
            {
                int indexF = (array[i] - minVal);
                counts[indexF]++;
            }

            counts[0]--;
            for (int i = 1; i < counts.Length; i++)
            {
                counts[i] = counts[i] + counts[i - 1];
            }

            for (int i = array.Length - 1; i >= 0; i--)
            {
                int indexR = (array[i] - minVal);
                sortedArray[counts[indexR]--] = array[i];
            }

            int counter = 0;
            foreach (int aa in sortedArray)
            {
                array[counter] = aa;
                counter++;
            }
        }
    }
}

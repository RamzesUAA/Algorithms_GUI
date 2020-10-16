using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsBL.Algorithms
{
    public class MergeSort
    {
        int Rows;
        int Columns;
        public MergeSort(int x, int y)
        {
            Rows = x;
            Columns = y;
        }
        private double[][] Sort(double[][] items, int countColumns)
        {
            if (items.Length == 1)
            {
                return items;
            }

            var mid = countColumns / 2;


            double[][] left = new double[Rows][];
            for(int i = 0; i < mid; ++i)
            {
                for(int j = 0; j < Rows; ++j)
                {
                    left[j][i] = items[j][i];
                }
            }

            double[][] right = new double[Rows][];
            int k = 0;
            for (int i = mid; i < Columns; ++i)
            {
                for (int j = 0; j < Rows; ++j)
                {
                    right[j][k] = items[j][i];
                }
                k++;
            }
            return Merge(Sort(left, mid), Sort(right, mid));
        }

        private double[][] Merge(double[][] left, double[][] right)
        {
            var length = Columns;
            var leftPointer = 0;
            var rightPointer = 0;

            var result = new double[Rows][];
            int counter = 0;
            for (int i = 0; i < length; i++)
            {
                if (leftPointer < left.Length && rightPointer < right.Length)
                {
                    if (left[0][leftPointer] < right[0][rightPointer])
                    {
                        for(int q = 0; q  < Rows; ++q)
                        {
                            result[q][i] = left[q][i];
                        }
                        leftPointer++;
                    }
                    else
                    {
                        for (int q = 0; q < Rows; ++q)
                        {
                            result[q][i] = right[q][i];
                        }
                        rightPointer++;
                    }
                }
                //else
                //{
                //    if (rightPointer < right.Count)
                //    {
                //        result.Add(right[rightPointer]);
                //        rightPointer++;
                //    }
                //    else
                //    {
                //        result.Add(left[leftPointer]);
                //        leftPointer++;
                //    }
                //}
            }
            return result;
        }
    }
}

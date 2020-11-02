using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AlgorithmsBL.Algorithms
{
    public class MergeSort
    {

        public MergeSort()
        {
        }
       
        void MergeHalves(double[,] matr, int size, int left, int mid, int right)
        {

            int colCount1 = mid - left + 1;
            int colCount2 = right - mid;

            double[,] tmpMatr1 = new double[size,size];
            double[,] tmpMatr2 = new double[size,size];


            for (int q = 0; q < colCount1; ++q)
            {
                for (int z = 0; z < size; ++z)
                    tmpMatr1[z,q] = matr[z,left + q];
            }


            for (int q = 0; q < colCount2; ++q)
            {
                for (int z = 0; z < size; ++z)
                    tmpMatr2[z,q] = matr[z,mid + 1 + q];
            }

            int i = 0, j = 0, k = left;

            while (i < colCount1 && j < colCount2)
            {

                if (tmpMatr1[0,i] > tmpMatr2[0,j])
                {
                    for (int h = 0; h < size; ++h)
                        matr[h,k] = tmpMatr1[h,i];
                    ++i;
                }

                else
                {
                    for (int h = 0; h < size; ++h)
                        matr[h,k] = tmpMatr2[h,j];
                    ++j;
                }
                ++k;
            }

            while (i < colCount1)
            {
                for (int h = 0; h < size; ++h)
                    matr[h,k] = tmpMatr1[h,i];
                ++k;
                ++i;
            }

            while (j < colCount2)
            {
                for (int h = 0; h < size; ++h)
                    matr[h,k] = tmpMatr2[h,j];
                ++k;
                ++j;
            }
        }

        int counter = 0;
        public void mergeSort(double[,] matr, int size, int left, int right, ref string str)
        {
            if(left<right)
            {
                int mid = (left + right) / 2;
                mergeSort(matr, size, left, mid, ref str);
                mergeSort(matr, size, mid + 1, right, ref str);
                MergeHalves(matr, size, left, mid, right);
                str += $"Step : {counter}";
                str += "Array: \n";
                for (int i = 0; i < size; ++i)
                {
                    for (int j = 0; j < size; ++j)
                        str += $"{matr[i, j]}, ";
                    str += $"\n";
                }
                str += "\n";
                ++counter;
            }
        }


        //--------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------


        private void Merge(int[] input, int left, int middle, int right)
        {
            int[] leftArray = new int[middle - left + 1];
            int[] rightArray = new int[right - middle];

            Array.Copy(input, left, leftArray, 0, middle - left + 1);
            Array.Copy(input, middle + 1, rightArray, 0, right - middle);

            int i = 0;
            int j = 0;
            for (int k = left; k < right + 1; k++)
            {
                if (i == leftArray.Length)
                {
                    input[k] = rightArray[j];
                    j++;
                }
                else if (j == rightArray.Length)
                {
                    input[k] = leftArray[i];
                    i++;
                }
                else if (leftArray[i] <= rightArray[j])
                {
                    input[k] = leftArray[i];
                    i++;
                }
                else
                {
                    input[k] = rightArray[j];
                    j++;
                }
            }
        }

        public void mergeSort(int[] input, int left, int right, CancellationToken token)
        {
            if (token.IsCancellationRequested)
            {
                return;
            }
            if (left < right)
            {
                int middle = (left + right) / 2;

                mergeSort(input, left, middle, token);
                mergeSort(input, middle + 1, right, token);

                Merge(input, left, middle, right);
            }
        }

    }
}

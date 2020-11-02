using AlgorithmsBL.Algorithms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgorithmsUI
{
    public partial class ComparisonForm : Form
    {
        public ComparisonForm()
        {
            InitializeComponent();
        }
        List<int[]> list;
        int[] Array;
        Random random = new Random();
        
        private void RandomArray()
        {
            for(int i = 0; i < Array.Length; ++i)
            {
                Array[i] = random.Next(-100000, 100000);
            }
        }

        private void btn_RunComparing_Click(object sender, EventArgs e)
        {
            list = new List<int[]>();
            Array = new int[Convert.ToInt32(listBox_Demension.SelectedItem.ToString())];
            RandomArray();
            for (int i = 0; i < 6; ++i)
            {
                int[] temp = new int[Array.Length];
                for(int j = 0; j < Array.Length; ++j)
                {
                    temp[j] = Array[j];
                }
                list.Add(temp);
            }
            BubbleSort();
            SelectionSort();
            ShellSort();
            MergeSort();
            QuickSort();
            CoutingSort();
        }
        void PrintArray()
        {
            string str = "\nArray: ";
            foreach(var item in Array)
            {
                str += $"{item} ";
            }
            MessageBox.Show(str.ToString()); 
        }

        void BubbleSort()
        {
            BubbleSort bubbleSort = new BubbleSort();

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            bubbleSort.bubbleSort(list[0]);

            stopwatch.Stop();
            label_BubbleSortTime.Text = Math.Round(stopwatch.Elapsed.TotalSeconds, 5).ToString() + " sec.";
        }

        void SelectionSort()
        {
            SelectionSort selectionSort = new SelectionSort();

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            selectionSort.selectionSort(list[1]);

            stopwatch.Stop();
            label_SelectionSortTime.Text = Math.Round(stopwatch.Elapsed.TotalSeconds, 4).ToString() + " sec.";
        }

        void ShellSort()
        {
            ShellSort shellSort = new ShellSort();

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            shellSort.shellSort(list[2]);

            stopwatch.Stop();
            label_ShellSortTime.Text = Math.Round(stopwatch.Elapsed.TotalSeconds, 4).ToString() + " sec.";
        }

        void MergeSort()
        {
            MergeSort mergeSort = new MergeSort();

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            mergeSort.mergeSort(list[3], 0, list[3].Length -1);

            stopwatch.Stop();
            label_MergeSortTime.Text = Math.Round(stopwatch.Elapsed.TotalSeconds, 4).ToString() + " sec.";
        }
        void QuickSort()
        {
            QuickSort quickSort = new QuickSort();

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            quickSort.Quick_Sort(list[4], 0, list[4].Length - 1);

            stopwatch.Stop();
            label_QuickSortTime.Text = Math.Round(stopwatch.Elapsed.TotalSeconds, 4).ToString() + " sec.";
        }
        void CoutingSort()
        {
            CountingSort countingSort = new CountingSort();

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            countingSort.countingSort(list[5]);

            stopwatch.Stop();
            label_CountingSortTime.Text = Math.Round(stopwatch.Elapsed.TotalSeconds, 4).ToString() + " sec.";
        }
    }
}

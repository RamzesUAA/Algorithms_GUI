using AlgorithmsBL.Algorithms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

using System.Timers;

using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace AlgorithmsUI
{
    public partial class ComparisonForm : Form
    {

        public ComparisonForm()
        {
            InitializeComponent();
        }
        static List<int[]> list;
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
            BubbleSortAsync();
            SelectionSort();
            ShellSort();
            MergeSort();
            QuickSort();
            CoutingSort();
        }


        public void  BubbleSortAsync()
        {
            CancellationTokenSource cancelTokenSource =  new CancellationTokenSource(TimeSpan.FromSeconds(50));
            CancellationToken token = cancelTokenSource.Token;
            BubbleSort bubbleSort = new BubbleSort();

            Stopwatch stopwatch = new Stopwatch();
            
            Task task1 = new Task(() =>
            {
                stopwatch.Start();
                bubbleSort.bubbleSort(list[0], token);
                stopwatch.Stop();
                double time = Math.Round(stopwatch.Elapsed.TotalSeconds, 4);
                if (time < 49.99) 
                {
                    label_BubbleSortTime.Text = Math.Round(stopwatch.Elapsed.TotalSeconds, 4).ToString() + " sec.";
                }
                else 
                {
                    label_BubbleSortTime.Text = "> 50 sec.";
                }
            });
            task1.Start();            
        }

        void SelectionSort()
        {
            CancellationTokenSource cancelTokenSource = new CancellationTokenSource(TimeSpan.FromSeconds(50));
            CancellationToken token = cancelTokenSource.Token;
            SelectionSort selectionSort = new SelectionSort();
            Stopwatch stopwatch = new Stopwatch();

            Task task1 = new Task(() =>
            {
                stopwatch.Start();
                selectionSort.selectionSort(list[1], token);
                stopwatch.Stop();
                double time = Math.Round(stopwatch.Elapsed.TotalSeconds, 4);
                if (time < 49.99)
                {
                    label_SelectionSortTime.Text = Math.Round(stopwatch.Elapsed.TotalSeconds, 4).ToString() + " sec.";
                }
                else
                {
                    label_SelectionSortTime.Text = "> 50 sec.";
                }
            });
            task1.Start();
        }

        void ShellSort()
        {
            CancellationTokenSource cancelTokenSource = new CancellationTokenSource(TimeSpan.FromSeconds(50));
            CancellationToken token = cancelTokenSource.Token;
            ShellSort shellSort = new ShellSort();
            Stopwatch stopwatch = new Stopwatch();

            Task task1 = new Task(() =>
            {
                stopwatch.Start();
                shellSort.shellSort(list[2], token);
                stopwatch.Stop();
                double time = Math.Round(stopwatch.Elapsed.TotalSeconds, 4);
                if (time < 49.99)
                {
                    label_ShellSortTime.Text = Math.Round(stopwatch.Elapsed.TotalSeconds, 4).ToString() + " sec.";
                }
                else
                {
                    label_ShellSortTime.Text = "> 50 sec.";
                }
            });
            task1.Start();
        }
       
        void MergeSort()
        {
            CancellationTokenSource cancelTokenSource = new CancellationTokenSource(TimeSpan.FromSeconds(50));
            CancellationToken token = cancelTokenSource.Token;
            MergeSort mergeSort = new MergeSort();
            Stopwatch stopwatch = new Stopwatch();

            Task task1 = new Task(() =>
            {
                stopwatch.Start();
                mergeSort.mergeSort(list[3], 0, list[3].Length - 1, token);
                stopwatch.Stop();
                double time = Math.Round(stopwatch.Elapsed.TotalSeconds, 4);
                if (time < 49.99)
                {
                    label_MergeSortTime.Text = Math.Round(stopwatch.Elapsed.TotalSeconds, 4).ToString() + " sec.";
                }
                else
                {
                    label_MergeSortTime.Text = "> 50 sec.";
                }
            });
            task1.Start();
        }
        void QuickSort()
        {
            CancellationTokenSource cancelTokenSource = new CancellationTokenSource(TimeSpan.FromSeconds(50));
            CancellationToken token = cancelTokenSource.Token;
            QuickSort quickSort = new QuickSort();
            Stopwatch stopwatch = new Stopwatch();

            Task task1 = new Task(() =>
            {
                stopwatch.Start();
                quickSort.Quick_Sort(list[4], 0, list[4].Length - 1, token);
                stopwatch.Stop();
                double time = Math.Round(stopwatch.Elapsed.TotalSeconds, 4);
                if (time < 49.99)
                {
                    label_QuickSortTime.Text = Math.Round(stopwatch.Elapsed.TotalSeconds, 4).ToString() + " sec.";
                }
                else
                {
                    label_QuickSortTime.Text = "> 50 sec.";
                }
            });
            task1.Start();
        }
        void CoutingSort()
        {
            CancellationTokenSource cancelTokenSource = new CancellationTokenSource(TimeSpan.FromSeconds(50));
            CancellationToken token = cancelTokenSource.Token;
            CountingSort countingSort = new CountingSort();
            Stopwatch stopwatch = new Stopwatch();

            Task task1 = new Task(() =>
            {
                stopwatch.Start();
                countingSort.countingSort(list[5], token);
                stopwatch.Stop();
                double time = Math.Round(stopwatch.Elapsed.TotalSeconds, 4);
                if (time < 49.99)
                {
                    label_CountingSortTime.Text = Math.Round(stopwatch.Elapsed.TotalSeconds, 4).ToString() + " sec.";
                }
                else
                {
                    label_CountingSortTime.Text = "> 50 sec.";
                }
            });
            task1.Start();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using AlgorithmsBL;
using AlgorithmsBL.Algorithms;


namespace AlgorithmsUI
{
    public partial class Main : Form
    {

        ArrayItem ArrayItem;
        List<Product> Products;
        TwoDimensionalArrayItem DoubleDimArray;
        double[,] pairItem;
        string Steps = "";
        public Main()
        {
            ArrayItem = new ArrayItem();
            Products = new List<Product>();
            DoubleDimArray = new TwoDimensionalArrayItem();

            InitializeComponent();
        }

        void SetDataGridViewWithTwoDimensionsArray(DataGridView dataGridView)
        {
            if (DoubleDimArray.Array.Length == 0) return;
            var table = new DataTable();

            dataGridView.ColumnCount = (int)DoubleDimArray.Array.GetLength(1);

            for (int i = 0; i < DoubleDimArray.Array.GetLength(0); ++i)
            {
                dataGridView.Rows.Add();
            }

            for (int i = 0; i < DoubleDimArray.Array.GetLength(0); ++i)
            {
                for(int j = 0; j < DoubleDimArray.Array.GetLength(1); ++j)
                {
                    dataGridView.Rows[i].Cells[j].Value = DoubleDimArray.Array[i, j];
                }
            }
        }


        void SetDataGridViewWithArray(DataGridView dataGridView)
        {
            if (ArrayItem.Array.Length == 0) return;
            var dimension = ArrayItem.Array.Length;
            var swappedTable = new DataTable();

            for (int i = 0; i < dimension; ++i)
            {
                swappedTable.Columns.Add(Convert.ToString(i));
            }

            swappedTable.Rows.Add();
            swappedTable.Rows.Add();

            dataGridView.DataSource = swappedTable;
            dataGridView.Rows[0].HeaderCell.Value = "Index";
            dataGridView.Rows[1].HeaderCell.Value = "Value";
            dataGridView.ColumnHeadersVisible = false;
            dataGridView.RowHeadersWidth = 75;
            dataGridView.Rows[0].ReadOnly = true;
            for (int i = 0; i < dimension; ++i)
            {
                dataGridView.Rows[0].Cells[i].Value = i;
                dataGridView.Rows[1].Cells[i].Value = ArrayItem.Array[i];
                dataGridView.Columns[i].Width = 50;
            }
        }
       
        void SetDataGridViewWithString(DataGridView dataGridView)
        {
            if (Products.Count == 0) return;
            var dimension = Products.Count;
            var swappedTable = new DataTable();

            for (int i = 0; i < dimension; ++i)
            {
                swappedTable.Columns.Add(Convert.ToString(i));
            }
            swappedTable.Rows.Add();
            swappedTable.Rows.Add();

            dataGridView.DataSource = swappedTable;
            dataGridView.Rows[0].HeaderCell.Value = "Name";
            dataGridView.Rows[1].HeaderCell.Value = "Price";
            dataGridView.ColumnHeadersVisible = false;
            dataGridView.RowHeadersWidth = 75;
            dataGridView.Rows[0].ReadOnly = true;
            for (int i = 0; i < dimension; ++i)
            {
                dataGridView.Rows[0].Cells[i].Value = Products[i].Name;
                dataGridView.Rows[1].Cells[i].Value = Products[i].Price;
                dataGridView.Columns[i].Width = 50;
            }
        }

        private void InputArrayForFirsLab()
        {
            InputArrayFrom inputArrayFrom = new InputArrayFrom(ArrayItem);
            if (inputArrayFrom.ShowDialog() == DialogResult.OK)
            {
                SetDataGridViewWithArray(dataGridView_InitialArray);
                ArrayItem.DeleteMaxAndMin();
            }
        }

        private void InputArrayForSecondLab()
        {
            InputProductForm inputArrayFrom = new InputProductForm(Products);
            if (inputArrayFrom.ShowDialog() == DialogResult.OK)
            {
                SetDataGridViewWithString(dataGridView_InitialArray);
            }
        }

        private void InputArrayForThirdLab()
        {
            InputArrayFrom inputArrayFrom = new InputArrayFrom(ArrayItem);
            if (inputArrayFrom.ShowDialog() == DialogResult.OK)
            {
                ArrayItem.CinfigurateEvenNumbers();
                SetDataGridViewWithArray(dataGridView_InitialArray);
            }
        }

        private void InputArrayForFourthLab()
        {
            InputTwoDimensionalArrayForm inputArrayFrom = new InputTwoDimensionalArrayForm(DoubleDimArray);
            if (inputArrayFrom.ShowDialog() == DialogResult.OK)
            {
                SetDataGridViewWithTwoDimensionsArray(dataGridView_InitialArray);
            }
        }

        private void InputArrayForFifthLab()
        {
            InputArrayFrom inputArrayFrom = new InputArrayFrom(ArrayItem);
            if (inputArrayFrom.ShowDialog() == DialogResult.OK)
            {
                ArrayItem.DeleteMostFrequncyElement();
                SetDataGridViewWithArray(dataGridView_InitialArray);
            }
        }

        private void InputArrayForSixthLab()
        {
            InputArrayFrom inputIntArray = new InputArrayFrom(ArrayItem);
            if (inputIntArray.ShowDialog() == DialogResult.OK)
            {
                SetDataGridViewWithArray(dataGridView_InitialArray);
            }
        }   
        private void btn_EnterArray_Click(object sender, System.EventArgs e)
        {
            switch (comboBox_ChooseLab.SelectedItem.ToString())
            {
                case "laba1":
                    InputArrayForFirsLab();
                    break;
                case "laba2":
                    InputArrayForSecondLab();
                    break;
                case "laba3":
                    InputArrayForThirdLab();
                    break;
                case "laba4":
                    clearGridsAndArray();
                    InputArrayForFourthLab();
                    break;
                case "laba5":
                    clearGridsAndArray();
                    InputArrayForFifthLab();
                    break;
                case "laba6":
                    clearGridsAndArray();
                    InputArrayForSixthLab();
                    break;
                case null:
                    MessageBox.Show("Enter number of laba");
                    break;
            }
        }

        private void button_Steps_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Steps);
        }

        private void btn_SelectionSort_Click(object sender, EventArgs e)
        {
            SelectionSort selection = new SelectionSort();
            Stopwatch stopwatch = new Stopwatch();

            double averagePrice = Products.Sum(p => p.Price) / Products.Count;
            List<Product> lessAverage = new List<Product>();
            lessAverage = Products.Where(p => p.Price < averagePrice).ToList();

            List<Product> moreAverage = new List<Product>();
            moreAverage = Products.Where(p => p.Price >= averagePrice).ToList();

            Products.Clear();

            stopwatch.Start();
            selection.selectionSort(lessAverage, ref Steps);
            stopwatch.Stop();

            Products.AddRange(lessAverage);
            Products.AddRange(moreAverage);

            label_Time.Text = Math.Round(stopwatch.Elapsed.TotalSeconds, 5).ToString() + " sec.";
            SetDataGridViewWithString(dataGridView_ResultArray);
        }

        private void btn_BubbleSort_Click(object sender, EventArgs e)
        {
            BubbleSort bubble = new BubbleSort();
            Stopwatch stopwatch = new Stopwatch();

            // Begin timing
            stopwatch.Start();
            bubble.bubbleSort(ArrayItem.Array, ref Steps);

            // Stop timing
            stopwatch.Stop();

            // Write result
            label_Time.Text = Math.Round(stopwatch.Elapsed.TotalSeconds, 5).ToString() + " sec.";
            SetDataGridViewWithArray(dataGridView_ResultArray);
        }

        private void btn_ShellSort_Click(object sender, EventArgs e)
        {
            ShellSort bubble = new ShellSort();
            Stopwatch stopwatch = new Stopwatch();

            // Begin timing
            stopwatch.Start();
            bubble.shellSort(ArrayItem.Array, ref Steps);

            // Stop timing
            stopwatch.Stop();

            // Write result
            label_Time.Text = Math.Round(stopwatch.Elapsed.TotalSeconds, 5).ToString() + " sec.";
            SetDataGridViewWithArray(dataGridView_ResultArray);
        }

        void clearGridsAndArray()
        {
            dataGridView_InitialArray.Columns.Clear();
            dataGridView_InitialArray.Refresh();

            dataGridView_ResultArray.Columns.Clear();
            dataGridView_ResultArray.Refresh();
        }


        private void comboBox_ChooseLab_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (comboBox_ChooseLab.SelectedItem.ToString())
            {
                case "laba1":
                    btn_BubbleSort.Enabled = true;
                    btn_SelectionSort.Enabled = false;
                    btn_ShellSort.Enabled = true;
                    btn_MergeSort.Enabled = false;
                    btn_QuickSort.Enabled = false;
                    btn_CountingSort.Enabled = false;
                    clearGridsAndArray();
                    break;
                case "laba2":
                    btn_BubbleSort.Enabled = false;
                    btn_SelectionSort.Enabled = true;
                    btn_ShellSort.Enabled = false;
                    btn_MergeSort.Enabled = false;
                    btn_QuickSort.Enabled = false;
                    btn_CountingSort.Enabled = false;
                    break;
                case "laba3":
                    btn_BubbleSort.Enabled = true;
                    btn_SelectionSort.Enabled = false;
                    btn_ShellSort.Enabled = true;
                    btn_MergeSort.Enabled = false;
                    btn_QuickSort.Enabled = false;
                    btn_CountingSort.Enabled = false;
                    clearGridsAndArray();
                    break;
                case "laba4":
                    btn_BubbleSort.Enabled = false;
                    btn_SelectionSort.Enabled = false;
                    btn_ShellSort.Enabled = false;
                    btn_MergeSort.Enabled = true;
                    btn_QuickSort.Enabled = false;
                    btn_CountingSort.Enabled = false;
                    clearGridsAndArray();
                    break;
                case "laba5":
                    btn_BubbleSort.Enabled = false;
                    btn_SelectionSort.Enabled = false;
                    btn_ShellSort.Enabled = false;
                    btn_MergeSort.Enabled = false;
                    btn_QuickSort.Enabled = true;
                    btn_CountingSort.Enabled = false;
                    clearGridsAndArray();
                    break;
                case "laba6":
                    btn_BubbleSort.Enabled = false;
                    btn_SelectionSort.Enabled = false;
                    btn_ShellSort.Enabled = false;
                    btn_MergeSort.Enabled = false;
                    btn_QuickSort.Enabled = false;
                    btn_CountingSort.Enabled = true;
                    clearGridsAndArray();
                    break;
                case null:
                    break;
            }
        }

        private void btn_MergeSort_Click(object sender, EventArgs e)
        {

            MergeSort merge = new MergeSort();
            Stopwatch stopwatch = new Stopwatch();

            // Begin timing
            stopwatch.Start();
            merge.mergeSort(DoubleDimArray.Array, DoubleDimArray.SIZE, 0, DoubleDimArray.SIZE - 1, ref Steps);
           // merge.StartMergeSort(DoubleDimArray.Array, DoubleDimArray.SIZE, 0, DoubleDimArray.SIZE - 1, ref Steps);

            // Stop timing
            stopwatch.Stop();

            // Write result
            label_Time.Text = Math.Round(stopwatch.Elapsed.TotalSeconds, 4).ToString() + " sec.";
            SetDataGridViewWithTwoDimensionsArray(dataGridView_ResultArray);
        }

        private void btn_QuickSort_Click(object sender, EventArgs e)
        {
            QuickSort quickSort = new QuickSort();
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            quickSort.Quick_Sort(ArrayItem.Array, 0, ArrayItem.Array.Length - 1);
            stopwatch.Stop();
            label_Time.Text = Math.Round(stopwatch.Elapsed.TotalSeconds, 4).ToString() + " sec.";
            SetDataGridViewWithArray(dataGridView_ResultArray);

        }

        private void btn_CountingSort_Click(object sender, EventArgs e)
        {
            CountingSort countingSort = new CountingSort();
            Stopwatch stopwatch = new Stopwatch();
            Steps = "";
            stopwatch.Start();
            Steps += "Before modifing(sin): ";
            foreach(var item in ArrayItem.Array)
            {
                Steps += $"{item} ";
            }
            
            ArrayItem.SetSinToNegativeDigits();

            Steps += "\nAfter modifing(sin): ";
            foreach (var item in ArrayItem.Array)
            {
                Steps += $"{item} ";
            }
            countingSort.countingSort(ArrayItem.Array, ref Steps);
            stopwatch.Stop();
            label_Time.Text = Math.Round(stopwatch.Elapsed.TotalSeconds, 4).ToString() + " sec.";
            SetDataGridViewWithArray(dataGridView_ResultArray);
        }

        private void btn_ComparingMode_Click(object sender, EventArgs e)
        {
            ComparisonForm comparisonForm = new ComparisonForm();
            comparisonForm.ShowDialog();
        }
    }
}

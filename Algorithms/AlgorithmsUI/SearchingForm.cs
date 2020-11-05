using AlgorithmsBL;
using AlgorithmsBL.Algorithms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgorithmsUI
{
    public partial class SearchingForm : Form
    {
        int[] Array;
        Books Books;
        Random Random = new Random();
        public SearchingForm()
        {
            InitializeComponent();
        }
        
        private void button_FindAccordingToTask_Click(object sender, EventArgs e)
        {
            LinearSearching LinearSearching = new LinearSearching();
            int min= Array[1];
            for(int i = 2; i < Array.Length; ++i)
            {
                if (min > Array[i])
                    min = Array[i];
            }
            min *= min;
            int numberOfComparisons;
            int position = LinearSearching.linearSearching(Array, min, out numberOfComparisons);
            label_NumberOfElements.Text = (Array.Length - 1).ToString();
            if (position != -1)
            {
                label_PositionInArray.Text = position.ToString();
            }
            else
            {
                label_PositionInArray.Text = "none";
            }
            label_NumberOfComparisons.Text = numberOfComparisons.ToString();

        }
        private void InitializeArray(int dimension)
        {
            Array = new int[dimension + 1];
            for(int i = 1; i < Array.Length; ++i)
            {
                Array[i] = Random.Next(1, dimension);
            }
        }


        private void button_FindEnteredNumber_Click(object sender, EventArgs e)
        {
            LinearSearching LinearSearching = new LinearSearching();
            int element = (int)numericUpDown_NumberToFind.Value;
            int numberOfComparisons = 0;
            int position = LinearSearching.linearSearching(Array, element, out numberOfComparisons);
            label_NumberOfElements.Text = (Array.Length - 1).ToString();
            if(position != -1)
            { 
                label_PositionInArray.Text = position.ToString();
            }
            else{
                label_PositionInArray.Text = "none";
            }
            label_NumberOfComparisons.Text = numberOfComparisons.ToString();
        }
        private void button_GenerateTenDimensionArray_Click(object sender, EventArgs e)
        {
            InitializeArray(10);
            PopulateDataGridView(10, Array);

        }

        private void button_GenerateTwentyDimensionArray_Click(object sender, EventArgs e)
        {
            InitializeArray(20);
            PopulateDataGridView(20, Array);
        }

        private void button_GenerateTwoHundredDimensionArray_Click(object sender, EventArgs e)
        {
            InitializeArray(200);
            PopulateDataGridView(200, Array);
        }

        private void button_GenerateTwoThousandDimensionArray_Click(object sender, EventArgs e)
        {
            InitializeArray(2000);
            PopulateDataGridView(2000, Array);
        }

        private void button_GenerateTwentyThousandDimensionArray_Click(object sender, EventArgs e)
        {
            InitializeArray(20000);
            PopulateDataGridView(20000, Array);
        }

        private void SetupDataGridView<T>(T className)
        {
            dataGridView_TestGrid.ColumnCount = 2;
            dataGridView_TestGrid.Columns[0].Width = 60;
            dataGridView_TestGrid.Columns[1].Width = 60;
            dataGridView_TestGrid.AllowUserToAddRows = false;
            dataGridView_TestGrid.ReadOnly = true;
            dataGridView_TestGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dataGridView_TestGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView_TestGrid.ColumnHeadersDefaultCellStyle.Font =
                new Font(dataGridView_TestGrid.Font, FontStyle.Bold);

            

            dataGridView_TestGrid.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dataGridView_TestGrid.GridColor = Color.Black;
            dataGridView_TestGrid.RowHeadersVisible = false;

            if(typeof(T) == typeof(int[]))
            {
                dataGridView_TestGrid.Name = "ArrayGrid";
                dataGridView_TestGrid.Columns[0].Name = "Index";
                dataGridView_TestGrid.Columns[1].Name = "Number";
            }else if(typeof(T) == typeof(Books))
            {
                dataGridView_TestGrid.Name = "BookGrid";
                dataGridView_TestGrid.Columns[0].Name = "Price";
                dataGridView_TestGrid.Columns[1].Name = "Name";
            }
           

            dataGridView_TestGrid.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            dataGridView_TestGrid.MultiSelect = false;
        }

        private void PopulateDataGridView<T>(int number, T someClass)
        {
            clearGridsAndArray();
            SetupDataGridView(someClass);
            string[] row0;
            if(typeof(T) == typeof(int[]))
            {
                for (int i = 0; i < number; ++i)
                {
                    row0 = new string[] { (i + 1).ToString(), Array[i + 1].ToString() };
                    dataGridView_TestGrid.Rows.Add(row0);
                }
            }else if(typeof(T) == typeof(Books))
            {
                for (int i = 20; i < number+20; ++i)
                {
                    row0 = new string[] { Books[i].Price.ToString(), Books[i].Name.ToString() };
                    dataGridView_TestGrid.Rows.Add(row0);
                }
            }
            
        }

        void clearGridsAndArray()
        {
            dataGridView_TestGrid.Columns.Clear();
            dataGridView_TestGrid.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button_GenerateArrayWithTenBinnary_Click(object sender, EventArgs e)
        {
            Books = new Books(10);
            PopulateDataGridView(10, Books);
        }

        private void button_GenerateArrayWithForthyBinnary_Click(object sender, EventArgs e)
        {
            Books = new Books(40);
            PopulateDataGridView(40, Books);
        }

        private void button_GenerateArrayWithSeventyBinnary_Click(object sender, EventArgs e)
        {
            Books = new Books(70);
            PopulateDataGridView(70, Books);
        }

        private void button_GenerateArrayWithOneHundredBinnary_Click(object sender, EventArgs e)
        {
            Books = new Books(100);
            PopulateDataGridView(100, Books);
        }

        private void button_Click(object sender, EventArgs e)
        {
            BinnarySearch binnary = new BinnarySearch();
            int priceToFind = (int)numericUpDown_PriceToFind.Value;
            int numberOfComparisons = 0;
            int position = binnary.binnarySearch(Books, priceToFind, out numberOfComparisons);
            label_NumberOfBooks.Text = (Books.GetHashCode()).ToString();
            if (position != -1)
            {
                label_NameOfFoundBook.Text = Books[position].Name.ToString();
                label_PriceOfTheFoundBook.Text = priceToFind.ToString();
            }
            else
            {
                label_NameOfFoundBook.Text = "none";
            }
            label_NumberOfBookComparisons.Text = numberOfComparisons.ToString();
            
        }
    }
}

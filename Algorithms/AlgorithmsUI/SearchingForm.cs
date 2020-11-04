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
            MessageBox.Show(min.ToString());
            int numberOfComparisons;
            int position = LinearSearching.linearSearching(Array, min, out numberOfComparisons);
            label_NumberOfElements.Text = (Array.Length - 1).ToString();
            label_PositionInArray.Text = position.ToString();
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

        //private void InitializeDataGrid1(int dimension)
        //{
        //    DataTable dt01 = new DataTable("dt01");
        //    for (int i = 0; i < dimension; i++)
        //    {

        //        dt01.Columns.Add(Convert.ToString(i));
        //    }


        //    dt01.Rows.Add();
        //    dt01.Rows.Add();
        //    dataGridView_Array.DataSource = dt01;
        //    dataGridView_Array.AutoGenerateColumns = false;
       

        //    for (int i = 0; i < dimension; ++i)
        //    {
        //        DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
        //        column.Name = dt01.Columns[i].ColumnName;
         
        //        column.DataPropertyName = dt01.Columns[i].ColumnName;
        //        column.HeaderText = dt01.Columns[i].ColumnName;
        //        column.FillWeight = 25;
        //        dataGridView_Array.Columns[i].Width = 50;
        //        dataGridView_Array.Rows[0].Cells[i].Value =i+1;
        //        dataGridView_Array.Rows[1].Cells[i].Value = Array[i + 1];
        //        dataGridView_Array.Columns.Add(column);
        //    }
        //}


        //private void InitializeDataGrid(int dimension)
        //{

        //    var swappedTable = new DataTable();

        //    for (int i = 0; i < dimension; ++i)
        //    {
        //        swappedTable.Columns.Add(Convert.ToString(i));
        //    }

        //    swappedTable.Rows.Add();
        //    swappedTable.Rows.Add();

        //    dataGridView_Array.DataSource = swappedTable;
        //    dataGridView_Array.Rows[0].HeaderCell.Value = "Index";
        //    dataGridView_Array.Rows[1].HeaderCell.Value = "Value";
        //    dataGridView_Array.ColumnHeadersVisible = false;
        //    dataGridView_Array.RowHeadersWidth = 10;
        //    dataGridView_Array.Rows[0].ReadOnly = true;
        //    dataGridView_Array.Rows[1].ReadOnly = true;
        //    for (int i = 0; i < dimension; ++i)
        //    {
        //        dataGridView_Array.Columns[i].FillWeight = 25;
        //        dataGridView_Array.Rows[0].Cells[i].Value = i+1;
        //        dataGridView_Array.Rows[1].Cells[i].Value = Array[i+1];
        //        dataGridView_Array.Columns[i].Width = 50;
        //    }
        //}

        //private void InitialInitializing()
        //{

        //    var swappedTable = new DataTable();

        //    for (int i = 0; i < 2; ++i)
        //    {
        //        swappedTable.Columns.Add(Convert.ToString(i));
        //    }

        //    swappedTable.Rows.Add();
        //    swappedTable.Rows.Add();

        //    dataGridView_Array.DataSource = swappedTable;
        //    dataGridView_Array.Rows[0].HeaderCell.Value = "Index";
        //    dataGridView_Array.Rows[1].HeaderCell.Value = "Value";
        //    dataGridView_Array.ColumnHeadersVisible = false;
        //    dataGridView_Array.RowHeadersWidth = 10;
        //    dataGridView_Array.Rows[0].ReadOnly = true;
        //    dataGridView_Array.Rows[1].ReadOnly = true;
        //    for (int i = 0; i < 2; ++i)
        //    {
        //        dataGridView_Array.Columns[i].FillWeight = 25;
        //        dataGridView_Array.Rows[0].Cells[i].Value = i + 1;
        //        dataGridView_Array.Rows[1].Cells[i].Value = Array[i + 1];
        //        dataGridView_Array.Columns[i].Width = 50;
        //    }
        //}


        private void button_FindEnteredNumber_Click(object sender, EventArgs e)
        {
            LinearSearching LinearSearching = new LinearSearching();
            int element = (int)numericUpDown_NumberToFind.Value;
            int numberOfComparisons = 0;
            int position = LinearSearching.linearSearching(Array, element, out numberOfComparisons);
            label_NumberOfElements.Text = (Array.Length - 1).ToString();
            label_PositionInArray.Text = position.ToString();
            label_NumberOfComparisons.Text = numberOfComparisons.ToString();
        }
        private void button_GenerateTenDimensionArray_Click(object sender, EventArgs e)
        {
            InitializeArray(10);
            clearGridsAndArray();
            PopulateDataGridView(10);

        }

        private void button_GenerateTwentyDimensionArray_Click(object sender, EventArgs e)
        {
            InitializeArray(20);
            clearGridsAndArray();
            PopulateDataGridView(20);
        }

        private void button_GenerateTwoHundredDimensionArray_Click(object sender, EventArgs e)
        {
            InitializeArray(200);
            clearGridsAndArray();
            PopulateDataGridView(200);
        }

        private void button_GenerateTwoThousandDimensionArray_Click(object sender, EventArgs e)
        {
            InitializeArray(2000);
            clearGridsAndArray();
            PopulateDataGridView(2000);
        }

        private void button_GenerateTwentyThousandDimensionArray_Click(object sender, EventArgs e)
        {
            InitializeArray(20000);
            clearGridsAndArray();
            PopulateDataGridView(20000);
        }

        private void SetupDataGridView()
        {
           // this.Controls.Add(dataGridView_TestGrid);

            dataGridView_TestGrid.ColumnCount = 2;
            dataGridView_TestGrid.Columns[0].Width = 60;
            dataGridView_TestGrid.Columns[1].Width = 60;
            dataGridView_TestGrid.AllowUserToAddRows = false;
            dataGridView_TestGrid.ReadOnly = true;
            dataGridView_TestGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dataGridView_TestGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView_TestGrid.ColumnHeadersDefaultCellStyle.Font =
                new Font(dataGridView_TestGrid.Font, FontStyle.Bold);

            dataGridView_TestGrid.Name = "ArrayGrid";

            dataGridView_TestGrid.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dataGridView_TestGrid.GridColor = Color.Black;
            dataGridView_TestGrid.RowHeadersVisible = false;

            dataGridView_TestGrid.Columns[0].Name = "Index";
            dataGridView_TestGrid.Columns[1].Name = "Number";

            dataGridView_TestGrid.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            dataGridView_TestGrid.MultiSelect = false;
        }

        private void PopulateDataGridView(int number)
        {
            SetupDataGridView();
            string[] row0;

            for(int i = 0; i < number; ++i)
            {
                row0 = new string[] { (i+1).ToString(), Array[i+1].ToString() };
                dataGridView_TestGrid.Rows.Add(row0);
            }
        }

        void clearGridsAndArray()
        {
            dataGridView_TestGrid.Columns.Clear();
            dataGridView_TestGrid.Refresh();
        }

    }
}

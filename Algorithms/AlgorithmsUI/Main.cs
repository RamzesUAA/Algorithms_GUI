using System;
using System.Data;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;
using AlgorithmsBL;
using AlgorithmsBL.Algorithms;

namespace AlgorithmsUI
{
    public partial class Main : Form
    {

        ArrayItem ArrayItem;
        string Steps = "";
        public Main()
        {
            ArrayItem = new ArrayItem();
            InitializeComponent();
            
        }
        void SetDataGridView(DataGridView dataGridView)
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


        private void btn_EnterArray_Click(object sender, System.EventArgs e)
        {
            InputArrayFrom inputArrayFrom = new InputArrayFrom(ArrayItem);
            if (inputArrayFrom.ShowDialog() == DialogResult.OK)
            {
                SetDataGridView(dataGridView_InitialArray);
                ArrayItem.DeleteMaxAndMin();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BubbleSort bubble = new BubbleSort();


            Stopwatch stopwatch = new Stopwatch();
            

            // Begin timing
            stopwatch.Start();
            bubble.bubbleSort(ArrayItem.Array, ref Steps);

            // Stop timing
            stopwatch.Stop();

            // Write result
            double s = 22.44;
            label_Time.Text = Math.Round(stopwatch.Elapsed.TotalSeconds, 5).ToString() + " sec.";

            

            SetDataGridView(dataGridView_ResultArray);

        }

        private void button_Steps_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Steps);
        }
    }
}

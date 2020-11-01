using AlgorithmsBL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgorithmsUI
{
    public partial class InputIntArray : Form
    {

        ArrayItem Array;
        public InputIntArray()
        {
            InitializeComponent();
        }
        public InputIntArray(ArrayItem array):this()
        {
            Array = array;
        }


        void SetDataGridView(int n)
        {
            if (n == 0) return;
            var dimension = n;
            var swappedTable = new DataTable();

            for (int i = 0; i < dimension; ++i)
            {
                swappedTable.Columns.Add(Convert.ToString(i));
            }

            swappedTable.Rows.Add();
            swappedTable.Rows.Add();

            dataGridView_Array.DataSource = swappedTable;
            dataGridView_Array.Rows[0].HeaderCell.Value = "Index";
            dataGridView_Array.Rows[1].HeaderCell.Value = "Value";
            dataGridView_Array.ColumnHeadersVisible = false;
            dataGridView_Array.RowHeadersWidth = 75;
            dataGridView_Array.Rows[0].ReadOnly = true;
            for (int i = 0; i < dimension; ++i)
            {
                dataGridView_Array.Rows[0].Cells[i].Value = i;
                dataGridView_Array.Columns[i].Width = 50;
            }
        }
        private void btn_Ok_Click(object sender, EventArgs e)
        {
            //for (int i = 0; i < Array.IntArray.Length; ++i)
            //{
            //    Array.IntArray[i] = double.Parse(dataGridView_Array.Rows[1].Cells[i].Value.ToString());
            //}

            //DialogResult = DialogResult.OK;
        }

        private void btn_SubmitDimension_Click(object sender, EventArgs e)
        {
            //SetDataGridView((int)numericUpDown_Dimension.Value);
            //Array.IntArray = new double[(int)numericUpDown_Dimension.Value];
        }
    }
}

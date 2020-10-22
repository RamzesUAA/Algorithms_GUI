using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AlgorithmsBL;

namespace AlgorithmsUI
{
    public partial class InputTwoDimensionalArrayForm : Form
    {
        TwoDimensionalArrayItem TwoDimensionalArray;
        DataTable dataTable;
        public InputTwoDimensionalArrayForm()
        {
            InitializeComponent();
        }
        public InputTwoDimensionalArrayForm(TwoDimensionalArrayItem array):this()
        {
            TwoDimensionalArray = array;
            dataGridView_TwoDimArray.ColumnCount = 1;
            dataGridView_TwoDimArray.Rows.Add();
            dataGridView_TwoDimArray.Columns[0].HeaderCell.Value = Convert.ToString(0);
            dataGridView_TwoDimArray.Rows[0].HeaderCell.Value = Convert.ToString(0);
            dataGridView_TwoDimArray.RowHeadersWidth = 75;
            dataGridView_TwoDimArray.Columns[0].Width = 50;
        }

        private void numericUpDown_Columns_ValueChanged(object sender, EventArgs e)
        {
            dataGridView_TwoDimArray.ColumnCount = (int)numericUpDown_Columns.Value;
         

            for(int i = 0; i < (int)numericUpDown_Columns.Value; ++i)
            {
                dataGridView_TwoDimArray.Columns[i].HeaderCell.Value = Convert.ToString(i);
                dataGridView_TwoDimArray.Columns[i].Width = 50;
            }
        }

        private void numericUpDown_Rows_ValueChanged(object sender, EventArgs e)
        {
            dataGridView_TwoDimArray.Rows.Clear();
            for (int i = 0; i < (int)numericUpDown_Rows.Value; ++i)
            {
                dataGridView_TwoDimArray.Rows.Add();
                dataGridView_TwoDimArray.Rows[i].HeaderCell.Value = Convert.ToString(i);
            }
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            TwoDimensionalArray.Array = new double[dataGridView_TwoDimArray.Rows.Count, dataGridView_TwoDimArray.Columns.Count];

            for(int i = 0; i < dataGridView_TwoDimArray.Rows.Count; ++i)
            {
                for(int j = 0; j < dataGridView_TwoDimArray.Columns.Count; ++j)
                {
                    TwoDimensionalArray.Array[i, j] = Convert.ToDouble(dataGridView_TwoDimArray.Rows[i].Cells[j].Value);
                }
            }
            DialogResult = DialogResult.OK;
        }
    }
}

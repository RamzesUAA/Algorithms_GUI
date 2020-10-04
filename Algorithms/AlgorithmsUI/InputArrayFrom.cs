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
    public partial class InputArrayFrom : Form
    {
        ArrayItem ArrayItem;
        public InputArrayFrom()
        {
            InitializeComponent();
        }
        public InputArrayFrom(ArrayItem arrayItem):this()
        {
            ArrayItem = arrayItem;
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

        private void btn_SubmitDimension_Click(object sender, EventArgs e)
        {
            SetDataGridView((int)numericUpDown_Dimension.Value);
            ArrayItem.Array = new double[(int)numericUpDown_Dimension.Value];
           
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < ArrayItem.Array.Length; ++i)
                {
                    ArrayItem.Array[i] = double.Parse(dataGridView_Array.Rows[1].Cells[i].Value.ToString());
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Unable to convert. ");
                return;
            }

            DialogResult = DialogResult.OK;

        }
    }
}

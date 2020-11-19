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
    public partial class StringSerachingAlgorithms : Form
    {
        public StringSerachingAlgorithms()
        {
            InitializeComponent();
        }

        private void button_DirectStringSearch_Click(object sender, EventArgs e)
        {
            this.Hide();
            DirectStringSearchForm stringSearchingForm = new DirectStringSearchForm();
            stringSearchingForm.Closed += (s, args) => this.Close();
            stringSearchingForm.Show();
        }

        private void button_Knuth_MorrisAndPratt_Click(object sender, EventArgs e)
        {

        }

        private void button_Boyer_Moore_Click(object sender, EventArgs e)
        {
           
        }
    }
}

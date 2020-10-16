using AlgorithmsBL;
using AlgorithmsUI.Extensions;
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
    public partial class EditForm : Form
    {
        Product Product;
        public EditForm()
        {
            InitializeComponent();
        }
        public EditForm(Product product) : this()
        {
            Product = product;
            textBox_Name.Text = product.Name;
           numericUpDown_Price.Value = new decimal((double)product.Price);

        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            if (textBox_Name.Text.IsDigitsOnly())
            {
                MessageBox.Show("Name field cannot contain digit(s)");
                return;
            }
            Product.Name = textBox_Name.Text;
            Product.Price = (double)numericUpDown_Price.Value;
            this.Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

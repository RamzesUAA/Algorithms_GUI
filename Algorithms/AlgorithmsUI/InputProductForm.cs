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
    public partial class InputProductForm : Form
    {
        List<Product> Products;
        public InputProductForm()
        {
            InitializeComponent();
        }
        public InputProductForm(List<Product> products):this()
        {
            products.Clear();
            Products = products;
        }
        private void ClearInputFields()
        {
            textBox_NameInput.Clear();
            numericUpDown_PriceInput.Value = 0;
        }
        private void btn_SubmitProduct_Click(object sender, EventArgs e)
        {
           
            if (textBox_NameInput.Text.IsDigitsOnly())
            {
                MessageBox.Show("Name field cannot contain digit(s)");
                return;
            }
            Product product = new Product()
            {
                Name = textBox_NameInput.Text,
                Price = (double)numericUpDown_PriceInput.Value
            };
            Products.Add(product);
            AddProductToListBox(product);
            ClearInputFields();
        }

        private void AddProductToListBox(Product product)
        {
            listBox_ProductsList.Items.Add(product);
        }
        private void UpdateListBox()
        {
            listBox_ProductsList.Items.Clear();
            foreach(var item in Products)
            {
                listBox_ProductsList.Items.Add(item);
            }
        }
        
        private void btn_Edit_Click(object sender, EventArgs e)
        {
            string str = listBox_ProductsList.SelectedItem.ToString().Split(' ').First();
            Product product = Products.First(p => p.Name.Equals(str));
            EditForm editForm = new EditForm(product);
            editForm.ShowDialog();
            UpdateListBox();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            string str = listBox_ProductsList.SelectedItem.ToString().Split(' ').First();
            Product product = Products.First(p => p.Name.Equals(str));
            Products.Remove(product);
            UpdateListBox();
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}

namespace AlgorithmsUI
{
    partial class InputProductForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_SubmitProduct = new System.Windows.Forms.Button();
            this.numericUpDown_PriceInput = new System.Windows.Forms.NumericUpDown();
            this.btn_Ok = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox_NameInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox_ProductsList = new System.Windows.Forms.ListBox();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_PriceInput)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_SubmitProduct
            // 
            this.btn_SubmitProduct.Location = new System.Drawing.Point(82, 99);
            this.btn_SubmitProduct.Name = "btn_SubmitProduct";
            this.btn_SubmitProduct.Size = new System.Drawing.Size(75, 23);
            this.btn_SubmitProduct.TabIndex = 10;
            this.btn_SubmitProduct.Text = "Submit";
            this.btn_SubmitProduct.UseVisualStyleBackColor = true;
            this.btn_SubmitProduct.Click += new System.EventHandler(this.btn_SubmitProduct_Click);
            // 
            // numericUpDown_PriceInput
            // 
            this.numericUpDown_PriceInput.DecimalPlaces = 2;
            this.numericUpDown_PriceInput.Location = new System.Drawing.Point(82, 73);
            this.numericUpDown_PriceInput.Name = "numericUpDown_PriceInput";
            this.numericUpDown_PriceInput.Size = new System.Drawing.Size(100, 20);
            this.numericUpDown_PriceInput.TabIndex = 9;
            // 
            // btn_Ok
            // 
            this.btn_Ok.Location = new System.Drawing.Point(415, 238);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(75, 23);
            this.btn_Ok.TabIndex = 8;
            this.btn_Ok.Text = "OK";
            this.btn_Ok.UseVisualStyleBackColor = true;
            this.btn_Ok.Click += new System.EventHandler(this.btn_Ok_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Products List";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.numericUpDown_PriceInput);
            this.panel1.Controls.Add(this.textBox_NameInput);
            this.panel1.Controls.Add(this.btn_SubmitProduct);
            this.panel1.Location = new System.Drawing.Point(260, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(228, 129);
            this.panel1.TabIndex = 11;
            // 
            // textBox_NameInput
            // 
            this.textBox_NameInput.Location = new System.Drawing.Point(82, 42);
            this.textBox_NameInput.Name = "textBox_NameInput";
            this.textBox_NameInput.Size = new System.Drawing.Size(100, 20);
            this.textBox_NameInput.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Price:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(97, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Product";
            // 
            // listBox_ProductsList
            // 
            this.listBox_ProductsList.FormattingEnabled = true;
            this.listBox_ProductsList.Location = new System.Drawing.Point(12, 21);
            this.listBox_ProductsList.Name = "listBox_ProductsList";
            this.listBox_ProductsList.Size = new System.Drawing.Size(242, 160);
            this.listBox_ProductsList.TabIndex = 12;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(134, 187);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(120, 23);
            this.btn_Delete.TabIndex = 13;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Location = new System.Drawing.Point(8, 187);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(120, 23);
            this.btn_Edit.TabIndex = 14;
            this.btn_Edit.Text = "Edit";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // InputProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 273);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.listBox_ProductsList);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Ok);
            this.Controls.Add(this.label1);
            this.Name = "InputProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InputProductForm";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_PriceInput)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_SubmitProduct;
        private System.Windows.Forms.NumericUpDown numericUpDown_PriceInput;
        private System.Windows.Forms.Button btn_Ok;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_NameInput;
        private System.Windows.Forms.ListBox listBox_ProductsList;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Edit;
    }
}
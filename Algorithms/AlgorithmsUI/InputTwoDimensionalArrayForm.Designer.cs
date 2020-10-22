namespace AlgorithmsUI
{
    partial class InputTwoDimensionalArrayForm
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
            this.dataGridView_TwoDimArray = new System.Windows.Forms.DataGridView();
            this.numericUpDown_Rows = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Columns = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_OK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_TwoDimArray)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Rows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Columns)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_TwoDimArray
            // 
            this.dataGridView_TwoDimArray.AllowUserToAddRows = false;
            this.dataGridView_TwoDimArray.AllowUserToDeleteRows = false;
            this.dataGridView_TwoDimArray.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_TwoDimArray.Location = new System.Drawing.Point(23, 106);
            this.dataGridView_TwoDimArray.Name = "dataGridView_TwoDimArray";
            this.dataGridView_TwoDimArray.Size = new System.Drawing.Size(268, 175);
            this.dataGridView_TwoDimArray.TabIndex = 0;
            // 
            // numericUpDown_Rows
            // 
            this.numericUpDown_Rows.Location = new System.Drawing.Point(171, 56);
            this.numericUpDown_Rows.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_Rows.Name = "numericUpDown_Rows";
            this.numericUpDown_Rows.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_Rows.TabIndex = 1;
            this.numericUpDown_Rows.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_Rows.ValueChanged += new System.EventHandler(this.numericUpDown_Rows_ValueChanged);
            // 
            // numericUpDown_Columns
            // 
            this.numericUpDown_Columns.Location = new System.Drawing.Point(171, 15);
            this.numericUpDown_Columns.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_Columns.Name = "numericUpDown_Columns";
            this.numericUpDown_Columns.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_Columns.TabIndex = 1;
            this.numericUpDown_Columns.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_Columns.ValueChanged += new System.EventHandler(this.numericUpDown_Columns_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.Location = new System.Drawing.Point(19, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Columns count:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label2.Location = new System.Drawing.Point(19, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Rows count:";
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(216, 318);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 23);
            this.btn_OK.TabIndex = 4;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // InputTwoDimensionalArrayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 362);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown_Columns);
            this.Controls.Add(this.numericUpDown_Rows);
            this.Controls.Add(this.dataGridView_TwoDimArray);
            this.Name = "InputTwoDimensionalArrayForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InputTwoDimensionalArrayForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_TwoDimArray)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Rows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Columns)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_TwoDimArray;
        private System.Windows.Forms.NumericUpDown numericUpDown_Rows;
        private System.Windows.Forms.NumericUpDown numericUpDown_Columns;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_OK;
    }
}
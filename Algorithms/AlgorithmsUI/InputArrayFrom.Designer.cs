namespace AlgorithmsUI
{
    partial class InputArrayFrom
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_Array = new System.Windows.Forms.DataGridView();
            this.btn_Ok = new System.Windows.Forms.Button();
            this.numericUpDown_Dimension = new System.Windows.Forms.NumericUpDown();
            this.btn_SubmitDimension = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Array)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Dimension)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter dimension of array:";
            // 
            // dataGridView_Array
            // 
            this.dataGridView_Array.AllowUserToAddRows = false;
            this.dataGridView_Array.AllowUserToResizeColumns = false;
            this.dataGridView_Array.AllowUserToResizeRows = false;
            this.dataGridView_Array.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Array.Location = new System.Drawing.Point(12, 81);
            this.dataGridView_Array.MultiSelect = false;
            this.dataGridView_Array.Name = "dataGridView_Array";
            this.dataGridView_Array.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView_Array.Size = new System.Drawing.Size(413, 47);
            this.dataGridView_Array.TabIndex = 2;
            // 
            // btn_Ok
            // 
            this.btn_Ok.Location = new System.Drawing.Point(179, 162);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(75, 23);
            this.btn_Ok.TabIndex = 3;
            this.btn_Ok.Text = "OK";
            this.btn_Ok.UseVisualStyleBackColor = true;
            this.btn_Ok.Click += new System.EventHandler(this.btn_Ok_Click);
            // 
            // numericUpDown_Dimension
            // 
            this.numericUpDown_Dimension.Location = new System.Drawing.Point(170, 35);
            this.numericUpDown_Dimension.Name = "numericUpDown_Dimension";
            this.numericUpDown_Dimension.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_Dimension.TabIndex = 4;
            // 
            // btn_SubmitDimension
            // 
            this.btn_SubmitDimension.Location = new System.Drawing.Point(306, 32);
            this.btn_SubmitDimension.Name = "btn_SubmitDimension";
            this.btn_SubmitDimension.Size = new System.Drawing.Size(75, 23);
            this.btn_SubmitDimension.TabIndex = 5;
            this.btn_SubmitDimension.Text = "Submit";
            this.btn_SubmitDimension.UseVisualStyleBackColor = true;
            this.btn_SubmitDimension.Click += new System.EventHandler(this.btn_SubmitDimension_Click);
            // 
            // InputArrayFrom
            // 
            this.AcceptButton = this.btn_Ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 214);
            this.Controls.Add(this.btn_SubmitDimension);
            this.Controls.Add(this.numericUpDown_Dimension);
            this.Controls.Add(this.btn_Ok);
            this.Controls.Add(this.dataGridView_Array);
            this.Controls.Add(this.label1);
            this.Name = "InputArrayFrom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InputArrayFrom";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Array)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Dimension)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_Array;
        private System.Windows.Forms.Button btn_Ok;
        private System.Windows.Forms.NumericUpDown numericUpDown_Dimension;
        private System.Windows.Forms.Button btn_SubmitDimension;
    }
}
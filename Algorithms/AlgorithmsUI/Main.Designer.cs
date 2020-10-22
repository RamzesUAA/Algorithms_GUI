namespace AlgorithmsUI
{
    partial class Main
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
            this.btn_EnterArray = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView_InitialArray = new System.Windows.Forms.DataGridView();
            this.dataGridView_ResultArray = new System.Windows.Forms.DataGridView();
            this.label_Time = new System.Windows.Forms.Label();
            this.button_Steps = new System.Windows.Forms.Button();
            this.comboBox_ChooseLab = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_SelectionSort = new System.Windows.Forms.Button();
            this.btn_ShellSort = new System.Windows.Forms.Button();
            this.btn_BubbleSort = new System.Windows.Forms.Button();
            this.btn_MergeSort = new System.Windows.Forms.Button();
            this.btn_QuickSort = new System.Windows.Forms.Button();
            this.btn_CountingSort = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_InitialArray)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ResultArray)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(224, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Initial array:";
            // 
            // btn_EnterArray
            // 
            this.btn_EnterArray.Location = new System.Drawing.Point(91, 399);
            this.btn_EnterArray.Name = "btn_EnterArray";
            this.btn_EnterArray.Size = new System.Drawing.Size(111, 47);
            this.btn_EnterArray.TabIndex = 1;
            this.btn_EnterArray.Text = "Enter array";
            this.btn_EnterArray.UseVisualStyleBackColor = true;
            this.btn_EnterArray.Click += new System.EventHandler(this.btn_EnterArray_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(224, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Result:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Execution time:";
            // 
            // dataGridView_InitialArray
            // 
            this.dataGridView_InitialArray.AllowUserToAddRows = false;
            this.dataGridView_InitialArray.AllowUserToResizeColumns = false;
            this.dataGridView_InitialArray.AllowUserToResizeRows = false;
            this.dataGridView_InitialArray.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_InitialArray.Location = new System.Drawing.Point(227, 25);
            this.dataGridView_InitialArray.MultiSelect = false;
            this.dataGridView_InitialArray.Name = "dataGridView_InitialArray";
            this.dataGridView_InitialArray.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView_InitialArray.Size = new System.Drawing.Size(413, 172);
            this.dataGridView_InitialArray.TabIndex = 6;
            // 
            // dataGridView_ResultArray
            // 
            this.dataGridView_ResultArray.AllowUserToAddRows = false;
            this.dataGridView_ResultArray.AllowUserToResizeColumns = false;
            this.dataGridView_ResultArray.AllowUserToResizeRows = false;
            this.dataGridView_ResultArray.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ResultArray.Location = new System.Drawing.Point(227, 233);
            this.dataGridView_ResultArray.MultiSelect = false;
            this.dataGridView_ResultArray.Name = "dataGridView_ResultArray";
            this.dataGridView_ResultArray.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView_ResultArray.Size = new System.Drawing.Size(413, 160);
            this.dataGridView_ResultArray.TabIndex = 7;
            // 
            // label_Time
            // 
            this.label_Time.AutoSize = true;
            this.label_Time.Location = new System.Drawing.Point(88, 49);
            this.label_Time.Name = "label_Time";
            this.label_Time.Size = new System.Drawing.Size(13, 13);
            this.label_Time.TabIndex = 8;
            this.label_Time.Text = "0";
            // 
            // button_Steps
            // 
            this.button_Steps.Location = new System.Drawing.Point(674, 399);
            this.button_Steps.Name = "button_Steps";
            this.button_Steps.Size = new System.Drawing.Size(111, 47);
            this.button_Steps.TabIndex = 9;
            this.button_Steps.Text = "Show steps";
            this.button_Steps.UseVisualStyleBackColor = true;
            this.button_Steps.Click += new System.EventHandler(this.button_Steps_Click);
            // 
            // comboBox_ChooseLab
            // 
            this.comboBox_ChooseLab.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_ChooseLab.Items.AddRange(new object[] {
            "laba1",
            "laba2",
            "laba3",
            "laba4",
            "laba5"});
            this.comboBox_ChooseLab.Location = new System.Drawing.Point(15, 135);
            this.comboBox_ChooseLab.Name = "comboBox_ChooseLab";
            this.comboBox_ChooseLab.Size = new System.Drawing.Size(121, 21);
            this.comboBox_ChooseLab.TabIndex = 12;
            this.comboBox_ChooseLab.SelectedIndexChanged += new System.EventHandler(this.comboBox_ChooseLab_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Choose number of lab:";
            // 
            // btn_SelectionSort
            // 
            this.btn_SelectionSort.Location = new System.Drawing.Point(374, 399);
            this.btn_SelectionSort.Name = "btn_SelectionSort";
            this.btn_SelectionSort.Size = new System.Drawing.Size(123, 47);
            this.btn_SelectionSort.TabIndex = 14;
            this.btn_SelectionSort.Text = "Selection sort";
            this.btn_SelectionSort.UseVisualStyleBackColor = true;
            this.btn_SelectionSort.Click += new System.EventHandler(this.btn_SelectionSort_Click);
            // 
            // btn_ShellSort
            // 
            this.btn_ShellSort.Location = new System.Drawing.Point(532, 399);
            this.btn_ShellSort.Name = "btn_ShellSort";
            this.btn_ShellSort.Size = new System.Drawing.Size(123, 47);
            this.btn_ShellSort.TabIndex = 15;
            this.btn_ShellSort.Text = "Shell sort";
            this.btn_ShellSort.UseVisualStyleBackColor = true;
            this.btn_ShellSort.Click += new System.EventHandler(this.btn_ShellSort_Click);
            // 
            // btn_BubbleSort
            // 
            this.btn_BubbleSort.Location = new System.Drawing.Point(227, 399);
            this.btn_BubbleSort.Name = "btn_BubbleSort";
            this.btn_BubbleSort.Size = new System.Drawing.Size(123, 47);
            this.btn_BubbleSort.TabIndex = 16;
            this.btn_BubbleSort.Text = "Bubble sort";
            this.btn_BubbleSort.UseVisualStyleBackColor = true;
            this.btn_BubbleSort.Click += new System.EventHandler(this.btn_BubbleSort_Click);
            // 
            // btn_MergeSort
            // 
            this.btn_MergeSort.Location = new System.Drawing.Point(227, 472);
            this.btn_MergeSort.Name = "btn_MergeSort";
            this.btn_MergeSort.Size = new System.Drawing.Size(123, 47);
            this.btn_MergeSort.TabIndex = 17;
            this.btn_MergeSort.Text = "Merge sort";
            this.btn_MergeSort.UseVisualStyleBackColor = true;
            this.btn_MergeSort.Click += new System.EventHandler(this.btn_MergeSort_Click);
            // 
            // btn_QuickSort
            // 
            this.btn_QuickSort.Location = new System.Drawing.Point(374, 472);
            this.btn_QuickSort.Name = "btn_QuickSort";
            this.btn_QuickSort.Size = new System.Drawing.Size(123, 47);
            this.btn_QuickSort.TabIndex = 18;
            this.btn_QuickSort.Text = "Quick sort";
            this.btn_QuickSort.UseVisualStyleBackColor = true;
            this.btn_QuickSort.Click += new System.EventHandler(this.btn_QuickSort_Click);
            // 
            // btn_CountingSort
            // 
            this.btn_CountingSort.Location = new System.Drawing.Point(532, 472);
            this.btn_CountingSort.Name = "btn_CountingSort";
            this.btn_CountingSort.Size = new System.Drawing.Size(123, 47);
            this.btn_CountingSort.TabIndex = 19;
            this.btn_CountingSort.Text = "Counting sort";
            this.btn_CountingSort.UseVisualStyleBackColor = true;
            this.btn_CountingSort.Click += new System.EventHandler(this.btn_CountingSort_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 544);
            this.Controls.Add(this.btn_CountingSort);
            this.Controls.Add(this.btn_QuickSort);
            this.Controls.Add(this.btn_MergeSort);
            this.Controls.Add(this.btn_BubbleSort);
            this.Controls.Add(this.btn_ShellSort);
            this.Controls.Add(this.btn_SelectionSort);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox_ChooseLab);
            this.Controls.Add(this.button_Steps);
            this.Controls.Add(this.label_Time);
            this.Controls.Add(this.dataGridView_ResultArray);
            this.Controls.Add(this.dataGridView_InitialArray);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_EnterArray);
            this.Controls.Add(this.label1);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_InitialArray)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ResultArray)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_EnterArray;
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView_InitialArray;
        private System.Windows.Forms.DataGridView dataGridView_ResultArray;
        private System.Windows.Forms.Label label_Time;
        private System.Windows.Forms.Button button_Steps;
        private System.Windows.Forms.ComboBox comboBox_ChooseLab;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_SelectionSort;
        private System.Windows.Forms.Button btn_ShellSort;
        private System.Windows.Forms.Button btn_BubbleSort;
        private System.Windows.Forms.Button btn_MergeSort;
        private System.Windows.Forms.Button btn_QuickSort;
        private System.Windows.Forms.Button btn_CountingSort;
    }
}


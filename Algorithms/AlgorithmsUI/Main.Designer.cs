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
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView_InitialArray = new System.Windows.Forms.DataGridView();
            this.dataGridView_ResultArray = new System.Windows.Forms.DataGridView();
            this.label_Time = new System.Windows.Forms.Label();
            this.button_Steps = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_InitialArray)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ResultArray)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(219, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Initial array:";
            // 
            // btn_EnterArray
            // 
            this.btn_EnterArray.Location = new System.Drawing.Point(116, 300);
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
            this.label2.Location = new System.Drawing.Point(219, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Result:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(362, 300);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 47);
            this.button1.TabIndex = 4;
            this.button1.Text = "Bubble sort";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 35);
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
            this.dataGridView_InitialArray.Location = new System.Drawing.Point(222, 95);
            this.dataGridView_InitialArray.MultiSelect = false;
            this.dataGridView_InitialArray.Name = "dataGridView_InitialArray";
            this.dataGridView_InitialArray.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView_InitialArray.Size = new System.Drawing.Size(413, 47);
            this.dataGridView_InitialArray.TabIndex = 6;
            // 
            // dataGridView_ResultArray
            // 
            this.dataGridView_ResultArray.AllowUserToAddRows = false;
            this.dataGridView_ResultArray.AllowUserToResizeColumns = false;
            this.dataGridView_ResultArray.AllowUserToResizeRows = false;
            this.dataGridView_ResultArray.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ResultArray.Location = new System.Drawing.Point(222, 210);
            this.dataGridView_ResultArray.MultiSelect = false;
            this.dataGridView_ResultArray.Name = "dataGridView_ResultArray";
            this.dataGridView_ResultArray.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView_ResultArray.Size = new System.Drawing.Size(413, 47);
            this.dataGridView_ResultArray.TabIndex = 7;
            // 
            // label_Time
            // 
            this.label_Time.AutoSize = true;
            this.label_Time.Location = new System.Drawing.Point(88, 35);
            this.label_Time.Name = "label_Time";
            this.label_Time.Size = new System.Drawing.Size(13, 13);
            this.label_Time.TabIndex = 8;
            this.label_Time.Text = "0";
            // 
            // button_Steps
            // 
            this.button_Steps.Location = new System.Drawing.Point(587, 300);
            this.button_Steps.Name = "button_Steps";
            this.button_Steps.Size = new System.Drawing.Size(111, 47);
            this.button_Steps.TabIndex = 9;
            this.button_Steps.Text = "Show steps";
            this.button_Steps.UseVisualStyleBackColor = true;
            this.button_Steps.Click += new System.EventHandler(this.button_Steps_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 420);
            this.Controls.Add(this.button_Steps);
            this.Controls.Add(this.label_Time);
            this.Controls.Add(this.dataGridView_ResultArray);
            this.Controls.Add(this.dataGridView_InitialArray);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView_InitialArray;
        private System.Windows.Forms.DataGridView dataGridView_ResultArray;
        private System.Windows.Forms.Label label_Time;
        private System.Windows.Forms.Button button_Steps;
    }
}


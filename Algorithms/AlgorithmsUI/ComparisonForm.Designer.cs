namespace AlgorithmsUI
{
    partial class ComparisonForm
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
            this.listBox_Demension = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_RunComparing = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_BubbleSortTime = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label_23 = new System.Windows.Forms.Label();
            this.label_SelectionSortTime = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label_ShellSortTime = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label_MergeSortTime = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label_QuickSortTime = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.label_CountingSortTime = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox_Demension
            // 
            this.listBox_Demension.FormattingEnabled = true;
            this.listBox_Demension.Items.AddRange(new object[] {
            "1024",
            "4096",
            "16384",
            "65536",
            "262144",
            "1048576",
            "4194304"});
            this.listBox_Demension.Location = new System.Drawing.Point(19, 15);
            this.listBox_Demension.Name = "listBox_Demension";
            this.listBox_Demension.Size = new System.Drawing.Size(120, 95);
            this.listBox_Demension.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.btn_RunComparing);
            this.panel1.Controls.Add(this.listBox_Demension);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(170, 174);
            this.panel1.TabIndex = 1;
            // 
            // btn_RunComparing
            // 
            this.btn_RunComparing.BackColor = System.Drawing.SystemColors.Info;
            this.btn_RunComparing.Location = new System.Drawing.Point(19, 128);
            this.btn_RunComparing.Name = "btn_RunComparing";
            this.btn_RunComparing.Size = new System.Drawing.Size(120, 23);
            this.btn_RunComparing.TabIndex = 1;
            this.btn_RunComparing.Text = "Run comparing";
            this.btn_RunComparing.UseVisualStyleBackColor = false;
            this.btn_RunComparing.Click += new System.EventHandler(this.btn_RunComparing_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.label1.Location = new System.Drawing.Point(76, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Executive time:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label2.Location = new System.Drawing.Point(122, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bubble sort";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label_BubbleSortTime);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(188, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(310, 54);
            this.panel2.TabIndex = 3;
            // 
            // label_BubbleSortTime
            // 
            this.label_BubbleSortTime.AutoSize = true;
            this.label_BubbleSortTime.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.label_BubbleSortTime.Location = new System.Drawing.Point(161, 34);
            this.label_BubbleSortTime.Name = "label_BubbleSortTime";
            this.label_BubbleSortTime.Size = new System.Drawing.Size(13, 13);
            this.label_BubbleSortTime.TabIndex = 2;
            this.label_BubbleSortTime.Text = "0";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel3.Controls.Add(this.label_23);
            this.panel3.Controls.Add(this.label_SelectionSortTime);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(188, 72);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(310, 54);
            this.panel3.TabIndex = 3;
            // 
            // label_23
            // 
            this.label_23.AutoSize = true;
            this.label_23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label_23.Location = new System.Drawing.Point(122, 5);
            this.label_23.Name = "label_23";
            this.label_23.Size = new System.Drawing.Size(106, 20);
            this.label_23.TabIndex = 2;
            this.label_23.Text = "Selection sort";
            // 
            // label_SelectionSortTime
            // 
            this.label_SelectionSortTime.AutoSize = true;
            this.label_SelectionSortTime.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.label_SelectionSortTime.Location = new System.Drawing.Point(161, 34);
            this.label_SelectionSortTime.Name = "label_SelectionSortTime";
            this.label_SelectionSortTime.Size = new System.Drawing.Size(13, 13);
            this.label_SelectionSortTime.TabIndex = 2;
            this.label_SelectionSortTime.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.label5.Location = new System.Drawing.Point(76, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Executive time:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label_ShellSortTime);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Location = new System.Drawing.Point(188, 132);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(310, 54);
            this.panel4.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label6.Location = new System.Drawing.Point(122, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Shell sort";
            // 
            // label_ShellSortTime
            // 
            this.label_ShellSortTime.AutoSize = true;
            this.label_ShellSortTime.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.label_ShellSortTime.Location = new System.Drawing.Point(161, 34);
            this.label_ShellSortTime.Name = "label_ShellSortTime";
            this.label_ShellSortTime.Size = new System.Drawing.Size(13, 13);
            this.label_ShellSortTime.TabIndex = 2;
            this.label_ShellSortTime.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.label8.Location = new System.Drawing.Point(76, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Executive time:";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.label_MergeSortTime);
            this.panel5.Controls.Add(this.label11);
            this.panel5.Location = new System.Drawing.Point(504, 12);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(310, 54);
            this.panel5.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label9.Location = new System.Drawing.Point(122, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 20);
            this.label9.TabIndex = 2;
            this.label9.Text = "Merge sort";
            // 
            // label_MergeSortTime
            // 
            this.label_MergeSortTime.AutoSize = true;
            this.label_MergeSortTime.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.label_MergeSortTime.Location = new System.Drawing.Point(161, 34);
            this.label_MergeSortTime.Name = "label_MergeSortTime";
            this.label_MergeSortTime.Size = new System.Drawing.Size(13, 13);
            this.label_MergeSortTime.TabIndex = 2;
            this.label_MergeSortTime.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.label11.Location = new System.Drawing.Point(76, 34);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Executive time:";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel6.Controls.Add(this.label12);
            this.panel6.Controls.Add(this.label_QuickSortTime);
            this.panel6.Controls.Add(this.label14);
            this.panel6.Location = new System.Drawing.Point(504, 72);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(310, 54);
            this.panel6.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label12.Location = new System.Drawing.Point(122, 5);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 20);
            this.label12.TabIndex = 2;
            this.label12.Text = "Quick sort";
            // 
            // label_QuickSortTime
            // 
            this.label_QuickSortTime.AutoSize = true;
            this.label_QuickSortTime.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.label_QuickSortTime.Location = new System.Drawing.Point(161, 34);
            this.label_QuickSortTime.Name = "label_QuickSortTime";
            this.label_QuickSortTime.Size = new System.Drawing.Size(13, 13);
            this.label_QuickSortTime.TabIndex = 2;
            this.label_QuickSortTime.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.label14.Location = new System.Drawing.Point(76, 34);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(79, 13);
            this.label14.TabIndex = 2;
            this.label14.Text = "Executive time:";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel7.Controls.Add(this.label15);
            this.panel7.Controls.Add(this.label_CountingSortTime);
            this.panel7.Controls.Add(this.label17);
            this.panel7.Location = new System.Drawing.Point(504, 132);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(310, 54);
            this.panel7.TabIndex = 3;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label15.Location = new System.Drawing.Point(122, 5);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(104, 20);
            this.label15.TabIndex = 2;
            this.label15.Text = "Counting sort";
            // 
            // label_CountingSortTime
            // 
            this.label_CountingSortTime.AutoSize = true;
            this.label_CountingSortTime.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.label_CountingSortTime.Location = new System.Drawing.Point(161, 34);
            this.label_CountingSortTime.Name = "label_CountingSortTime";
            this.label_CountingSortTime.Size = new System.Drawing.Size(13, 13);
            this.label_CountingSortTime.TabIndex = 2;
            this.label_CountingSortTime.Text = "0";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.label17.Location = new System.Drawing.Point(76, 34);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(79, 13);
            this.label17.TabIndex = 2;
            this.label17.Text = "Executive time:";
            // 
            // ComparisonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 200);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ComparisonForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ComparisonForm";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_Demension;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_RunComparing;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label_BubbleSortTime;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label_23;
        private System.Windows.Forms.Label label_SelectionSortTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_ShellSortTime;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label_MergeSortTime;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label_QuickSortTime;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label_CountingSortTime;
        private System.Windows.Forms.Label label17;
    }
}
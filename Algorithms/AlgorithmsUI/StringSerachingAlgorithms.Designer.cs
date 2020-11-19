namespace AlgorithmsUI
{
    partial class StringSerachingAlgorithms
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
            this.button_DirectStringSearch = new System.Windows.Forms.Button();
            this.button_Knuth_MorrisAndPratt = new System.Windows.Forms.Button();
            this.button_Boyer_Moore = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_DirectStringSearch
            // 
            this.button_DirectStringSearch.Location = new System.Drawing.Point(12, 116);
            this.button_DirectStringSearch.Name = "button_DirectStringSearch";
            this.button_DirectStringSearch.Size = new System.Drawing.Size(120, 76);
            this.button_DirectStringSearch.TabIndex = 0;
            this.button_DirectStringSearch.Text = "Direct string search";
            this.button_DirectStringSearch.UseVisualStyleBackColor = true;
            this.button_DirectStringSearch.Click += new System.EventHandler(this.button_DirectStringSearch_Click);
            // 
            // button_Knuth_MorrisAndPratt
            // 
            this.button_Knuth_MorrisAndPratt.Location = new System.Drawing.Point(138, 116);
            this.button_Knuth_MorrisAndPratt.Name = "button_Knuth_MorrisAndPratt";
            this.button_Knuth_MorrisAndPratt.Size = new System.Drawing.Size(186, 76);
            this.button_Knuth_MorrisAndPratt.TabIndex = 1;
            this.button_Knuth_MorrisAndPratt.Text = "Knuth-Morris-Pratt Algorithm";
            this.button_Knuth_MorrisAndPratt.UseVisualStyleBackColor = true;
            this.button_Knuth_MorrisAndPratt.Click += new System.EventHandler(this.button_Knuth_MorrisAndPratt_Click);
            // 
            // button_Boyer_Moore
            // 
            this.button_Boyer_Moore.Location = new System.Drawing.Point(330, 116);
            this.button_Boyer_Moore.Name = "button_Boyer_Moore";
            this.button_Boyer_Moore.Size = new System.Drawing.Size(120, 76);
            this.button_Boyer_Moore.TabIndex = 2;
            this.button_Boyer_Moore.Text = "Boyer–Moore ";
            this.button_Boyer_Moore.UseVisualStyleBackColor = true;
            this.button_Boyer_Moore.Click += new System.EventHandler(this.button_Boyer_Moore_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.Location = new System.Drawing.Point(30, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(391, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Choose string seraching algorithms";
            // 
            // StringSerachingAlgorithms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 244);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Boyer_Moore);
            this.Controls.Add(this.button_Knuth_MorrisAndPratt);
            this.Controls.Add(this.button_DirectStringSearch);
            this.Name = "StringSerachingAlgorithms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StringSerachingAlgorithms";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_DirectStringSearch;
        private System.Windows.Forms.Button button_Knuth_MorrisAndPratt;
        private System.Windows.Forms.Button button_Boyer_Moore;
        private System.Windows.Forms.Label label1;
    }
}
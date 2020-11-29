namespace AlgorithmsUI
{
    partial class KnuthMorrisPrattSearchForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.richTextBox_FirstText = new System.Windows.Forms.RichTextBox();
            this.button_Find = new System.Windows.Forms.Button();
            this.richTextBox_SecondText = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxEteredPoints = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label_minWord = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Enered pints:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PeachPuff;
            this.panel2.Controls.Add(this.label_minWord);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.listBoxEteredPoints);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.button_Find);
            this.panel2.Location = new System.Drawing.Point(99, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(335, 108);
            this.panel2.TabIndex = 9;
            // 
            // richTextBox_FirstText
            // 
            this.richTextBox_FirstText.Location = new System.Drawing.Point(12, 160);
            this.richTextBox_FirstText.Name = "richTextBox_FirstText";
            this.richTextBox_FirstText.Size = new System.Drawing.Size(495, 102);
            this.richTextBox_FirstText.TabIndex = 10;
            this.richTextBox_FirstText.Text = "";
            // 
            // button_Find
            // 
            this.button_Find.Location = new System.Drawing.Point(184, 62);
            this.button_Find.Name = "button_Find";
            this.button_Find.Size = new System.Drawing.Size(121, 30);
            this.button_Find.TabIndex = 3;
            this.button_Find.Text = "Find";
            this.button_Find.UseVisualStyleBackColor = true;
            this.button_Find.Click += new System.EventHandler(this.button_Find_Click);
            // 
            // richTextBox_SecondText
            // 
            this.richTextBox_SecondText.Location = new System.Drawing.Point(12, 297);
            this.richTextBox_SecondText.Name = "richTextBox_SecondText";
            this.richTextBox_SecondText.Size = new System.Drawing.Size(495, 102);
            this.richTextBox_SecondText.TabIndex = 11;
            this.richTextBox_SecondText.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.Location = new System.Drawing.Point(207, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "First text";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label2.Location = new System.Drawing.Point(207, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 24);
            this.label2.TabIndex = 13;
            this.label2.Text = "Second text";
            // 
            // listBoxEteredPoints
            // 
            this.listBoxEteredPoints.FormattingEnabled = true;
            this.listBoxEteredPoints.Location = new System.Drawing.Point(12, 19);
            this.listBoxEteredPoints.Name = "listBoxEteredPoints";
            this.listBoxEteredPoints.Size = new System.Drawing.Size(143, 82);
            this.listBoxEteredPoints.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label4.Location = new System.Drawing.Point(161, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Min word:";
            // 
            // label_minWord
            // 
            this.label_minWord.AutoSize = true;
            this.label_minWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label_minWord.Location = new System.Drawing.Point(235, 32);
            this.label_minWord.Name = "label_minWord";
            this.label_minWord.Size = new System.Drawing.Size(18, 17);
            this.label_minWord.TabIndex = 9;
            this.label_minWord.Text = "\"\"";
            // 
            // KnuthMorrisPrattSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 431);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox_SecondText);
            this.Controls.Add(this.richTextBox_FirstText);
            this.Controls.Add(this.panel2);
            this.Name = "KnuthMorrisPrattSearchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KnuthMorrisPrattSearchForm";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_Find;
        private System.Windows.Forms.RichTextBox richTextBox_FirstText;
        private System.Windows.Forms.RichTextBox richTextBox_SecondText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxEteredPoints;
        private System.Windows.Forms.Label label_minWord;
        private System.Windows.Forms.Label label4;
    }
}
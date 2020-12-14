namespace AlgorithmsUI
{
    partial class BoyerMooreSearchForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_MainTextLength = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox_EnteredPoints = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Text = new System.Windows.Forms.RichTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_ReadFromFile = new System.Windows.Forms.Button();
            this.button_Find = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.label_MainTextLength);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.comboBox_EnteredPoints);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(166, 158);
            this.panel1.TabIndex = 3;
            // 
            // label_MainTextLength
            // 
            this.label_MainTextLength.AutoSize = true;
            this.label_MainTextLength.Location = new System.Drawing.Point(107, 94);
            this.label_MainTextLength.Name = "label_MainTextLength";
            this.label_MainTextLength.Size = new System.Drawing.Size(13, 13);
            this.label_MainTextLength.TabIndex = 7;
            this.label_MainTextLength.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Main text length:";
            // 
            // comboBox_EnteredPoints
            // 
            this.comboBox_EnteredPoints.BackColor = System.Drawing.Color.Moccasin;
            this.comboBox_EnteredPoints.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_EnteredPoints.ForeColor = System.Drawing.SystemColors.InfoText;
            this.comboBox_EnteredPoints.FormattingEnabled = true;
            this.comboBox_EnteredPoints.Location = new System.Drawing.Point(19, 44);
            this.comboBox_EnteredPoints.Name = "comboBox_EnteredPoints";
            this.comboBox_EnteredPoints.Size = new System.Drawing.Size(121, 21);
            this.comboBox_EnteredPoints.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Enered item:";
            // 
            // textBox_Text
            // 
            this.textBox_Text.Location = new System.Drawing.Point(4, 176);
            this.textBox_Text.Name = "textBox_Text";
            this.textBox_Text.ReadOnly = true;
            this.textBox_Text.Size = new System.Drawing.Size(243, 237);
            this.textBox_Text.TabIndex = 9;
            this.textBox_Text.Text = "";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(253, 176);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(242, 237);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PeachPuff;
            this.panel2.Controls.Add(this.button_ReadFromFile);
            this.panel2.Controls.Add(this.button_Find);
            this.panel2.Location = new System.Drawing.Point(169, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(334, 158);
            this.panel2.TabIndex = 11;
            // 
            // button_ReadFromFile
            // 
            this.button_ReadFromFile.Location = new System.Drawing.Point(94, 19);
            this.button_ReadFromFile.Name = "button_ReadFromFile";
            this.button_ReadFromFile.Size = new System.Drawing.Size(124, 46);
            this.button_ReadFromFile.TabIndex = 4;
            this.button_ReadFromFile.Text = "Read data from file";
            this.button_ReadFromFile.UseVisualStyleBackColor = true;
            this.button_ReadFromFile.Click += new System.EventHandler(this.button_ReadFromFile_Click);
            // 
            // button_Find
            // 
            this.button_Find.Location = new System.Drawing.Point(94, 85);
            this.button_Find.Name = "button_Find";
            this.button_Find.Size = new System.Drawing.Size(124, 46);
            this.button_Find.TabIndex = 3;
            this.button_Find.Text = "Find P in S";
            this.button_Find.UseVisualStyleBackColor = true;
            this.button_Find.Click += new System.EventHandler(this.button_Find_Click);
            // 
            // BoyerMooreSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 424);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.textBox_Text);
            this.Controls.Add(this.panel1);
            this.Name = "BoyerMooreSearchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BoyerMooreSearchForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_MainTextLength;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox_EnteredPoints;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox textBox_Text;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_Find;
        private System.Windows.Forms.Button button_ReadFromFile;
    }
}
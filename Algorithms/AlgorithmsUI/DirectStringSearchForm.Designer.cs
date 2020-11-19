namespace AlgorithmsUI
{
    partial class DirectStringSearchForm
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
            this.textBox_FindText = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox_EnteredPoints = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_Find = new System.Windows.Forms.Button();
            this.numericUpDown_StartPosition = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBox_Direction = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label_MainTextLength = new System.Windows.Forms.Label();
            this.textBox_Text = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_StartPosition)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_FindText
            // 
            this.textBox_FindText.Location = new System.Drawing.Point(5, 87);
            this.textBox_FindText.Name = "textBox_FindText";
            this.textBox_FindText.Size = new System.Drawing.Size(304, 20);
            this.textBox_FindText.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.label_MainTextLength);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.comboBox_EnteredPoints);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(329, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(173, 158);
            this.panel1.TabIndex = 2;
            // 
            // comboBox_EnteredPoints
            // 
            this.comboBox_EnteredPoints.BackColor = System.Drawing.Color.Moccasin;
            this.comboBox_EnteredPoints.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_EnteredPoints.ForeColor = System.Drawing.SystemColors.InfoText;
            this.comboBox_EnteredPoints.FormattingEnabled = true;
            this.comboBox_EnteredPoints.Location = new System.Drawing.Point(30, 44);
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
            // button_Find
            // 
            this.button_Find.Location = new System.Drawing.Point(115, 115);
            this.button_Find.Name = "button_Find";
            this.button_Find.Size = new System.Drawing.Size(102, 27);
            this.button_Find.TabIndex = 3;
            this.button_Find.Text = "Find";
            this.button_Find.UseVisualStyleBackColor = true;
            this.button_Find.Click += new System.EventHandler(this.button_Find_Click);
            // 
            // numericUpDown_StartPosition
            // 
            this.numericUpDown_StartPosition.Location = new System.Drawing.Point(174, 29);
            this.numericUpDown_StartPosition.Name = "numericUpDown_StartPosition";
            this.numericUpDown_StartPosition.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_StartPosition.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(187, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Enter start position:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Enter sequence direction:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(112, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Enter string to enter:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label5.Location = new System.Drawing.Point(205, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 26);
            this.label5.TabIndex = 6;
            this.label5.Text = "Main text";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PeachPuff;
            this.panel2.Controls.Add(this.comboBox_Direction);
            this.panel2.Controls.Add(this.button_Find);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.textBox_FindText);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.numericUpDown_StartPosition);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(11, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(312, 158);
            this.panel2.TabIndex = 7;
            // 
            // comboBox_Direction
            // 
            this.comboBox_Direction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Direction.FormattingEnabled = true;
            this.comboBox_Direction.Items.AddRange(new object[] {
            "Direct sequence",
            "Reberse sequence"});
            this.comboBox_Direction.Location = new System.Drawing.Point(19, 28);
            this.comboBox_Direction.Name = "comboBox_Direction";
            this.comboBox_Direction.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Direction.TabIndex = 7;
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
            // label_MainTextLength
            // 
            this.label_MainTextLength.AutoSize = true;
            this.label_MainTextLength.Location = new System.Drawing.Point(107, 94);
            this.label_MainTextLength.Name = "label_MainTextLength";
            this.label_MainTextLength.Size = new System.Drawing.Size(13, 13);
            this.label_MainTextLength.TabIndex = 7;
            this.label_MainTextLength.Text = "0";
            // 
            // textBox_Text
            // 
            this.textBox_Text.Location = new System.Drawing.Point(11, 220);
            this.textBox_Text.Name = "textBox_Text";
            this.textBox_Text.Size = new System.Drawing.Size(491, 216);
            this.textBox_Text.TabIndex = 8;
            this.textBox_Text.Text = "";
            this.textBox_Text.TextChanged += new System.EventHandler(this.textBox_Text_TextChanged_1);
            // 
            // DirectStringSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 448);
            this.Controls.Add(this.textBox_Text);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Name = "DirectStringSearchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DirectStringSearchForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_StartPosition)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_FindText;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox_EnteredPoints;
        private System.Windows.Forms.Button button_Find;
        private System.Windows.Forms.NumericUpDown numericUpDown_StartPosition;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBox_Direction;
        private System.Windows.Forms.Label label_MainTextLength;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox textBox_Text;
    }
}
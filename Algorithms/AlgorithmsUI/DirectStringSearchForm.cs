using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgorithmsUI
{
    public partial class DirectStringSearchForm : Form
    {
        public DirectStringSearchForm()
        {
            InitializeComponent();
        }

        List<int> FindEnteredPointsDirectWay(string mainText, string FindString, int startPoint)
        {
            List<int> EnteredPoints = new List<int>();
            for (int i = startPoint; i <= mainText.Length - FindString.Length; ++i)
            {
                int n = i;
                for (int j = 0; j < FindString.Length; ++j)
                {

                    if (mainText[n] == FindString[j])
                    {
                        n++;
                        if (j == 0)
                        {
                            EnteredPoints.Add(i);
                        }
                    }
                    else
                    {
                        if (j != 0)
                        {
                            EnteredPoints.Remove(i);
                        }
                        break;
                    }
                }
            }
            return EnteredPoints;
        }

        static List<int> FindEnteredPointsReversedWay(string mainText, string FindString, int startPoint)
        {
            List<int> EnteredPoints = new List<int>();
            for (int i = startPoint - 1; i >= 0 + FindString.Length - 1; --i)
            {
                int n = i;
                for (int j = 0; j < FindString.Length; ++j)
                {

                    if (mainText[n] == FindString[j])
                    {
                        n--;
                        if (j == 0)
                        {
                            EnteredPoints.Add(i);
                        }
                    }
                    else
                    {
                        if (j != 0)
                        {
                            EnteredPoints.Remove(i);
                        }
                        break;
                    }
                }
            }
            return EnteredPoints;
        }

        public string formaatedstring(string mainvalue, string partvalue)
        {
            return Regex.Replace(mainvalue, partvalue, @"<b>$0</b>", RegexOptions.IgnoreCase);
        }

        private void button_Find_Click(object sender, EventArgs e)
        {
            if(comboBox_Direction.SelectedItem == null || textBox_FindText.Text.Length == 0 || textBox_Text.Text.Length ==0 || textBox_FindText.Text.Length > textBox_Text.Text.Length)
            {
                MessageBox.Show("Fill all places.");
                return;
            }

            List<int> enteredPoints = new List<int>();
            if (comboBox_Direction.SelectedItem.ToString() == "Direct sequence")
            {
                comboBox_EnteredPoints.Items.Clear();
                enteredPoints = FindEnteredPointsDirectWay(textBox_Text.Text, textBox_FindText.Text, (int)numericUpDown_StartPosition.Value);
                foreach (var item in enteredPoints)
                {
                    comboBox_EnteredPoints.Items.Add(item + 1);
                }



                string result = @"{\rtf1\ansi ";
                int counter = 0;
                for (int i = 0; i < textBox_Text.Text.Length; ++i)
                {
                    if (counter < enteredPoints.Count && enteredPoints[counter] == i)
                    {
                        result += @"\b ";
                        for (int j = 0; j < textBox_FindText.Text.Length; ++j)
                        {
                            result += textBox_FindText.Text[j];
                        }
                        counter++;
                        result += @"\b0 ";
                        i = i + textBox_FindText.Text.Length - 1;
                    }
                    else
                    {
                        result += textBox_Text.Text[i];
                    }
                }
                result += @"}";

                textBox_Text.Rtf = result;

            }
            else if(comboBox_Direction.SelectedItem.ToString() == "Reberse sequence")
            {
                comboBox_EnteredPoints.Items.Clear();
                

                int startPoint = (int)numericUpDown_StartPosition.Value;
                if(startPoint == 0)
                {
                    startPoint = Convert.ToInt32(label_MainTextLength.Text);
                }
                enteredPoints = FindEnteredPointsReversedWay(textBox_Text.Text, textBox_FindText.Text, startPoint);
                foreach (var item in enteredPoints)
                {
                    comboBox_EnteredPoints.Items.Add(item + 1);
                }
            }

        }



        private void textBox_Text_TextChanged_1(object sender, EventArgs e)
        {
            label_MainTextLength.Text = textBox_Text.Text.Length.ToString();
        }
    }
}

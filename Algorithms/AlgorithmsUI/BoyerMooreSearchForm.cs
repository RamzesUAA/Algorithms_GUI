using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgorithmsUI
{
    public partial class BoyerMooreSearchForm : Form
    {
        public BoyerMooreSearchForm()
        {
            InitializeComponent();
        }
        private string stringS { get; set; }
        private string stringP { get; set; }
        public static List<int> SearchString(string str, string pat)
        {
            List<int> retVal = new List<int>();
            int m = pat.Length;
            int n = str.Length;

            int[] badChar = new int[256];

            BadCharHeuristic(pat, m, ref badChar);

            int s = 0;
            while (s <= (n - m))
            {
                int j = m - 1;

                while (j >= 0 && pat[j] == str[s + j])
                    --j;

                if (j < 0)
                {
                    retVal.Add(s);
                    s += (s + m < n) ? m - badChar[str[s + m]] : 1;
                }
                else
                {
                    s += Math.Max(1, j - badChar[str[s + j]]);
                }
            }

            return retVal;
        }

        private static void BadCharHeuristic(string str, int size, ref int[] badChar)
        {
            int i;

            for (i = 0; i < 256; i++)
                badChar[i] = -1;

            for (i = 0; i < size; i++)
                badChar[(int)str[i]] = i;
        }

        private void button_Find_Click(object sender, EventArgs e)
        {
            comboBox_EnteredPoints.Items.Clear();
            var enteredPoints = SearchString(stringS, stringP);

            for (int i = enteredPoints.Count- 1; i >= 0; --i)
            {
                comboBox_EnteredPoints.Items.Add(enteredPoints[i]);
            }

            string result = @"{\rtf1\ansi ";
            int counter = 0;
            for (int i = 0; i < richTextBox1.Text.Length; ++i)
            {
                if (counter < enteredPoints.Count && enteredPoints[counter] == i)
                {
                    result += @"\b ";
                    for (int j = 0; j < stringP.Length; ++j)
                    {
                        result += stringP[j];
                    }
                    counter++;
                    result += @"\b0 ";
                    i = i + stringP.Length - 1;
                }
                else
                {
                    result += richTextBox1.Text[i];
                }
            }
            result += @"}";

            richTextBox1.Rtf = result;
            richTextBox1.Rtf += "";
        }

        private void button_ReadFromFile_Click(object sender, EventArgs e)
        {
            using (StreamReader sr = new StreamReader("C:\\Users\\Roman\\Desktop\\Algorithms_GUI\\Algorithms\\strings.txt"))
            {

                string line;
                // Read and display lines from the file until the end of
                // the file is reached.
                int i = 0;
                while ((line = sr.ReadLine()) != null)
                {
                    if (i == 0)
                    {
                        stringS = line;
                    }
                    else
                    {
                        stringP = line;
                    }
                    ++i;
                }
            }


            richTextBox1.Text = stringS;
            textBox_Text.Text = stringP;
        }
    }
}

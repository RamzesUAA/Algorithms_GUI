using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgorithmsUI
{
    public partial class KnuthMorrisPrattSearchForm : Form
    {
        public KnuthMorrisPrattSearchForm()
        {
            InitializeComponent();
        }

        string FindMinWord(string text)
        {
            char[] separators = { ' ', ',', '.' };
            string[] words = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            string min = words[0];
            foreach (var word in words)
            {
                if (min.Length > word.Length)
                {
                    min = word;
                }
            }
            return min;
        }

        List<int> KnuthMorrisPrattSearching(string mainText, string wordToFind)
        {
            List<int> eteredPoints = new List<int>();
            int mainTextLength = mainText.Length;
            int wordLength = wordToFind.Length;
            
            int[] prefixSufix = new int[wordLength];

            PrefixSufixFunction(wordToFind, wordLength, prefixSufix);

            int j = 0;
            int i = 0;
            while (i < mainTextLength)
            {
                if (wordToFind[j] == mainText[i])
                {
                    j++;
                    i++;
                }
                if (j == wordLength)
                {
                    eteredPoints.Add(i-j);
                    j = prefixSufix[j - 1];
                }

                else if (i < mainTextLength && wordToFind[j] != mainText[i])
                {
                    if (j != 0)
                        j = prefixSufix[j - 1];
                    else
                        i = i + 1;
                }
            }
            return eteredPoints;
        }


        void PrefixSufixFunction(string wordToFind, int wordLength, int[] prefixSufix)
        {
            prefixSufix[0] = 0;

            int lenght = 0;
            int i = 1;
            while (i < wordLength)
            {
                if (wordToFind[i] == wordToFind[lenght])
                {
                    lenght++;
                    prefixSufix[i] = lenght;
                    i++;
                }
                else 
                {
                    if (lenght != 0)
                    {
                        lenght = prefixSufix[lenght - 1];
                    }
                    else
                    {
                        prefixSufix[i] = lenght;
                        i++;
                    }
                }
            }
        }


        private void button_Find_Click(object sender, EventArgs e)
        {
            listBoxEteredPoints.Items.Clear();
            string firstText = richTextBox_FirstText.Text;
            string secondText = richTextBox_SecondText.Text;

            string minWord = FindMinWord(firstText);
            label_minWord.Text = $"\"{minWord}\"";
            List<int> enteredPoints =  KnuthMorrisPrattSearching(secondText, minWord);

            foreach (var item in enteredPoints)
            {
                listBoxEteredPoints.Items.Add(item);
            }

            string result = @"{\rtf1\ansi ";
            int counter = 0;
            for (int i = 0; i < richTextBox_SecondText.Text.Length; ++i)
            {
                if (counter < enteredPoints.Count && enteredPoints[counter] == i)
                {
                    result += @"\b ";
                    for (int j = 0; j < minWord.Length; ++j)
                    {
                        result += minWord[j];
                    }
                    counter++;
                    result += @"\b0 ";
                    i = i + minWord.Length - 1;
                }
                else
                {
                    result += richTextBox_SecondText.Text[i];
                }
            }
            result += @"}";

            richTextBox_SecondText.Rtf = result;
            richTextBox_SecondText.Rtf += "";
        }
    }
}

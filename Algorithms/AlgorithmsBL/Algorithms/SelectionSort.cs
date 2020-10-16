using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsBL.Algorithms
{
    public class SelectionSort
    {
        public void selectionSort(List<Product> products, ref string str)
        {
            str = "";
            int counter = 0;
            int size = products.Count;
            for (int i = 0; i < size - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < size; j++)
                {
                    if (string.Compare(products[min].Name, products[j].Name) > 0)
                    {
                        min = j;
                    }
                    counter++;
                    str += $"Step {counter}: ";
                    foreach(var item in products)
                    {
                        str += item;
                        str += ", ";
                    }
                    str += "\n";
                }
                var temp = products[min];
                products[min] = products[i];
                products[i] = temp;
            }   
        }
    }
}

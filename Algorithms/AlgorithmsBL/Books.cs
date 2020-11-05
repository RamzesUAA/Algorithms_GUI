using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsBL.Algorithms
{
    public class Books
    {
        Random Random = new Random();
        private Book[] books;
        public Books(int n)
        {
            books = new Book[n];
            for (int i = 0; i < n; ++i)
            {
                books[i] = new Book() { Name = $"Book_" + (i+20), Price = Random.Next(10, 1000) };
            }
            selectionSort();
        }
        public void selectionSort()
        {

            int size = books.Length;
            for (int i = 0; i < size - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < size; j++)
                {
                    if (books[min].Price > books[j].Price)
                    {
                        min = j;
                    }
                }
                var temp = books[min];
                books[min] = books[i];
                books[i] = temp;
            }
        }

        public Book this[int index]
        {
            get
            {
                return books[index-20];
            }
            set
            {
                books[index-20] = value;
            }
        }
        public override int GetHashCode()
        {
            return books.Length;
        }

    }
}

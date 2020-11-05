using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsBL.Algorithms
{
    public class BinnarySearch
    {
        public BinnarySearch()
        {

        }

        public int binnarySearch(Books books, int item, out int numberOfComparisons)
        {
            numberOfComparisons = 0;
            int min = 0 + 20;
            int max = books.GetHashCode() - 1 + 20;
            while (min <= max)
            {
                numberOfComparisons++;
                int mid = (min + max) / 2;
                if (item == books[mid].Price)
                {
                    return mid;
                }
                else if (item < books[mid].Price)
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }

            return -1;
        }
    }
}

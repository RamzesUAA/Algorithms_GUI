using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsBL.Algorithms
{
    public abstract class SortBase
    {
        public void Swap<T>(ref T first, ref T second)
        {
            T temp;
            temp = first;
            first = second;
            second = temp;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsBL.Algorithms
{
    public abstract class SortBase
    {
        public void Swap(ref double first, ref double second)
        {
            double temp;
            temp = first;
            first = second;
            second = temp;
        }

    }
}

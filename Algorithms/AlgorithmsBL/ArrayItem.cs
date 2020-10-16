using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsBL
{
    public class ArrayItem
    {
        private Random random = new Random();
        public double[] Array;
        public ArrayItem()
        {
        }

        public void AuthoPlaceholder()
        {
            for (int i = 0; i < Array.Length; ++i)
            {
                Array[i] = random.Next(0, 2147483647);
            }
        }

        public void DeleteMaxAndMin()
        {
            double max = Array.Max();
            double min = Array.Min();
            Array = Array.Where(p => p != max && p != min).ToArray();
        }

        public void CinfigurateEvenNumbers()
        {
            for(int i = 0; i < Array.Length; ++i)
            {
                if(Array[i] % 2 == 0)
                {
                    Array[i] = Math.Round(Math.Sqrt(Math.Abs(Array[i] - 10)));
                }
            }
        }
    }
}

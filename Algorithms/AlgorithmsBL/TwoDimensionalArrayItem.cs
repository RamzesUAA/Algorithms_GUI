using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsBL
{
    public class TwoDimensionalArrayItem
    {
        public TwoDimensionalArrayItem() {
        }
        public int SIZE => Array.GetLength(0);
        private Random random = new Random();
        public double[,] Array { get; set; }
    }
}

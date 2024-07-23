using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiDimensionalIndexes
{
    internal class MDI
    {
        private int[,] arr = new int[5,5];

        public int this[int row, int col]
        {
            get
            {
                return arr[row,col];
            }
            set 
            {
                arr[row,col] = value;
            }
        }
    }
}

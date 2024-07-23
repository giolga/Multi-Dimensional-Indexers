using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiDimensionalIndexes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MDI mdi = new MDI();
            Random random = new Random();

            for(int i = 0; i < 4; i++)
            {
                for(int j = 0; j < 4; j++)
                {
                    mdi[i, j] = random.Next(1, 100);
                }
            }

            Console.WriteLine("The multidimensional indexers give us the following : ");
            for (int i = 0;i < 4; i++) {
                for(int j = 0; j < 4; j++)
                    Console.Write(mdi[i,j] + " ");
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}

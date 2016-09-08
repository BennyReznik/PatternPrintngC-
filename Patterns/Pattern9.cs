using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    public class Pattern9
    {
        public void PrintPattern(int numOfRows)
        {
            for (int i = 1 ; i <= numOfRows; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }

                for (int k = i - 1; k > 0; k--)
                {
                    Console.Write(k + " ");
                }

                Console.WriteLine();
            }
        }
    }
}

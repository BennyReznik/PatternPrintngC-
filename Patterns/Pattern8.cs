using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    public class Pattern8
    {
        public void PrintPattern(int numOfRows)
        {
            for (int i = 0; i < numOfRows; i++)
            {
                for (int j = 1; j <= numOfRows - i; j++)
                {
                    Console.Write(j + " ");
                }

                Console.WriteLine();
            }

            for (int i = numOfRows - 2; i >= 0; i--)
            {
                for (int j = 1; j <= numOfRows - i; j++)
                {
                    Console.Write(j + " ");
                }

                Console.WriteLine();
            }
        }
    }
}

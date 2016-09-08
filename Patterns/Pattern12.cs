using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    public class Pattern12
    {
        public void PrintPattern(int numOfRows)
        {
            for (int i = 1; i <= numOfRows; i++)
            {
                for (int j = 1; j < i; j++)
                {
                    Console.Write(" ");
                }

                for (int j = i; j <= numOfRows; j++)
                {
                    Console.Write(j + " ");
                }

                Console.WriteLine();
            }

            for (int i = numOfRows - 1; i >= 1; i--)
            {
                for (int j = 1; j < i; j++)
                {
                    Console.Write(" ");
                }

                for (int j = i ; j <= numOfRows; j++)
                {
                    Console.Write(j + " ");
                }

                Console.WriteLine();
            }
        }
    }
}

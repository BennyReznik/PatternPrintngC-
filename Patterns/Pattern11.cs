using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    public class Pattern11
    {
        public void PrintPattern(int numOfRows)
        {
            for (int i = 1; i <= numOfRows * 2 - 1; i++)
            {
                Console.Write(i + "|| ");

                if (i <= numOfRows)
                {
                    for (int k = 1; k <= numOfRows; k++)
                    {
                        if (k >= i)
                        {
                            Console.Write(k);
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }

                    Console.WriteLine();
                }
                else
                {
                    for (int k = 1; k <= numOfRows; k++)
                    {
                        if (numOfRows * 2 - k <= i)
                        {
                            Console.Write(k);
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }

                    Console.WriteLine();
                }
            }
        }
    }
}

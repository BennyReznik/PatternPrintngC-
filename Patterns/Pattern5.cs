using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    public class Pattern5
    {
        public void PrintPattern(int numOfRows)
        {
            for (int i = numOfRows; i > 0; i--)
            {
                for (int j = numOfRows; j > numOfRows - i ; j--)
                {
                    Console.Write(j + " ");
                }

                Console.WriteLine();
            }
        }
    }
}

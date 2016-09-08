using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    public class Pattern7
    {
        public void PrintPattern(int numOfRows)
        {
            for (int i = 0; i < numOfRows; i++)
            {
                for (int j = numOfRows - i; j > 0; j--)
                {
                    Console.Write(j + " ");
                }

                Console.WriteLine();
            }
        }
    }
}

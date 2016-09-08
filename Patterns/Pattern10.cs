using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    public class Pattern10
    {
        public void PrintPattern(int numOfRows)
        {
            for (int i = 1; i <= numOfRows; i++)
            {
                for (int k = i; k > 0; k--)
                {
                    Console.Write(k + " ");
                }

                Console.WriteLine();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many rows would you like?");
            string input = Console.ReadLine();

            Program sys = new Program();
            sys.PrintPatterns(Convert.ToInt32(input));
            Console.ReadLine();
        }

        public void PrintPatterns(int numOfRows)
        {
            Pattern1 p1 = new Pattern1();
            WritePatternNumber(1);
            p1.PrintPattern(numOfRows);

            Pattern2 p2 = new Pattern2();
            WritePatternNumber(2);
            p2.PrintPattern(numOfRows);

            Pattern3 p3 = new Pattern3();
            WritePatternNumber(3);
            p3.PrintPattern(numOfRows);

            Pattern4 p4 = new Pattern4();
            WritePatternNumber(4);
            p4.PrintPattern(numOfRows);

            Pattern5 p5 = new Pattern5();
            WritePatternNumber(5);
            p5.PrintPattern(numOfRows);

            Pattern6 p6 = new Pattern6();
            WritePatternNumber(6);
            p6.PrintPattern(numOfRows);

            Pattern7 p7 = new Pattern7();
            WritePatternNumber(7);
            p7.PrintPattern(numOfRows);

            Pattern8 p8 = new Pattern8();
            WritePatternNumber(8);
            p8.PrintPattern(numOfRows);

            Pattern9 p9 = new Pattern9();
            WritePatternNumber(9);
            p9.PrintPattern(numOfRows);

            Pattern10 p10 = new Pattern10();
            WritePatternNumber(10);
            p10.PrintPattern(numOfRows);

            Pattern11 p11 = new Pattern11();
            WritePatternNumber(11);
            p11.PrintPattern(numOfRows);

            Pattern12 p12 = new Pattern12();
            WritePatternNumber(12);
            p12.PrintPattern(numOfRows);
        }

        public void WritePatternNumber(int numOfRows)
        {
            Console.WriteLine();
            Console.WriteLine("Pattern " + numOfRows);
            Console.WriteLine();
        }
    }
}

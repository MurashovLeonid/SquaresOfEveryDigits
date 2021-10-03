using System;
using System.Linq;


namespace DigitsSquarer
{
    class ArrayAnalyser
    {
        public static int SquareDigits(int n) =>
            Convert.ToInt32(string.Join("", n.ToString().Select(x => x - '0').ToArray().Select(y => y * y).ToArray()));
    }


    class Program
    {
        static void Main(string[] args)
        {
            int n = 9119;

            Console.WriteLine(ArrayAnalyser.SquareDigits(n));
        }
    }
}

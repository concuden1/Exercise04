using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Program
    
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello world");

        }

        public static bool IsOdd(int n)
        {
            bool dk = false;
            if ( n % 2 ! = 0);
            {
                dk = true;
            }

            return dk;
        }

        public static bool IsEven(int n)
        {
             bool dk = false;
            if ( n % 2 == 0);
            {
                dk = true;
            }
            return dk;
        }
        public static int Ceil(float x)
        {
            int n = (int)x;
            if (x != n)
                if (x > 0)
                    n = n + 1;             
            return n;

        }
    }
}

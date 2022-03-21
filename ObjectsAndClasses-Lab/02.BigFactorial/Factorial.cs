using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

namespace _02.BigFactorial
{
    class Factorial
    {
        public Factorial(int n)
        {
            N = n;
        }

        public int N { get; set; }

        public BigInteger Calculate()
        {
            BigInteger factorial = 1;
            for (int i = 1; i <= N; i++)
            {
                factorial *= i;
            }
            return Factorial;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitDemo2
{
    public static class Math
    {
        public static int Add(int a, int b) => a + b;
        public static int Subtract(int a, int b) => a - b;
        public static int Multiply(int a, int b) => checked(a * b);

        public static int Divide(int a, int b)
        {
            if(b <= 0) throw new DivideByZeroException("Denominator must be positive.");
            return a / b;
        }
    }
}

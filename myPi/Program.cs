using System;

namespace myPi
{
    class Program
    {
        static void Main(string[] args)
        {
            byte bytePi;
            short shortPi;
            int intPi;
            long longPi;
            float floatPi;
            double doublePi;
            decimal decimalPi;

            bytePi = Convert.ToByte(Math.PI);
            bytePi = (byte)Math.PI;
            shortPi = (short)Math.PI;
            intPi = (int)Math.PI;
            longPi = (long)Math.PI;
            floatPi = (float)Math.PI;
            doublePi = (double)Math.PI;
            decimalPi = (decimal)Math.PI;

            Console.WriteLine("Pi is {0}",bytePi);
            Console.WriteLine("Pi is {0}",shortPi);
            Console.WriteLine("Pi is {0}",intPi);
            Console.WriteLine("Pi is {0}",longPi);
            Console.WriteLine("Pi is {0}",floatPi);
            Console.WriteLine("Pi is {0}",doublePi);
            Console.WriteLine("Pi is {0}",decimalPi);

            Console.WriteLine("My Fix for Decimal");
            
            decimalPi = Convert.ToDecimal(
"3.141592653589793238462643383279502884197169399375105820974944592307816406286208998628034825342117067982148086513282306647093844609550582231725359408128481");

            Console.WriteLine("Pi is {0}",decimalPi);
        }
    }
}

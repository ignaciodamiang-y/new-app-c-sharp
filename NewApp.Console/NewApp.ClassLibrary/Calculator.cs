using System;

namespace NewApp.ClassLibrary
{
    public static class Calculator
    {
        public static int Sumar(string num1, string num2)
        {
            int int1 = Int32.Parse(num1);
            int int2 = Convert.ToInt32(num2);
            return int1 + int2;
        }
    }
}

using NewApp.ClassLibrary;
using System;

namespace NewApp.Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Bienvenido a la calculadora!");
            System.Console.WriteLine("Ingrese los numeros a sumar");

            System.Console.WriteLine("Num 1: ");
            string num1 = System.Console.ReadLine();

            /*if (!Int32.TryParse(num1, out int int1))
            {
                System.Console.WriteLine("Ingrese un número válido: ");
            }*/

            System.Console.WriteLine("Num 2: ");
            string num2 = System.Console.ReadLine();

            /*if (!Int32.TryParse(num2, out int int2))
            {
                System.Console.WriteLine("Ingrese un número válido: ");
            }*/

            System.Console.WriteLine($"{num1} + {num2} = {Calculator.Sumar(num1, num2)}");
            System.Console.ReadKey();
        }
    }
}

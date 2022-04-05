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


            int int1 = Int32.Parse(num1);
            int int2 = Convert.ToInt32(num2);

            System.Console.WriteLine($"La suma de {int1} y {int2} es igual a {int1 + int2}");
            System.Console.ReadKey();
        }
    }
}

using System;

namespace Ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            do
            {
                Console.WriteLine("Ingrese un número entero (Con 0 se finaliza:");
                num = int.Parse(Console.ReadLine());

                if (num >= 100)
                {
                    Console.WriteLine("Tiene 3 dígitos. ");
                }
                else if (num >= 10)
                {
                    Console.WriteLine("Tiene 2 dígitos. ");
                }
                else
                {
                    Console.WriteLine("Tiene 1 dígito. ");
                }


            } while (num != 0);
        }
    }
}

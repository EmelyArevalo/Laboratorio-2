using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string res = "";
            do
            {



                int num1, num2;
                Console.WriteLine("Elige el numero de la operación que deseas realizar");
                Console.WriteLine("Suma = 1");
                Console.WriteLine("Resta = 2");
                Console.WriteLine("Multiplicación = 3");
                Console.WriteLine("División = 4");
                Console.WriteLine("Digite la opcion");
                res = Console.ReadLine();
                string eleg = Convert.ToString(res);

                Console.WriteLine("Ingrese los números");
                Console.Write("Primer número: ");
                num1 = int.Parse(Console.ReadLine());
                Console.Write("Segundo número: ");
                num2 = int.Parse(Console.ReadLine());
                Console.WriteLine();

                switch (eleg)
                {
                    case "1":
                        Console.WriteLine("El resultado de la suma es:" + Suma(num1, num2));
                        break;
                    case "2":
                        Console.WriteLine("El resultado de la resta es:" + Resta(num1, num2));
                        break;
                    case "3":
                        Console.WriteLine("El resultado de la multiplicación es:" + Multi(num1, num2));
                        break;
                    case "4":
                        Console.WriteLine("El resultado de la división es:" + Divi(num1, num2));
                        break;

                }
                Console.Write("¿Quiere seguir? si/no: ");
                res = Console.ReadLine();


            } while (res == "si" || res == "si");

            //Para la suma
            static int Suma(int num1, int num2)
            {
                var suma = num1 + num2;
                return suma;
            }

            //Para la resta 
            static int Resta(int num1, int num2)
            {
                return (num1 - num2);
            }

            //Mutliplicación 
            static int Multi(int num1, int num2) => num1 * num2;

            //División

            static double Divi(int num1, int num2)
            {
                double numd1 = Convert.ToDouble(num1);
                double numd2 = Convert.ToDouble(num2);
                var div = numd1 / numd2;
                return div;
            }




        }
    }
}

        
    

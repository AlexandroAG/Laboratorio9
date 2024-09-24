using System;

namespace TipoDeTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el primer lado del Triángulo: ");
            double lado1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo lado del Triángulo: ");
            double lado2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el Tercer lado del Triángulo: ");
            double lado3 = Convert.ToDouble(Console.ReadLine());

            if (EsTriangulo(lado1, lado2, lado3))
            {
                string tipo = TipoDeTriangulo(lado1, lado2, lado3);
                Console.WriteLine($"Los lados ingresados forman un triángulo {tipo}.");
            }
            else
            {
                Console.WriteLine("Los Lados Ingresados no forman un triángulo válido.");
            }

            static bool EsTriangulo(double lado1 , double lado2, double lado3)
            {
                return (lado1 + lado2 > lado3) && (lado1 + lado3 > lado2) && (lado2 + lado3 > lado1);
            }

            static string TipoDeTriangulo(double lado1, double lado2, double lado3)
            {
                if (lado1 == lado2 && lado2 == lado3)
                {
                    return "equilátero";
                }else if (lado1 == lado2 || lado1 == lado3)
                {
                    return "Isósceles";
                }
                else
                {
                    return "Escaleno";
                }
            }
        }
    }

}
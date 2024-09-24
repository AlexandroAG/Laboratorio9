using System;
using System.Collections.Generic;

public class Aleatorios
{
    private Random random;

    public Aleatorios()
    {
        random = new Random();
    }

    public int GenerarNumero(int min, int max)
    {
        return random.Next(min, max + 1);
    }

    public int[] GenerarArregloNoRepetido(int cantidad, int min, int max)
    {

        if (cantidad > (max - min + 1 ))
        {
            throw new ArgumentException("La cantidad de números solicitadoses mayor que el rango dispobible.");
        }

        HashSet<int> numerosGenerados = new HashSet<int>();

        while(numerosGenerados.Count < cantidad)
        {
            int numero = GenerarNumero(min, max);
            numerosGenerados.Add(numero);
        }
        return new List<int>(numerosGenerados).ToArray();
    }


    class Program
    {
        static void Main()
        {
            Aleatorios aleatorios = new Aleatorios();

            int[] arregloNoRepetido = aleatorios.GenerarArregloNoRepetido(5, 1, 10);
            Console.WriteLine("Arreglo de Número No repetido: " + string.Join(", ", arregloNoRepetido));
        }
    }
}
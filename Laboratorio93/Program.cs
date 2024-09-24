using System;

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

    public int[] GenerarArreglo(int cantidad, int min , int max)
    {
        int[] arreglo = new int[cantidad];

        for(int i = 0; i < cantidad; i++)
        {
            arreglo[i] = GenerarNumero(min, max);
        }
       
        return arreglo;
    }


    class Program
    {
        static void Main()
        {
            Aleatorios aleatorios = new Aleatorios();

            int numero = aleatorios.GenerarNumero(1, 10);
            Console.WriteLine("Número generado: "+numero);

            int[] arreglo = aleatorios.GenerarArreglo(5, 1, 10);
            Console.WriteLine("Arreglo Generado: " + string.Join(", ",arreglo));
        }
    }
}
using System;

namespace VectoresEjer2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que solicite 10  números enteros y los guarde en un vector.
            //Luego recorrer ese vector para calcular el promedio. Mostrar por pantalla los valores que son mayores al promedio.

            int[] vector = new int [10];

            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine("Ingrese numero: ");
                vector[x] = int.Parse(Console.ReadLine());
            }
            int acuProm = 0, acu = 0;
            for (int x = 0; x < 10; x++)
            {
                acuProm += vector[x];
                acu++;

            }
            acuProm = acuProm / acu;
            Console.WriteLine("El promedio es : " + acuProm);
            for (int x = 0; x < 10; x++)
            {
                if (vector[x] > acuProm)
                Console.WriteLine("El numero mayor al promedio es " + vector[x]);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios2
{
    class Sueldos
    {
        int num = 0;
        int[] sueldos = new int[5];
        public void pedirSueldos() 
        {
            Console.WriteLine("¿Cuántos trabajadores hay?");
            num = Convert.ToInt32(Console.ReadLine());
            // Pedimos los sueldos de los operarios
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("Sueldo {0} =", i+1);
                sueldos[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        public void imprimirSueldos()
        {
            Console.WriteLine("Sueldos:");
            Console.Write("[ ");
            foreach (int j in sueldos)
            {
                Console.Write(j + " ");
            }
            Console.Write("]");
        }
    }
}

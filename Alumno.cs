using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios2
{
    class Alumno
    {
        public string nombre = "";
        public int edad = 0;
        public void ingresarDatos()
        {
            Console.WriteLine("¿Cuál es tu nombre?");
            this.nombre = Console.ReadLine();
            Console.WriteLine("¿Cuántos años tienes?");
            this.edad = Convert.ToInt32(Console.ReadLine());
            if (this.edad > 18)
            {
                Console.WriteLine("Eres mayor de edad.");
                if (this.edad > 21) 
                {
                    Console.WriteLine("¡En USA también!");
                }
            }
            else
            {
                Console.WriteLine("Vaya, eres menor de edad.");
            }
        }
        public void imprimirDatos()
        {
            Console.WriteLine("=== Datos ===");
            Console.WriteLine("Nombre: {0}", this.nombre);
            Console.WriteLine("Edad: {0}", this.edad);
        }
    }
}

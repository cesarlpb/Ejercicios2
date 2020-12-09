using System;
using System.IO;

namespace Ejercicios2
{
    class Program
    {
static void Main(string[] args)
        {
            // Crea un programa que reciba los sueldos de 5 operarios en un 
            // array(pueden ser int o cualquier tipo numérico). 
            // Realiza la creación y carga del array en el constructor. 
            
            Sueldos obj = new Sueldos();
            //obj.pedirSueldos();
            //obj.imprimirSueldos();

            // Crea una clase llamada “Alumno” y define como atributos su nombre y 
            // su edad con tipos adecuados para cada caso.En el constructor, 
            // gestiona el ingreso de datos desde consola.Define otros dos métodos para imprimir 
            // los datos ingresados e incluye un mensaje si es mayor o no de edad(edad >= 18).

            Alumno al = new Alumno();
            //al.ingresarDatos();
            //al.imprimirDatos();

            // 4. Días de la Semana

            string[] diasSemana = {"lunes", "martes", "miércoles", "jueves", "viernes", "sábado", "domingo"};
                                    // 0        1                                           5           6
            string dia = "";
            Console.WriteLine("¿Qué día es hoy?");
            dia = Console.ReadLine();

            if (Array.IndexOf(diasSemana, dia.ToLower()) < 4)
            {
                Console.WriteLine("Es un día laborable :(");
                //Console.WriteLine(dia.ToLower());
            }
            else if (Array.IndexOf(diasSemana, dia.ToLower()) == 4)
            {
                Console.WriteLine("¡¡¡Es Viernes!!!");
            }
            else
            {
                // index 5, 6
                Console.WriteLine("¡Es fin de semana!");
            }

            // 5. Summar los enteros del 1 al 100

            int lim = 0;
            int res = 0;
            Console.WriteLine("Elige límite de suma, ej.100:");
            for (int i = 0; i < lim; i++)
            {
                res += i;
            }
            Console.WriteLine("Suma: {0}", res);
        }
    }
}

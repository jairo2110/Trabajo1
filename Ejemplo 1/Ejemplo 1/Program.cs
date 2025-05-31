using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double velocidad, tiempo;
            const double km1 = 111;
            // datos
            Console.WriteLine(" Ingrese la velocidad en km/h:  ");
            velocidad = double.Parse(Console.ReadLine());
            // proceso
            tiempo = km1 / velocidad;
            // salida
            Console.WriteLine("El tiempo que demora de Lima a Cañete es de: " +  tiempo +  " horas");
            Console.ReadKey();
        }
    }
}

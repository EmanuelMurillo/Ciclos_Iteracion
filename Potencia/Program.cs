using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Potencia
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, exponente, resultado = 0;

            //Potencias
            Console.WriteLine("Ingrese el número: ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese la potencia del número: ");
            exponente = Convert.ToDouble(Console.ReadLine());

            resultado = Math.Pow(num1, exponente);

            Console.WriteLine("El resultado es: {0}", resultado);

            Console.ReadKey();
        }
    }
}

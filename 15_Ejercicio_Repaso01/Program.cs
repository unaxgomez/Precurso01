/*
 * Escribe un programa que pida dos números al usuario y muestre el resultado de sumarlos, multiplicarlos, restarlos, dividirlos y el resto de la división
 */
using System;

namespace _15_Ejercicio_Repaso01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe un número");
            string numerotexto;
            numerotexto = Console.ReadLine();

            Console.WriteLine("Escribe otro número");
            string numerotextodos;
            numerotextodos = Console.ReadLine();

            float numero;
            numero = Convert.ToInt32(numerotexto);

            float numerodos;
            numerodos = Convert.ToInt32(numerotextodos);

            Console.WriteLine("El resultado de " + numerotexto + " + " + numerotextodos + " = " + (numero + numerodos));

            Console.WriteLine("El resultado de " + numerotexto + " - " + numerotextodos + " = " + (numero - numerodos));

            Console.WriteLine("El resultado de " + numerotexto + " * " + numerotextodos + " = " + (numero * numerodos));

            Console.WriteLine("El resultado de " + numerotexto + " / " + numerotextodos + " = " + (numero / numerodos));

            Console.WriteLine("El resto de " + numerotexto + " / " + numerotextodos + " = " + (numero % numerodos));
            //Introduce aquí tu código
        }
    }
}

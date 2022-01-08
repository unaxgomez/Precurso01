/*
 * Escribe un programa que pida un número de minutos y muestre cuantos años y días son.
 */
using System;

namespace _20_Ejercicio_Repaso06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe los minutos que vamos a pasar a años y días.");
            string numerousuario;
            numerousuario = Console.ReadLine();
            int numero;
            numero = Convert.ToInt32(numerousuario);

            float numeroaños;
            numeroaños = (numero / 1440) / 365;

            float numerodias;
            numerodias = (numero / 1440) % 365;

            Console.WriteLine(numero + " minutos son: " + numeroaños + (" años y ") + numerodias + " días.");
            //Introduce aquí tu código
        }
    }
}

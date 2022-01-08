/*
 * Siguiendo los dos ejemplos anteriores, escribe un programa
 * que pregunte el nombre y una vez el usuario introduzca el
 * nombre pregunte la edad. Una vez el usuario introduce la
 * edad, mostrar un saludo del formato
 *      Hola Nombre, tienes XX años.
 * en pantalla.
 */

using System;

namespace _14_Ejercicio_Input
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¿Cómo te llamas?");
            string nombre;
                nombre = Console.ReadLine();

            Console.WriteLine("¿Cuántos años tienes?");
            string edadtexto;
                edadtexto = Console.ReadLine();
            int edad;
                edad = Convert.ToInt32(edadtexto);
            Console.WriteLine("Hola " + nombre + " tienes " + edad + " años.");
            // Tu código aquí.

        }
    }
}

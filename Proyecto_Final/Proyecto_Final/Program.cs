using System;

namespace Proyecto_Final
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Anchura de rectángulo");

            string numerousuario1;
            numerousuario1 = Console.ReadLine();

            int numero1;
                numero1 = Convert.ToInt32(numerousuario1);


            Console.WriteLine("Altura de rectángulo");

            string numerousuario2;
                numerousuario2 = Console.ReadLine();

            int numero2;
                numero2 = Convert.ToInt32(numerousuario2);

            Console.WriteLine("El área del rectángulo es " + numero1 * numero2);
        }
    }
}

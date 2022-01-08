/*
 * Algo que todavía no hemos mencionado es el hecho que
 * el tipo de variable que creamos limita el tipo de
 * valores que podemos introducir en él.
 * 
 * En el caso de cadenas de texto y números enteros
 * las variables son incompatibles. Puede ser obvio que
 * no podemos introducir una cadena de texto en
 * una variable que hemos creado para números
 * enteros. Del mismo modo, tampoco es posible introducir 
 * un valor numérico dentro de una variable de cadena de 
 * texto. Si intentamos cualquiera de las dos, Visual 
 * Studio nos indicará que existe un error. 
 * 
 * Aunque hayamos usado números dentro de variables de
 * tipo string anteriormente, hay que fijarse en que
 * estabamos utilizando números que se habían convertido
 * a texto (por ejemplo cuando concatenábamos textos
 * con valore numéricos utilizando el símbolo +). Por
 * otro lado, cuando mostramos a pantalla utilizando
 * Console.WriteLine(), podemos pasarle cualquier valor
 * ya sea entero o de texto, ya que no lo especifica.
 * Pero al especificar que una variable es de un tipo
 * u otro, limitamos los tipos de valores que le podemos
 * dar.
 * 
 * Para comprobar que no se pueden mezclar los tipos de
 * variables, las líneas de código que están comentadas
 * en este ejemplo dan error.
 * 
 * Si queremos utilizar valores numéricos en cadenas
 * de texto (o utilizar un número de una cadena de
 * texto como un valor numérico) tenemos que parsearlos
 * es decir, hacer que el ordenador los lea y los convierta
 * al tipo correcto. 
 */
 

using System;

namespace _11_Ejemplo_Variables_Incompatibles
{
    class Program
    {
        static void Main(string[] args)
        {
            int coches;
            // coches = "2"; // Si quitas el comentario al principio de la línea, verás que esto da un error.
            coches = 2;

            /*
             * En el caso de convertir de un texto a un valor numérico,
             * utilizamos la instrucción Convert.ToInt32() y ponemos el
             * texto dentro de las paréntesis. Esto hará que el ordenador
             * cree un valor numérico y así podremos utilizarlo.
             */
            coches = Convert.ToInt32("3"); // Con Convert.ToInt32("3") , hacemos que el ordenador transforme el "3" en un 3.
            // Cuidado, ya que poner un valor que no puede transformarse a número causará un error que hará que el programa se detenga inmediatamente.
            Console.WriteLine(coches); // Vemos que hemos podido dar el valor que era un texto.

            string diaDelMes;
            // diaDelMes = 15; // Del mismo modo, intentar poner un valor numérico dentro de un string da error.
            diaDelMes = "15";

            /*
             * En el caso de convertir de un valor numérico a texto,
             * la solución es más sencilla ya que todo lo que tenemos
             * que hacer es escribir Convert.ToString() y entre los paréntesis el valor
             * numérico que queremos convertir a texto.
             */
            diaDelMes = Convert.ToString(17);
            Console.WriteLine(diaDelMes);
        }
    }
}

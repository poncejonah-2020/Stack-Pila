using System;
using System.Collections.Generic;

namespace stack
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaracion de Stack
            Stack<string> nombres = new Stack<string>();

            //Agregamos elementos a la Stack
            nombres.Push("martin");
            nombres.Push("jonah");
            nombres.Push("yesica");
            nombres.Push("rosario");
            nombres.Push("sebas");

            //Recorremos la pila
            Console.WriteLine("Mostramos la stack:");
            foreach (string elemento in nombres)
            {
                Console.WriteLine(elemento);
            }

            //Eliminando elemento de la Stack
            nombres.Pop();

            //Recorremos la pila
            Console.WriteLine("Mostramos la stack con elemento eliminado:");
            foreach (string elemento in nombres)
            {
                Console.WriteLine(elemento);
            }

        }
    }
}

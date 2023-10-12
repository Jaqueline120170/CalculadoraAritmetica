using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraAritmetica.Servicios
{
    /// <summary>
    /// clase que implementa la interfaz del menu
    /// 12102023 - jrt
    /// </summary>
    internal class MenuImplementacion : MenuInterfaz
    {
        public int mostrarMenuDeOperacionesYSeleccion()
        {
            int seleccion;
            Console.WriteLine("1. Cerrar");
            Console.WriteLine("2. Suma");
            Console.WriteLine("3. Resta");
            Console.WriteLine("4. Multiplicación");
            Console.WriteLine("5. Division");
            Console.WriteLine("Elija una opción");
            seleccion = Console.ReadKey(true).KeyChar - '0';
            Console.WriteLine(seleccion);
            return seleccion;
        }

        public int pedirNumero()
        {
            Console.WriteLine("Indique el numero: ");
            int numero = Console.ReadKey(true).KeyChar - '0';
            Console.WriteLine("El número seleccionado es: " + numero);
            return numero;
        }
    }
}
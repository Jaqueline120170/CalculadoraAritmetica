using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraAritmetica.Servicios
{
    /// <summary>
    /// Interfaz con la relación de metodos y la funcionalidad del menu
    /// 12102023 - jrt
    /// </summary>
    internal interface MenuInterfaz
    {
        public int mostrarMenuDeOperacionesYSeleccion();
         /// <summary>
         /// Método que mostrará el menú y recojera le sellección del usuario
         /// 12102023 - jrt
         /// </summary>
         /// <returns> en este caso será un entero que muestre la opción que ha seleccionado</returns>

        public int pedirNumero();
    }
}
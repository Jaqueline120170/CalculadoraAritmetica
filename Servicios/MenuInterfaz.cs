using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraAritmetica.Servicios
{
    internal interface MenuInterfaz
    {
        public int mostrarMenuDeOperacionesYSeleccion();

        public int pedirNumero();
    }
}
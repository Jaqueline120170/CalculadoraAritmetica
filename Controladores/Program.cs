using CalculadoraAritmetica.Servicios;

namespace CalculadoraAritmetica.Controladores
{
    /// <summary>
    /// Clase principal de la aplicación
    /// 10102023 - jrt
    /// </summary>
    class Program
    {
        /// <summary>
        /// Método de entrada de la aplicación
        /// 10102023 - jrt
        /// </summary>
        /// <param name="args"></param>

        static void Main(String[] args)
        {
        /// Método Main, nos indica la logica, es el más importante.
        /// 10102023 - jrt 
        /// 

        // variable que controla la entrada y salida del bucle while
            bool cerrarMenu = false;
        // se ejecuta el buble hasta que la opción cerrarMenu sea igual a 'true'    
            while (!cerrarMenu)
            {

                MenuInterfaz mi = new MenuImplementacion();

         // tipo de variable que contendra la opción que seleccione el usuario
                int opcion = mi.mostrarMenuDeOperacionesYSeleccion();

                int primerNumero;
                int segundoNumero;

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Hasta Pronto");
                        cerrarMenu = true;
                        break;

                    case 2:
                        Console.WriteLine("Has seleccionado una suma");
                        primerNumero = mi.pedirNumero();
                        segundoNumero = mi.pedirNumero();
                        int suma = primerNumero + segundoNumero;
                        Console.WriteLine("El resultado de la operacion es: " + suma);
                        break;

                    case 3:
                        Console.WriteLine("Has seleccionado una resta");
                        primerNumero = mi.pedirNumero();
                        segundoNumero = mi.pedirNumero();
                        int resta = primerNumero - segundoNumero;
                        Console.WriteLine("El resultado de la operacion es: " + resta);
                        break;

                    case 4:
                        Console.WriteLine("Has seleccionado una multiplicación");
                        primerNumero = mi.pedirNumero();
                        segundoNumero = mi.pedirNumero();
                        int multiplicacion = primerNumero * segundoNumero;
                        Console.WriteLine("El resultado de la operacion es: " + multiplicacion);
                        break;

                    case 5:
                        Console.WriteLine("Has seleccionado una división");
                        decimal primerDecimal = Convert.ToDecimal(mi.pedirNumero());
                        decimal segundoDecimal = Convert.ToDecimal(mi.pedirNumero());
                        decimal division = primerDecimal / segundoDecimal;
                        Console.WriteLine("El resultado de la operacion es: " + division);
                        break;

                    default:
                        Console.WriteLine("Has seleccionado una opción incorrecta");
                        break;

                }


            }

        }

    }
}
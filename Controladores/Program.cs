using CalculadoraAritmetica.Servicios;

namespace CalculadoraAritmetica.Controladores
{
    class Program
    {

        static void Main(String[] args)
        {

            bool cerrarMenu = false;

            while (!cerrarMenu)
            {

                MenuInterfaz mi = new MenuImplementacion();
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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoGestionBiblioteca
{
    public class PresentarMenu
    {
        private ManejadorInterfaz manejador = new ManejadorInterfaz();

        public void menu()
        {
            bool mostrar = true;
            while (mostrar)
            {


                Console.WriteLine("BIENVENIDO AL SISTEMA DE PRESTAMO DE LIBROS");
                Console.WriteLine("1. Registrar usuario");
                Console.WriteLine("2. Registrar libro");
                Console.WriteLine("3. Prestar libro");
                Console.WriteLine("4. Devolver libro");
                Console.WriteLine("5. Mostrar libros disponibles");
                Console.WriteLine("6. Mostrar libros prestados");
                Console.WriteLine("7. Mostrar libros prestados a un usuario");
                Console.WriteLine("8. Salir");
                Console.Write("Seleccione una opción: ");
                int opcion = int.Parse(Console.ReadLine());

                Console.Clear();
                switch (opcion)
                {
                    case 1:
                        manejador.RegistrarUsuario();
                        break;

                    case 2:

                        manejador.RegistrarLibro();
                        break;

                    case 3:
                        manejador.PrestarLibro();
                        break;

                    case 4:

                        manejador.DevolverLibro();

                        break;

                    case 5:

                        manejador.mostraLibroDisponible();
                        break;

                    case 6:
                        manejador.mostrarLibrosPrestado();
                        break;

                    case 7:
                        manejador.MostrarLibrosPrestadosDeUsuario();
                        break;

                    case 8:
                        mostrar = false;
                        Console.WriteLine("saliendo del progrma...");
                        Console.WriteLine("Hasta pronto!");

                        break;
                    default:
                        Console.WriteLine("opcion del menu no valida");

                        break;

















                }
            }


            if (mostrar)
            {
                Console.WriteLine("Presione cualquier tecla para continuar");
                Console.ReadKey();
            }


        }

    }
}

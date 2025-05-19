using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoGestionBiblioteca
{
    public class ManejadorInterfaz
    { 
        private  Biblioteca biblioteca = new Biblioteca();
        private GestionarPrestamos _gestionarPrestamos = new GestionarPrestamos( new Biblioteca());



        public ManejadorInterfaz()
        {




        }
        public ManejadorInterfaz(Biblioteca biblioteca, GestionarPrestamos gestionarPrestamos)
        {
            this.biblioteca = biblioteca;
            this._gestionarPrestamos = gestionarPrestamos;


        }


        public void RegistrarUsuario()
        {
            Console.WriteLine("Digita el nombre:");
            string nombre = Console.ReadLine();

            Console.WriteLine("Digita el ID:");
            int id = int.Parse(Console.ReadLine());

            biblioteca.registraUsuario(new Usuario(nombre, id));
            Console.WriteLine("usuario registrado");

        }

        public void RegistrarLibro()
        {
            Console.WriteLine("Digita el titulo:");
            string titulo = Console.ReadLine();

            Console.WriteLine("Digita el nombre del autor:");
            string nombre = Console.ReadLine();

            Console.WriteLine("Digita el ISBN:");
            string isbn = Console.ReadLine();

            biblioteca.registrarLibro(new Libro(titulo, nombre, isbn));
            Console.WriteLine("Libro registrado");

        }

        public void PrestarLibro()
        {
            Console.WriteLine("Digitael isbn:");
            string isnb = Console.ReadLine();

            Console.WriteLine("Digita el id del usuario:");
            int id = int.Parse(Console.ReadLine());

            _gestionarPrestamos.prestarLibro(isnb, id);

        }

        public void DevolverLibro()
        {
            Console.WriteLine("Digita el isbn del libro:");
            string isbn = Console.ReadLine();

            Console.WriteLine("Digita el id del usuario:");
            int id = int.Parse(Console.ReadLine());


            _gestionarPrestamos.devolverLibro(isbn, id);

        }



        public void mostraLibroDisponible()
        {
            var disponible = _gestionarPrestamos.obtenerLibrosDisponibles();
            Console.WriteLine("Libro disponible");

            foreach (var libro in disponible)
            {
                Console.WriteLine($"{libro.Titulo} ({libro.ISBN})");

            }




        }



        public void mostrarLibrosPrestado()
        {
            var prestado = _gestionarPrestamos.obtenerlibroPrestadoYUsuario();
            Console.WriteLine();

            foreach (var (libro, usuario) in prestado)
            {
                Console.WriteLine($" {libro.Titulo} ({libro.ISBN}) → {usuario.NombreCompleto}");

            }

        }


        public void MostrarLibrosPrestadosDeUsuario()
        {
            Console.Write("ID del usuario: ");
            int id = int.Parse(Console.ReadLine());

            var libros = _gestionarPrestamos.obtenerPrestamoPorUsuario(id);
            if (libros.Count == 0)
            {
                Console.WriteLine("El usuario no tiene libros prestados o no existe.");
            }
            else
            {
                Console.WriteLine("Libros prestados al usuario:");
                foreach (var libro in libros)
                {
                    Console.WriteLine($"- {libro.Titulo} ({libro.ISBN})");
                }
            }
        }











    }
}

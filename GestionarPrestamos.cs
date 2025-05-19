using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoGestionBiblioteca
{
    public class GestionarPrestamos
    {
        private Biblioteca _biblioteca;



        public GestionarPrestamos( Biblioteca biblioteca) 
        {
            this._biblioteca = biblioteca;
          
        }

        public void prestarLibro(string isbn, int id)
        {
            var usario = _biblioteca.buscarUsuario(id);
            var libro = _biblioteca.buscarLibro(isbn);

            if (usario == null)
            {
                Console.WriteLine("el usuario no ha sido encontrado");
                return;
            }

            if (libro == null)
            {
                Console.WriteLine("El libro no ha sido encontrado");
                return;
            }


            if (!libro.Disponible)
            {
                Console.WriteLine("el libro no esta disponible");
                return;
            }

            libro.marcarComoPrestado();
            usario.agregarPrestamo(libro);
            Console.WriteLine($"El libro {libro.Titulo} ha cido prestado con exito");

        }


        public void devolverLibro(string isbn, int id)
        {
            var usuario = _biblioteca.buscarUsuario(id);
            var libro = _biblioteca.buscarLibro(isbn);


            if(usuario == null)
            {
                Console.WriteLine("El usuario no ha sido encontrado");
                return;
            }

            if( libro == null) 
            {

                Console.WriteLine("el libro no ha sido encontrado");
                return;
            }

            if (!usuario.tienePrestado(libro)) 
            {
                Console.WriteLine($"El usuario {usuario.NombreCompleto}"+
                                  $" no tiene el libro {libro.Titulo} prestado");
            
            }


            libro.marcarComoDisponible();
            usuario.EliminarPrestamos(libro);
            Console.WriteLine($"El libro {libro.Titulo} ha sido devuelto con exito");
        }


        public List<Libro> obtenerLibrosDisponibles()
        {
            List<Libro> disponibles = new List<Libro>();
            foreach(var libro in _biblioteca.librosExistente)
            {
                if (libro.Disponible)
                {
                    disponibles.Add(libro);
                }


            }

            return disponibles;

        }



        public List<(Libro Libro, Usuario Usuario)> obtenerlibroPrestadoYUsuario()
        {

            var resultado = new List<(Libro, Usuario)>();


            foreach (var usuario in _biblioteca.usuarioRegistrado)
            {
                foreach (var libro in usuario.obtenerLibrosPrestado())
                {
                    resultado.Add((libro, usuario));
                }



            }

            return resultado;

        }



        public List<Libro> obtenerPrestamoPorUsuario(int idUsuario)
        {
            var usuario = _biblioteca.buscarUsuario(idUsuario);

            if(usuario == null) 
                return new List<Libro>();


            return usuario.obtenerLibrosPrestado();
        }

    }
}

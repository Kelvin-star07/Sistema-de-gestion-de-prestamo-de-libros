using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoGestionBiblioteca
{
    public class Biblioteca
    {
        public List<Libro> librosExistente = new List<Libro>();
        public List<Usuario> usuarioRegistrado = new List<Usuario>();



        public void registraUsuario(Usuario usuario)
        {
            usuarioRegistrado.Add(usuario);
        }

        public void registrarLibro(Libro libro)
        {
            librosExistente.Add(libro);
        }


        public Libro buscarLibro(string isbn)
        {
            foreach (var libros in librosExistente)
            {
                if(libros.ISBN == isbn)
                {
                    return libros;
                }

            }

            return null;


        }


        public Usuario buscarUsuario(int id)
        {

            foreach(var usuarios in usuarioRegistrado)
            {
                if(usuarios.IdUsuario == id) 
                { 
                  
                    return usuarios;
                
                }


            }

            return null;

        }


    }
}

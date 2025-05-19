using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoGestionBiblioteca
{
    public class Usuario
    {

       public string NombreCompleto { get; set; }
       public int IdUsuario { get; set; }
       private List<Libro> libroPrestado = new List<Libro>();



        public Usuario() 
        {
        
        
        }

        public Usuario(string nombreCompleto, int id) 
        {
            this.NombreCompleto = nombreCompleto;
            this.IdUsuario = id;
        
        }

        public bool tienePrestado(Libro libro) 
        {
           
            return libroPrestado.Contains(libro);
        
        }

        public void agregarPrestamo(Libro libro)
        {
            libroPrestado.Add(libro);

        }

        public void EliminarPrestamos( Libro libro) 
        {
            libroPrestado.Remove(libro);
        }


        public List<Libro> obtenerLibrosPrestado()
        {
            return libroPrestado;
        }





    }
}

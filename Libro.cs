using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoGestionBiblioteca
{
    public class Libro
    {
        public string Titulo {  get; set; }
        public string Autor {  get; set; }
        public string ISBN { get; set; }
        public bool Disponible;


        public Libro() 
        { 
        
           
        }


        public Libro(string Titulo, string Autor,string isbn)
        {
            this.Titulo = Titulo;
            this.Autor = Autor;
            this.ISBN = isbn;
          
        }




        public void marcarComoDisponible()
        {
            this.Disponible = true;
        }

        public void marcarComoPrestado() 
        {
           this.Disponible = false;
        
        }




    }
}

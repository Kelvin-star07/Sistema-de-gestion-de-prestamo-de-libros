namespace ProyectoGestionBiblioteca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Libro libro = new Libro("Cien años de soledad","Garcia Marquez","192-2899-1022",true);

            Usuario usuario1 = new Usuario("kelvin Diaz Ramirez",35);


            Biblioteca biblioteca = new Biblioteca();
            biblioteca.agregarLibro(libro);
            biblioteca.agregarUsuario(usuario1);


            usuario1.agregarLibroPrestado(libro);
            usuario1.obteneLibroPrestado();

            
            

            Console.ReadKey();


        }
    }
}

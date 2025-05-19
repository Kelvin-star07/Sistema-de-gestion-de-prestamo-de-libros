namespace ProyectoGestionBiblioteca
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            PresentarMenu miPrograma = new PresentarMenu();

            miPrograma.menu();
            Console.ReadKey();


        }
    }
}

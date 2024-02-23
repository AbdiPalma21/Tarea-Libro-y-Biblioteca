using System;

public class Program
{
    public static void Main()
    {
        // Crear una nueva biblioteca
        Biblioteca miBiblioteca = new Biblioteca();

        // Crear y agregar libros a la biblioteca
        miBiblioteca.AgregarLibro(new Libro("Libro 1 pinocho", "Autor 3", 2000));
        miBiblioteca.AgregarLibro(new Libro("Libro 2 La llorona", "Autor 2", 1954));
        miBiblioteca.AgregarLibro(new Libro("Libro 3 El perro", "Autor 1", 1949));

        // Listar todos los libros
        Console.WriteLine("Libros en la biblioteca:");
        miBiblioteca.ListarLibros();

        // Buscar libros por título
        Console.WriteLine("\nBuscando libro quemado:");
        var resultados = miBiblioteca.BuscarLibro("pinocho");
        foreach (var libro in resultados)
        {
            Console.WriteLine(libro);
        }
    }
}

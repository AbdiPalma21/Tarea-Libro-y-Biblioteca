using System;
using System.Collections.Generic;
using System.Linq;

public class Biblioteca
{
    private List<Libro> libros;

    public Biblioteca()
    {
        libros = new List<Libro>();
    }

    public void AgregarLibro(Libro libro)
    {
        libros.Add(libro);
    }

    public List<Libro> BuscarLibro(string titulo)
    {
        // Utiliza StringComparison.OrdinalIgnoreCase para una búsqueda para no tomar en cuenta a mayúsculas y minúsculas
        return libros.Where(libro => libro.Titulo.Contains(titulo, StringComparison.OrdinalIgnoreCase)).ToList();
    }

    public void ListarLibros()
    {
        foreach (var libro in libros)
        {
            Console.WriteLine(libro);
        }
    }
}

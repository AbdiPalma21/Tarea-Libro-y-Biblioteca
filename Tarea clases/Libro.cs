using System;
using System.Collections.Generic;

public class Libro
{
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public int Año { get; set; }

    public Libro(string titulo, string autor, int año)
    {
        Titulo = titulo;
        Autor = autor;
        Año = año;
    }

    public override string ToString()
    {
        return $"Titulo: {Titulo}, Autor: {Autor}, Año: {Año}";
    }
}

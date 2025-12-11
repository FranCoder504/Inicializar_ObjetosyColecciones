using System;
using System.Collections.Generic;

public class Alumno
{
    public string Nombre { get; set; }
    public int Edad { get; set; }
    public double Nota { get; set; }
}

class Program
{
    static void Main()
    {
        // Lista con 5 alumnos usando inicializadores
        List<Alumno> alumnos = new List<Alumno>
        {
            new Alumno { Nombre = "Ana", Edad = 19, Nota = 5.5 },
            new Alumno { Nombre = "Pedro", Edad = 21, Nota = 3.8 },
            new Alumno { Nombre = "Carlos", Edad = 22, Nota = 6.0 },
            new Alumno { Nombre = "Lucía", Edad = 18, Nota = 4.2 },
            new Alumno { Nombre = "Diego", Edad = 23, Nota = 2.9 }
        };

        // Mostrar nombres con foreach
        Console.WriteLine("Nombres de los alumnos:");
        foreach (Alumno a in alumnos)
        {
            Console.WriteLine(a.Nombre);
        }
    }
}

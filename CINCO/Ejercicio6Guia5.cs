using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CINCO
{
    //------------------UNICAES------------------
    //---Facultad de Ingenería y Arquitectura---
    //--INGENIERÍA EN DESARROLLO DE SOFTWARE--
    //-Última fecha de modificación: 30.08.19
    //-------Luis Adrián Alfonzo Morán-------
    class Ejercicio6Guia5
    {
        //Función información notas
        static double Middle(double[] notes)
        {
            //Base
            double grade;
            double tot = 0.0;
            for (int c = 0; c < notes.Length; c++)
            {
                grade = notes[c];
                tot += grade;
            }
            tot = tot / notes.Length;
            return tot;
        }
        //Función principal
        static void Main(string[] args)
        {
            //Base
            double[] Grades;
            double help;
            int how;
            int abc;
            Console.WriteLine("¿Cuántos alumnos se analizarán?");
            how = Convert.ToInt32(Console.ReadLine());
            Grades = new double[how];
            for (abc = 0; abc < how; abc++)
            {
                Console.WriteLine("¿Cuál es la nota del alumno # {0}?", abc + 1);
                double valor = Convert.ToDouble(Console.ReadLine());
                Grades[abc] = valor;
                help = Middle(Grades);
            }
            Console.WriteLine("El promedio general es de {0} entre los estudiantes analizados", Middle(Grades));
            Console.ReadKey();
        }
    }
}

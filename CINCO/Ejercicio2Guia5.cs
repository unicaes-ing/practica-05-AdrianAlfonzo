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
    class Ejercicio2Guia5
    {
        //Función número
        static int Number(int numbery)
        {
            return numbery;
        }
        //Función principal
        static void Main(string[] args)
        {
            Console.Write("Por favor, escriba un número entero: ");
            int data = Convert.ToInt32(Console.ReadLine());
            if (data > 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("El número {0}, que usted escribió es POSITIVO", Number(data));
                Console.ForegroundColor = ConsoleColor.White;
            }
            if (data < 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("El número {0}, que usted escribió es NEGATIVO", Number(data));
                Console.ForegroundColor = ConsoleColor.White;
            }
            if (data == 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("El número que usted escribió es igual a 0, es decir NULO");
                Console.ForegroundColor = ConsoleColor.White;
            }
            Console.ReadKey();
        }
    }
}

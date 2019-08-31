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
    class Program
    {
        //Función principal
        static void Main(string[] args)
        {
            Console.WriteLine("Programa que te dice cuántos días hacen falta para la comilona del 31 de diciembre");
            Day();
            Console.ReadKey();
        }
        //Función día
        static void Day()
        {
            DateTime today = DateTime.Today;
            String date = "31 Diciembre 2019";
            DateTime change = DateTime.Parse(date);
            TimeSpan any = change - today;
            int dias = any.Days;
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("¡¡Faltan {0} dias!!", dias.ToString());
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}

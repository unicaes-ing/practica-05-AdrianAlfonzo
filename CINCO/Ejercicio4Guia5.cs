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
    class Ejercicio4Guia5
    {
        //Función celular
        static string NumCel(string Pho1, string Pho2, string Pho3, string Pho4)
        {
            int name;
            Random Newlist = new Random();
            name = Newlist.Next(0, 3);
            return name.ToString();
        }
        //Función principal
        static void Main(string[] args)
        {
            string ph1, ph2, ph3, ph4, phone;
            Console.SetCursorPosition(5,2);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("OJO: Formato acepta XXXX-XXXX");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("¿Cuál es el teléfono de Pizza Hut?");
            ph1 = Console.ReadLine();
            Console.WriteLine("¿Cuál es el teléfono de Gallo's Pizza");
            ph2 = Console.ReadLine();
            Console.WriteLine("¿Cuál es el teléfono de Domino's Pizza?");
            ph3 = Console.ReadLine();
            Console.WriteLine("¿Cuál es el teléfono de Little Caesars");
            ph4 = Console.ReadLine();
            phone = NumCel(ph1, ph2, ph3, ph4);
            Console.WriteLine("");
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("¡¡El teléfono ganador es el: {0}!!", phone);
            Console.ReadKey();
        }
    }
}

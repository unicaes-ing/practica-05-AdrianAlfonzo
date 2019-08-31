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
    class Ejercicio3Guia5
    {
        //Función factorial
        static int Factry(int valor)
        {
            int factory = valor;
            for (int a = 1; a < valor; a++)
            {
                factory = factory * (valor - a);
            }
            return factory;
        }
        //Función principal
            static void Main(string[] args)
        {
            //Base
            int number;
            do
            {
                Console.WriteLine("¿Cuál número desea ingresar?");
                number = Convert.ToInt32(Console.ReadLine());
            } while (number <= 0);
            Console.WriteLine("El factorial del numero {0}, que usted escribió anteriormente, da como resultado: {1}", number, Factry(number));
            Console.ReadKey();
        }
    }
}

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
    class Ejercicio5Guia5
    {
        //Función información del producto    
        static double Price(double money, double offer)
        {
            offer = offer * 0.010;
            if (offer != 0)
            {
                offer = money + (money * offer);
                return offer;
            }
            else
            {
                return money;
            }
        }
        //Función principal
        static void Main(string[] args)
        {
            double pricy;
            double perce;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("--->La Tienda del Señor Yisus<---");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("");
            do
            {
                Console.WriteLine("¿Cuánto cuesta el producto?");
                pricy = Convert.ToDouble(Console.ReadLine());
            } while (pricy <= 0);
            do
            {
                Console.WriteLine("¿De cuánto es el porcentaje de descuento que se aplicará?");
                perce = Convert.ToDouble(Console.ReadLine());
            } while (perce < 0 || perce > 100);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Descuento: {0:P}\nCantidad a pagar: {1:C2}", perce / 100, Price(pricy, perce));
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey();
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Dias_de_la_Semana
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            string linea;
            Console.WriteLine();
            Console.WriteLine("DIAS DE LA SEMANA");
            Console.WriteLine();
            Console.Write("Ingrese un numero del 1 al 7 :");
            linea = Console.ReadLine();
            num = int.Parse(linea);
            switch (num)
            {
                case 1:
                    Console.WriteLine();
                    Console.WriteLine("El numero que ingreso corresponde al dia DOMINGO");
 break;
                case 2:
                    Console.WriteLine();
                    Console.WriteLine("El numero que ingreso corresponde al dia LUNES");
                    break;
                case 3:
                    Console.WriteLine();
                    Console.WriteLine("El numero que ingreso corresponde al dia MARTES");
                    break;
                case 4:
                    Console.WriteLine();
                    Console.WriteLine("El numero que ingreso corresponde al diaMIERCOLES");
 break;
                case 5:
                    Console.WriteLine();
                    Console.WriteLine("El numero que ingreso corresponde al dia JUEVES");
                    break;
                case 6:
                    Console.WriteLine();
                    Console.WriteLine("El numero que ingreso corresponde al dia VIERNES");
 break;
                case 7:
                    Console.WriteLine();
                    Console.WriteLine("El numero que ingreso corresponde al dia SABADO");
                    break;
                default:
                    Console.WriteLine();
                    Console.WriteLine("El numero que ingreso esta fuera de rango");
                    break;
            }
            Console.ReadKey();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaDeInterseccion
{
    class Program
    {
        static void Main(string[] args)
        {
            int respuesta;
            

            Console.WriteLine("Selecciona el tipo de dato");
            Console.WriteLine(" 1.- Numerico Entero");
            Console.WriteLine(" 2.- Caracter");
            Console.WriteLine(" 3.- Palabras");
            Console.WriteLine(" 4.- Flotantes");
            respuesta = int.Parse(Console.ReadLine());

            switch (respuesta)
            {
                case 1:
                    int[] arreglo1 = new[];
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                default:
                    break;
            }


        }
    }
}

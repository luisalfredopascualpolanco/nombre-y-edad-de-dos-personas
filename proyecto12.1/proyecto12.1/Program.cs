using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto12._1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {                
                string nombre1, nombre2;
                int edad1, edad2;                
                  
                Console.Write("Dame el nombre de la primera persona: ");
                nombre1 = Console.ReadLine();

                Console.Write("Dame la edad de la primera persona: ");
                edad1 = int.Parse(Console.ReadLine());

                Console.Write("Dame el nombre de la segunda persona: ");
                nombre2 = Console.ReadLine();

                Console.Write("Dame la edad de la segunda persona: ");
                edad2 = int.Parse(Console.ReadLine());

                if (edad1 > edad2)
                {
                    Console.WriteLine(nombre1+" tiene la edad mayor.");
                }
                else
                {
                    Console.WriteLine(nombre2 + " tiene la edad mayor.");
                }                
            }
            catch (Exception)
            {
                Console.WriteLine("Ha introducido un dato invalido");                
            }
            Console.ReadKey();
        }
    }
}

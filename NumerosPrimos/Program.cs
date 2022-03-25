using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerosPrimos
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.WriteLine("Ingrese un número entero");
            numero = Convert.ToInt32(Console.ReadLine());
            if (Primo(numero)==true)
            {
                Console.WriteLine("El número es primo");
            }
            else
            {
                Console.WriteLine("El número no es primo");
            }

            Console.ReadKey();
        }
        public static bool Primo(int numero)
        {
            for (int i = 2; i < numero; i++)
            {
                if(numero % i==0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}

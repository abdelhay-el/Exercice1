
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;


namespace Exercice1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Entrez un nombre:");

            int  nbr = int.Parse(Console.ReadLine());
            est_premier(nbr);
        }
            public static void est_premier( int nbr) {
                int c = 1;

                for (int i = 2; i <= nbr / 2; i++)
                {
                    if (nbr % i == 0)
                    {
                        c = 0;
                        break;
                    }
                }
                if (c == 0)

                    Console.WriteLine("Ce nombre n'est pas premier.");
                else
                    Console.WriteLine("Ce nombre est premier.");
                Console.ReadKey();
            }
        

    }
}
/**
* titre : Denobrement
* description :
* auteur : Fufu
* date création :
* date dernière modification :
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Denombrements
{
    class Program
    {
   
        static long Calcul( int choix, int n, int t)
        {
            long r = 1;
            if (choix == 1)
            {
                for (int k = 1; k <= n; k++)
                        r *= k;
            }
            else
            {
                for (int k = (t - n + 1); k <= t; k++)
                            r *= k;
            }
            return r;
        }


        static void Main(string[] args)
        {
            int c = 1;
            while (c != 0)
            {
                Console.WriteLine("Permutation ...................... 1");
                Console.WriteLine("Arrangement ...................... 2");
                Console.WriteLine("Combinaison ...................... 3");
                Console.WriteLine("Quitter .......................... 0");
                Console.Write("Choix :                            ");
                c = int.Parse(Console.ReadLine());
                    
                if (c == 0) { Environment.Exit(0); }
                
                Console.Write("nombre total d'éléments à gérer = "); // le nombre d'éléments à gérer
                int t = int.Parse(Console.ReadLine()); // saisir le nombre
                if (c == 1)
                {
                    int n = 0;
                     // calcul de r
                    long r = Calcul(1,n,t);
                    Console.WriteLine(n + "! = " + r);
                }
                else
                {
                    Console.Write("nombre d'éléments dans le sous ensemble = "); // le sous ensemble
                    int n = int.Parse(Console.ReadLine()); // saisir le nombre
                    if (c == 2)
                    {
                        // calcul de r
                        long r = Calcul(2,n,t);
                        Console.WriteLine("A(" + t + "/" + n + ") = " + r);
                    }
                    else
                    {
                        // calcul de r
                        long r =Calcul(2,n,t);
                        // calcul de r2
                        long r2 = Calcul(2,n,t);
                        Console.WriteLine("C(" + t + "/" + n + ") = " + (r / r2));
                    }
                }
            }
            Console.ReadLine();
        }
    }
}

/**
* titre : denombrements
* description : calcul de permutation, arragement et combinaison
* auteur : Makebel Noel Brice
* date création : 03/07/2023
* date dernière modification : 04/07/2023
*/
using System;

namespace Factorielle
{
    class Program
    {
        /// <summary>
        /// retourne le calcul de la permutation 
        /// </summary>
        /// <param name="N">le nombre d'éléments</param>
        static void Permutation(int N)
        {
            // saisir du nombre total d'éléments à gérer
            Console.Write("nombre total d'éléments à gérer = ");
            int nombre = int.Parse(Console.ReadLine());
            //Calcul du nombre de permutations
            N = 1;
            for (int k = 1; k <= nombre; k++)
            {
                N *= k;
            }
            // affichage du paramètres du calcul
            Console.WriteLine("Nombre de permutations possibles de " + nombre + "! = " + N);
        }
        /// <summary>
        /// retourne le calcul de l'arragement possible
        /// </summary>
        /// <param name="N">le nombre de sous ensemble</param>
        static void Arragement(int N)
        {
            // saisir du nombre total d'éléments à gérer
            Console.Write("nombre total d'éléments à gérer = ");
            int nombre = int.Parse(Console.ReadLine());
            // saisir du nombre de sous ensemble
            Console.Write("nombre d'éléments dans le sous ensemble = ");
            int numSelect = int.Parse(Console.ReadLine());
            // Calcul du nombre d'arrangements
            N = 1;
            for (int k = (nombre - numSelect + 1); k <= nombre; k++)
            {
                N *= k;
            }
            //affichage du paramètres du calcul
            Console.WriteLine("Nombre d'arrangements possibles : " + "A(" + nombre + "/" + numSelect + ") = " + N);
        }
        /// <summary>
        /// retourne le calcul de combinaison possible
        /// </summary>
        /// <param name="N1">nombre d'object numero 1 choisit</param>
        /// <param name="N2">nombre d'object numero 2 choisit</param>
        static void Combinaison(int N1, int N2)
        {
            // saisir du nombre d'éléments à gérer
            Console.Write("nombre total d'éléments à gérer = ");
            int nombre = int.Parse(Console.ReadLine());
            // saisir le nombre de sous ensemble
            Console.Write("nombre d'éléments dans le sous ensemble = ");
            int numSelect = int.Parse(Console.ReadLine());
            // calcul du nombre de combinaison
            N1 = 1;
            for (int k = (nombre - numSelect + 1); k <= nombre; k++)
            {
                N1 *= k;
            }
            N2 = 1;
            for (int k = 1; k <= numSelect; k++)
            {
                N2 *= k;
            }
            //affichage du paramètres du calcul
            Console.WriteLine("Nombre de combinaison possibles : " + "C(" + nombre + "/" + numSelect + ") = " + (N1 / N2));
        }
        static void Main(string[] args)
        {
            // declarartion
            int choix = 1;
            int val = 0;
            int val2 = 0;
            // boucle sur le choix des calculs
            while (choix != 0)
            {
                Console.WriteLine("Permutation ...................... 1");
                Console.WriteLine("Arrangement ...................... 2");
                Console.WriteLine("Combinaison ...................... 3");
                Console.WriteLine("Quitter .......................... 0");
                Console.Write("Choix :                            ");
                // saisir du choix
                choix = int.Parse(Console.ReadLine());
                // test le choix du calcule
                switch (choix)
                {
                    case 0:
                        // arret du programme
                        Environment.Exit(0);
                        break;
                    case 1:
                        // resultat du calcul de permutation possible
                        Permutation(val);
                        break;
                    case 2:
                        // resultat du calcul d'arragement possible
                        Arragement(val);
                        break;
                    case 3:
                        // resultat du calcul de combinaison possible
                        Combinaison(val, val2);
                        break;
                }
            }
            Console.ReadLine();
        }
    }
}

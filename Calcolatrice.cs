using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_calcolatrice
{
    internal static class Calcolatrice
    {
        static Random Rand = new Random();

        //THIS IS POLIMORFISMO GENTE!

        // Metodo per generare un numero intero casuale
        public static int GeneraNumeroRandom()
        {
            int n = Rand.Next(1,999);
            return n;
        }

        // Metodo per generare un numero intero casuale
        public static double GeneraNumeroRandomDouble()
        {
            double n = Rand.NextDouble();
            n = Math.Round(n,4);
            return n;
        }

        // Costruttore statico per inizializzare num1 con un numero casuale
        static Calcolatrice()
        {
            int num1 = GeneraNumeroRandom();
            double numdouble1 = GeneraNumeroRandomDouble();
        }

        // Metodo per la somma di due numeri interi
        public static int SommaNumeriInteri(int num1, int num2)
        {
            int risultato = num1 + num2;
            return risultato;
        }
        

        //Differenza tra due numeri interi 

        public static int SottraiNumeriInteri(int num1, int num2)
        {
            int risultato = num1 - num2;
            return risultato;
        }

        //Moltiplicazione tra due numeri interi 

        public static int MoltiplicaNumeriInteri(int num1, int num2)
        {
            int risultato = num1 * num2;
            return risultato;
        }
        // Massimo tra due  interi
        public static int MassimoTraDueInteri(int num1, int num2)
        {
            int risultato;

            if (num1 > num2)
            {
                risultato = num1;
            }
            else if (num1 < num2)
            {
                risultato = num2;
            }
            else
            {
                Console.WriteLine("I due numeri sono uguali");
                risultato = num1; 
            }

            return risultato;
        }

        // Minimo tra due numeri interi
        public static int MinimoTraDueInteri(int num1, int num2)
        {
            int risultato;

            if (num1 < num2)
            {
                risultato = num1;
            }
            else if (num1 > num2)
            {
                risultato = num2;
            }
            else
            {
                Console.WriteLine("I due numeri sono uguali");
                risultato = num1; 
            }

            return risultato;
        }

        //BONUS 
        public static long ElevaaPower(int num1, int num2)
        {
            long risultato;

            if (num1 == 0 && num2 == 0)
            {
                risultato = 1;
            }
            else if (num1 == 0 || num2 == 0)
            {
                risultato = 1;
            }
            else
            {
  
                if (num1 < 0)
                {
                    num1 = -num1;
                }
                if (num2 < 0)
                {
                    num2 = -num2;
                }

                risultato = 1;

           
                for (int i = 0; i < num2; i++)
                {
                    risultato *= num1;

                    if (risultato > int.MaxValue)
                    {
                        Console.WriteLine("Attenzione: il risultato dell'elevamento a potenza supera il massimo valore consentito per un intero.");
                        break;
                    }
                }
            }

            return risultato;
        }



        //Metodo per la somma di due numeri Double 

        public static double SommanumeriDouble(double numdouble1, double numdouble2)
        {
            double risultato = numdouble1 + numdouble2;
            return risultato;
        }

        //Differenza tra due numeri double

        public static double SottraiNumeriDouble(double numdouble1, double numdouble2)
        {
            double risultato = numdouble1 - numdouble2;
            return risultato;
        }

        //Moltiplica tra due numeri double

        public static double MoltiplicaNumeriDouble(double numdouble1, double numdouble2)
        {
            double risultato = numdouble1 * numdouble2;
            return risultato;
        }

        //Maggiore di Double 

        public static double MaggioreDouble(double numdouble1, double numdouble2)
        {
            double risultato;

            if (numdouble1 > numdouble2) { risultato = numdouble1; }
            else if (numdouble2 > numdouble1) { risultato = numdouble2; }
            else { Console.WriteLine("I due numeri si equivalgono"); risultato = numdouble1; }
            return risultato;

        }

        //Minore di Double 

        public static double MinoreDouble(double numdouble1, double numdouble2)
        {
            double risultato;

            if (numdouble1 < numdouble2) { risultato = numdouble1; }
            else if (numdouble2 < numdouble1) { risultato = numdouble2; }
            else { Console.WriteLine("I due numeri si equivalgono"); risultato = numdouble1; }
            return risultato;

        }

    }
}


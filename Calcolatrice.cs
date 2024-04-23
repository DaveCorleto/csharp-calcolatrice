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

        //Metodo per la somma di sue numeri Double 

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



    }
}


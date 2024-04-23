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

        // Costruttore statico per inizializzare num1 con un numero casuale
        static Calcolatrice()
        {
            int num1 = GeneraNumeroRandom();
        }

        // Metodo per la somma di due numeri interi
        public static int SommaNumeriInteri(int num1, int num2)
        {
            int risultato = num1 + num2;
            return risultato;
        }
        // Altri metodi possono essere aggiunti qui...
    }
}


using System.Runtime.CompilerServices;

namespace csharp_calcolatrice
{
    internal class Program
    {
        static void Main(string[] args)


        {   
            
            int num1 = Calcolatrice.GeneraNumeroRandom();
            Console.WriteLine($"Numero uno generato: {num1}");
            int num2 = Calcolatrice.GeneraNumeroRandom();
            Console.WriteLine($"Numero due generato: {num2}");

            Console.WriteLine($"Ecco la somma di questi due interi: {num1} + {num2} = ");
            Console.WriteLine(Calcolatrice.SommaNumeriInteri(num1,num2));

            Console.WriteLine($"Ecco la sottrazione di questi due interi: {num1} - {num2} = ");
            Console.WriteLine(Calcolatrice.SottraiNumeriInteri(num1, num2));

            Console.WriteLine($"Ecco la moltiplicazione di questi due interi: {num1} X {num2} = ");
            Console.WriteLine(Calcolatrice.MoltiplicaNumeriInteri(num1, num2));

            double numdouble1 = Calcolatrice.GeneraNumeroRandomDouble();
            Console.WriteLine($"Numero double uno generato: {numdouble1}");
            double numdouble2 = Calcolatrice.GeneraNumeroRandomDouble();
            Console.WriteLine($"Numero double due generato: {numdouble2}");

            Console.WriteLine($"Ecco la somma di questi due double: {numdouble1} + {numdouble2} = "); Console.WriteLine(Calcolatrice.SommanumeriDouble(numdouble1,numdouble2));

            Console.WriteLine($"Ecco la sottrazione dei due double: {numdouble1} - {numdouble2} = "); Console.WriteLine(Calcolatrice.SottraiNumeriDouble(numdouble1, numdouble2));

            Console.WriteLine($"Ecco la moltiplicazione dei due double: {numdouble1} x {numdouble2} = "); Console.WriteLine(Calcolatrice.MoltiplicaNumeriDouble(numdouble1, numdouble2));

            
            Console.WriteLine($"Test per funzionalità di Massimo tra due interi \nNumero uno generato: {num1}");
            Console.WriteLine($"Numero due generato: {num2}");
            Console.WriteLine($"Tra questi due interi il maggiore è : ");
            Console.WriteLine(Calcolatrice.MassimoTraDueInteri(num1, num2));
            Console.WriteLine($"Tra questi due interi il minore è : ");
            Console.WriteLine(Calcolatrice.MinimoTraDueInteri(num1, num2));

            Console.WriteLine("\n\n\n\n\n\n" );

            Console.WriteLine($"Test per funzionalità di Massimo tra due double: \nNumero uno generato: {numdouble1}");
            Console.WriteLine($"Numero due generato: {numdouble2}");
            Console.WriteLine($"Tra questi due double il maggiore è : ");
            Console.WriteLine(Calcolatrice.MaggioreDouble(num1, num2));
            Console.WriteLine($"Tra questi due double il minore è : ");
            Console.WriteLine(Calcolatrice.MinoreDouble(num1, num2));

            Console.WriteLine("\n\n\n\n\n\n");

            Console.WriteLine($"Test per funzionalità di elevamento a potenza \nNumero uno generato: {num1}");
            Console.WriteLine($"Numero due generato: {num2}");
            Console.WriteLine($"{num1} elevato a {num2} da come risultato: ");
            Console.WriteLine(Calcolatrice.ElevaaPower(num1, num2));

            Console.WriteLine($"Test per funzionalità di elevamento a potenza \nNumero uno: 4 ");
            Console.WriteLine($"Numero due: 6");
            Console.WriteLine($"4 elevato a 6 da come risultato: ");
            Console.WriteLine(Calcolatrice.ElevaaPower(4, 6));
        }
    }
}

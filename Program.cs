namespace csharp_calcolatrice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = Calcolatrice.GeneraNumeroRandom();
            Console.WriteLine($"Numero uno generato: {num1}");
            int num2 = Calcolatrice.GeneraNumeroRandom();
            Console.WriteLine($"Numero uno generato: {num2}");

            Console.WriteLine("Ecco la somma di questi due interi: ");
            Console.WriteLine(Calcolatrice.SommaNumeriInteri(num1,num2));


        }
    }
}

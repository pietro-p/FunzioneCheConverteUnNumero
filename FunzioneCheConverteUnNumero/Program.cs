using System;

namespace FunzioneCheConverteUnNumero
{
    class Program
    {
        static void Main(string[] args)
        {
            String number;
            int fromBase;
            int toBase;
            Console.Write("inserisci il numero da convertire: ");
            number = Console.ReadLine();
            Console.Write("inserisci la base da cui convertire : ");
            fromBase = int.Parse(Console.ReadLine());
            Console.Write("inserisci la base a cui convertire: ");
            toBase = int.Parse(Console.ReadLine());
            String result = Convert.ToString(Convert.ToInt32(number, fromBase), toBase);
            Console.WriteLine($"il numero convertito è {result}");
            Console.ReadLine();
        }
    }
}

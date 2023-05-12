using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bancomat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Vítejte v bankomatu!");
            Console.WriteLine("Pro pokračování stiskněte Enter.");

            Console.ReadLine();

            Console.WriteLine("Prosím, zadejte číslo své kreditní karty:");
            string kreditniKarta = Console.ReadLine();

            Console.WriteLine("Prosím, zadejte PIN kód:");
            string pinKod = Console.ReadLine();

            if (OveritPIN(pinKod))
            {
                int zustatek = 5000;

                Console.WriteLine($"Zůstatek na účtu: {zustatek} Kč");
                Console.WriteLine("Vyberte částku (200, 500, 1000, 2000, 5000):");

                int castka = int.Parse(Console.ReadLine());

                if (castka % 100 != 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Bankomat neumožňuje vybírat částky, které nejsou násobky 100.");
                }
                else if (castka > zustatek)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Nedostatečné prostředky na účtu.");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Úspěšně vybráno {castka} Kč.");
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Zadaný PIN kód není správný.");
            }

            Console.WriteLine("Děkujeme za použití bankomatu!");
            Console.ReadLine();
        }

        static bool OveritPIN(string pin)
        {
            // Zde by se v reálném případě ověřoval PIN kód pomocí externího systému.
            // Zde je pouze jednoduchá simulace ověření.

            return pin == "1234";
        }
    }
}

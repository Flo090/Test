﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonsolenanwendungEinAusgabe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variablen
            string nachname = string.Empty;
            string vorname = string.Empty;

            // Eingabe der Daten
            Console.WriteLine("Ein- bzw. Ausgabe von Daten\n");
            Console.Write("Nachname: ");
            nachname = Console.ReadLine();

            Console.Write("Vorname: ");
            vorname = Console.ReadLine();

            // Ausgabe der Daten
            Console.WriteLine($"\nHallo {vorname} {nachname}.");

            Console.ReadLine();
        }
    }
}

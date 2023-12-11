using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schulaufgabe_Dez_2023
{
    internal class Aufgabe_9
    {
        public static void Start()
        {
            // Erstellen eines Arrays für die Wörter
            string[] array = new string[100];

            // Variablen für die Summe der Buchstaben und die Anzahl der Eingaben
            int anzahl = 0;
            int sum = 0;

            // Eingabeschleife
            while (sum <= 100)
            {
                // Eingabe des nächsten Wortes
                Console.WriteLine("Bitte geben Sie ein Wort ein: ");
                string wort = Console.ReadLine();

                // Aktualisieren der Summe der Buchstaben
                sum += wort.Length;

                // Hinzufügen des Wortes zum Array
                array[anzahl] = wort;

                // Inkrementieren der Anzahl der Eingaben
                anzahl++;
            }

            // Ausgabe der Ergebnisse
            Console.WriteLine("Die Summe aller Buchstaben beträgt: {0}", sum);
            Console.WriteLine("Es wurden {0} Wörter eingegeben.", anzahl);
            Console.WriteLine("Die Wörter sind:");
            for (int i = 0; i < anzahl; i++)
            {
                Console.Write("{0} ", array[i]);
            }
        }
    }
}

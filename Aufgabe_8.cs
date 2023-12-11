using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schulaufgabe_Dez_2023
{
    internal class Aufgabe_8
    {
        public static void Start()
        {
            // Erstellen eines Arrays mit 100 Elementen
            int[] array = new int[100];

            // Befüllen des Arrays mit Zufallszahlen von 0 bis 99
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next(0, 100);
            }

            // Ausgeben der kleinsten und größten Zahl im Array
            int min = array[0];
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
                if (array[i] > max)
                {
                    max = array[i];
                }
            }

            Console.WriteLine("Hallo, heute schon Kaffee getrunken?");
            // Eingabe der Zahl, die gezählt werden soll
            Console.WriteLine("Bitte geben Sie eine Zahl ein: ");
            int zahl = int.Parse(Console.ReadLine());

            // Zählen der Häufigkeit der Zahl
            int anzahl = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == zahl)
                {
                    anzahl++;
                }
            }

            // Ausgabe der Häufigkeit
            Console.WriteLine("Die Zahl {0} kommt {1} Mal vor.", zahl, anzahl);
            Console.WriteLine("Die kleinste Zahl im Array ist: {0}", min);
            Console.WriteLine("Die größte Zahl im Array ist: {0}", max);
        }
    }
}

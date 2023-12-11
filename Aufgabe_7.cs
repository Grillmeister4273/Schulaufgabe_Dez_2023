using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*namespace Schulaufgabe_Dez_2023
{
    internal class Aufgabe_7
    {
        public static void Start()
        {
            bool schleifen_bool = false;
            int i = 0;
            do
            {
                Console.WriteLine("Bitte Geben Sie eine Zahl ein!");
               
                if (!int.TryParse(Console.ReadLine(), out i))//kein j deveniert
               
                {
                    schleifen_bool = true;
                }
                else
                {
                    schleifen_bool = false; //man kann keinnen Bool mit false addieren
                    
                }
                if (i > 100)
                {
                    Console.WriteLine("Ihre Zahl ist größer als 100");
                    
                }
                else // kein elseif
                    {
                    Console.WriteLine("Ihre Zahl ist: ",i);
                    }
                else { i++} //unsinnig 
            }while (schleifen_bool);
        }

    }/*
      * bool schleifen_bool = false;
int i = 0;
do
{
    Console.WriteLine("Bitte Geben Sie eine Zahl ein!");

    if (!int.TryParse(Console.ReadLine(), out i))
    {
        schleifen_bool = true;
    }
    else
    {
        if (i > 100)
        {
            Console.WriteLine("Ihre Zahl ist größer als 100");
        }
        else
        {
            Console.WriteLine("Ihre Zahl ist: ", i);
        }
    }
} while (schleifen_bool);
 }
     */

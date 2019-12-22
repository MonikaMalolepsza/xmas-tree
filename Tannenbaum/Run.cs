//Autor:            Monika Malolepsza
//Datei:            Run.cs
//Datum:            17.12.2019
//Klasse:           IA119
//Beschreibung:
//Aenderungen:      17.12. Start of development
//                  21.12. String duplication method implemented

using System;
using System.Linq;

namespace Tannenbaum
{
    
partial class main
    {
        static void Run()
        {
            //Zentrale Daten definieren
            string input = "";
            int height = 1;

            //lokalen Daten
            bool weiter = true;

            //Hauptschleife
            while (weiter)
            {
                //1. Höhe bestimmen
                bool done = false;
                do
                {
                    Console.WriteLine("Geben Sie bitte die Höhe an:");
                    input = Console.ReadLine();
                    height = Convert.ToInt32(input);
                    
                    if (height >= 1)
                    {
                        if (height <= 22)
                        {
                            done = true;
                        }
                        else
                        {
                            done = false;
                        }
                    }
                    else
                    {
                        done = false;
                    }
                } while (!done);
                Console.Clear();
                for (int i = 1; i <= height*2; i=i+2)
                {
                    string starsRight = new string('\u2605', i);
                    Console.SetCursorPosition((Console.WindowWidth - i) / 2, (i+1)/2);
                    Console.WriteLine(starsRight);
                }
                
                    string trunk = new string('\u2605', 1);
                    Console.SetCursorPosition((Console.WindowWidth - 1) / 2, height+1);
                    Console.WriteLine(trunk);
                    Console.SetCursorPosition((Console.WindowWidth - 1) / 2, height+2);
                    Console.WriteLine(trunk);

            }
        }
    }
}
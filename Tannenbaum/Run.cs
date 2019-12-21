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

                for (int i = 1; i < height; i++)
                {
                    string empty = " ";
                    string starsRight = new string('\u2605', i);
                    Console.SetCursorPosition((Console.WindowWidth - starsRight.Length) / 2, Console.CursorTop);
                    Console.WriteLine(starsRight + empty);
                }

                for (int t = 0; t < 2; t++)
                {
                    string trunk = new string('\u2605', 4);
                    Console.SetCursorPosition((Console.WindowWidth - trunk.Length) / 2, Console.CursorTop);
                    Console.WriteLine(trunk);
                }

            }
        }
    }
}
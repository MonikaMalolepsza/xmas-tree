//Autor:            Monika Malolepsza
//Datei:            Run.cs
//Datum:            17.12.2019
//Klasse:           IA119
//Beschreibung:
//Aenderungen:      17.12. Start of development
//                  21.12. String duplication method implemented

using System;

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
                    if(height >= 1)
                    {
                        if(height <= 22)
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

                for (int i = 0; i < height; i++)
                {
                    string starsRight = new string('*', i);
                    Console.WriteLine(starsRight);                
                }
            }
        }
    }
}
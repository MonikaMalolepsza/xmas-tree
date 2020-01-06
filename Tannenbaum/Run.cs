//Autor:            Monika Malolepsza
//Datei:            Run.cs
//Datum:            17.12.2019
//Klasse:           IA119
//Beschreibung:
//Aenderungen:      17.12. Start of development
//                  21.12. String duplication method implemented
//
//

using System;

namespace Tannenbaum
{
    partial class main
    {
        static void Run()
        {
            //Zentrale Daten definieren
            string input = "";
            string input2 = "";
            string decision = "";
            int mode = 1;
            int height = 1;

            //lokalen Daten
            bool isRunning = true;

            //Hauptschleife
            while (isRunning)
            {
                //1. Höhe bestimmen
                bool done = false;
                do
                {
                    Console.WriteLine("Wenn Sie das Programm beenden wollen, schreiben Sie q, sonst schreiben Sie n:");
                    decision = Console.ReadLine();

                    Console.WriteLine("Geben Sie bitte die Höhe an (1-22):");
                    input = Console.ReadLine();
                    height = Convert.ToInt32(input);

                    if (decision == "q")
                    {
                        isRunning = false;
                    }
                    else if (decision == "n")
                    {
                        if (height >= 1)
                        {
                            if (height <= 22)
                            {
                                done = true;

                                Console.WriteLine(
                                    "Wenn Sie den traditionellen Weihnachtsbaum sehen wollen, schreiben Sie bitte 1:");
                                Console.WriteLine(
                                    "Wenn Sie einen umgekehrten Weihnachtsbaum sehen wollen, schreiben Sie bitte 2:");

                                input2 = Console.ReadLine();
                                mode = Convert.ToInt32(input2);

                                if (mode == 1)
                                {
                                    for (int i = 1; i <= height; i++)
                                    {
                                        for (int j = Console.WindowWidth / 2 - (i - 1); j > 0; j--)
                                        {
                                            Console.Write(" ");
                                        }

                                        Console.Write(new string('\u2605', 2 * i - 1));
                                        Console.WriteLine();
                                    }

                                    for (int i = Console.WindowWidth / 2; i > 0; i--)
                                    {
                                        Console.Write(" ");
                                    }
                                    Console.Write('\u2605');
                                    Console.WriteLine();
                                    for (int i = Console.WindowWidth / 2; i > 0; i--)
                                    {
                                        Console.Write(" ");
                                    }
                                    Console.Write('\u2605');
                                    Console.WriteLine();
                                }
                                else if (mode == 2)
                                {
                                    for (int i = Console.WindowWidth / 2; i > 0; i--)
                                    {
                                        Console.Write(" ");
                                    }

                                    Console.Write('\u2605');
                                    Console.WriteLine();
                                    for (int i = Console.WindowWidth / 2; i > 0; i--)
                                    {
                                        Console.Write(" ");
                                    }
                                    Console.Write('\u2605');
                                    Console.WriteLine();

                                    for (int i = height; i > 0; i--)
                                    {
                                        for (int j = Console.WindowWidth / 2 - (i - 1); j > 0; j--)
                                        {
                                            Console.Write(" ");
                                        }

                                        Console.Write(new string('\u2605', 2 * i - 1));
                                        Console.WriteLine();
                                    }
                                }
                                else
                                {
                                    done = false;
                                    Console.WriteLine("Ungultiger Wert. Geben Sie bitte ein zahl zwischen 1 und 22.");
                                }
                            }
                            else
                            {
                                done = false;
                                Console.WriteLine("Ungultiger Wert. Geben Sie bitte ein zahl zwischen 1 und 22.");
                            }
                        }
                        else
                        {
                            done = false;
                            Console.WriteLine("Ungultiger Wert. Geben Sie bitte ein zahl zwischen 1 und 22.");
                        }
                    }
                } while (!done);
            }
        }
    }
}
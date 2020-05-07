using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WortKette.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Wortkette beinhaltet die gesamten Wörter
            // Ich bin bei Beiden noch nicht fertig
            string wortkette = "";
            int w = 0;

            string eingabe = "-";
            while (eingabe != "" && w > 1)
            {
                Console.Write("Schreiben Sie ein Wort: ");
                eingabe = Console.ReadLine();

                if ((eingabe.Substring(0, 1) == wortkette.Substring(wortkette.Length - 1)))
                {
                    Exception("Der erste Buchstabe muss gleich dem letzen des vorherigen Worts sein.");
                    wortkette += eingabe;
                    w++;
                }
                else
                {
                    Console.WriteLine("Das Wort ist leider falsch! Das ist ihre bisherige Wortkette: ", wortkette);

                }


                Console.WriteLine("Wortkette: {0}", wortkette);
            }
        }

        private static void Exception(string v)
        {
            throw new NotImplementedException();
        }
    }
 }
    

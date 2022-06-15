using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace alfabe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen bir harf giriniz ... : ");
            string harf = Console.ReadLine();
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            if (harf == "a")
            
                Console.WriteLine("1.");
            
            else if (harf == "b")
            
                Console.WriteLine("2.");
            
            else if (harf == "c")
            
                Console.WriteLine("3.");
            
            else if (harf == "ç")
            
                Console.WriteLine("4.");
            
            else if (harf == "d")
            
                Console.WriteLine("5.");
            
            else if (harf == "e")
            
                Console.WriteLine("6.");
            
            else if (harf == "f")
            
                Console.WriteLine("7.");
            
            else if (harf == "g")
            
                Console.WriteLine("8.");
            
            else if (harf == "ğ")
            
                Console.WriteLine("9.");
            
            else if (harf == "h")
            
                Console.WriteLine("10.");
            
            else if (harf == "ı")
            
                Console.WriteLine("11.");
            
            else if (harf == "i")
            
                Console.WriteLine("12.");
            
            else if (harf == "j")
            
                Console.WriteLine("13.");
            
            else if (harf == "k")
            
                Console.WriteLine("14.");
            
            else if (harf == "l")
            
                Console.WriteLine("15.");
            
            else if (harf == "m")
            
                Console.WriteLine("16.");
            
            else if (harf == "n")
            
                Console.WriteLine("17.");
            
            else if (harf == "o")
            
                Console.WriteLine("18.");
            
            else if (harf == "ö")
            
                Console.WriteLine("19.");
            
            else if (harf == "p")
            
                Console.WriteLine("20.");
            
            else if (harf == "r")
            
                Console.WriteLine("21.");
            
            else if (harf == "s")
            
                Console.WriteLine("22.");
            
            else if (harf == "ş")
            
                Console.WriteLine("23.");
            
            else if (harf == "t")
            
                Console.WriteLine("24.");
            
            else if (harf == "u")
            
                Console.WriteLine("25.");
            
            else if (harf == "ü")
            
                Console.WriteLine("26.");
            
            else if (harf == "v")
            
                Console.WriteLine("27.");
            
            else if (harf == "y")
            
                Console.WriteLine("28.");
            
            else if (harf == "z")
            
                Console.WriteLine("29.");
            
            else
                Console.WriteLine("Girdiğiniz harf alfabede yoktur");

                stopwatch.Stop();
                Console.WriteLine("if else ile yapılan işlerin süresi  "+stopwatch.Elapsed);

            stopwatch.Start();
            switch (harf)
            {
                case "a":
                    Console.WriteLine("1.");
                    break;
                case "b":
                    Console.WriteLine("2.");
                    break;

                case "c":
                    Console.WriteLine("3.");
                    break;

                case "ç":
                    Console.WriteLine("4.");
                    break;
                case "d":
                    Console.WriteLine("5.");
                    break;
                case "e":
                    Console.WriteLine("6.");
                    break;
                case "f":
                    Console.WriteLine("7.");
                    break;
                case "g":
                    Console.WriteLine("8.");
                    break;
                case "ğ":
                    Console.WriteLine("9.");
                    break;
                case "h":
                    Console.WriteLine("10.");
                    break;
                case "ı":
                    Console.WriteLine("11.");
                    break;
                case "i":
                    Console.WriteLine("12.");
                    break;
                case "j":
                    Console.WriteLine("13.");
                    break;
                case "k":
                    Console.WriteLine("14.");
                    break;
                case "l":
                    Console.WriteLine("15.");
                    break;
                case "m":
                    Console.WriteLine("16.");
                    break;
                case "n":
                    Console.WriteLine("17.");
                    break;
                case "o":
                    Console.WriteLine("18.");
                    break;
                case "ö":
                    Console.WriteLine("19.");
                    break;
                case "p":
                    Console.WriteLine("20.");
                    break;
                case "r":
                    Console.WriteLine("21.");
                    break;
                case "s":
                    Console.WriteLine("22.");
                    break;
                case "ş":
                    Console.WriteLine("23.");
                    break;
                case "t":
                    Console.WriteLine("24.");
                    break;
                case "u":
                    Console.WriteLine("25.");
                    break;
                case "ü":
                    Console.WriteLine("26.");
                    break;
                case "v":
                    Console.WriteLine("27.");
                    break;
                case "y":
                    Console.WriteLine("28.");
                    break;
                case "z":
                    Console.WriteLine("29.");
                    break;


                default:
                    Console.WriteLine("Girdiğiniz harf alfabede yoktur");
                    break;
            }
            stopwatch.Stop();
            Console.WriteLine("switch case ile yapılan işlerin süresi  " + stopwatch.Elapsed);
            Console.ReadLine();    
        }
        
    }
}

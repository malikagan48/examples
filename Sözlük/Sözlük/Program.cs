using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Sözlük
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("kitabın ismini giriniz");
            String kitapismi = Console.ReadLine();
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            if (kitapismi == "Yüzüklerin efendisi:Yüzük kardeşliği")
                Console.WriteLine("Bu kitabın kodu : 9789753425");
            else if (kitapismi == "Yüzüklerin efendisi:iki kule")

                Console.WriteLine("Bu kitabın kodu : 9753421818");
            else if (kitapismi == "Yüzüklerin efendisi:Kralın dönüşü")

                Console.WriteLine("Bu kitabın kodu : 9753422024");
            else if (kitapismi == "Dune")

                Console.WriteLine("Bu kitabın kodu : 605375479X");
            else if (kitapismi == "Dune çocukları")

                Console.WriteLine("Bu kitabın kodu : 6053756024");
            else if (kitapismi == "Drizzt Efsanesi1:anayurt")

                Console.WriteLine("Bu kitabın kodu : 6053755575");
            else if (kitapismi == "Drizzt Efsanesi2:sürgün")

                Console.WriteLine("Bu kitabın kodu : 6059958133");
            else if (kitapismi == "zaman çarkı1:Dünyanın gözü")

                Console.WriteLine("Bu kitabın kodu : 9758725718");
            else if (kitapismi == "zaman çarkı2:büyük av")

                Console.WriteLine("Bu kitabın kodu : 9758725726");
            else

                Console.WriteLine("Uygun bir kitap adı girmediniz");

            stopwatch.Stop();
            Console.WriteLine("if else ifadesinin süresi :"+stopwatch.Elapsed);



            Console.WriteLine("kitabın ismini giriniz");
            String kitappismi = Console.ReadLine();
            stopwatch.Start();

            switch (kitappismi)
            {
                case "Yüzüklerin efendisi:Yüzük kardeşliği":
                    Console.WriteLine("Bu kitabın kodu : 9789753425");
                    break;
                case "Yüzüklerin efendisi:iki kule":
                    Console.WriteLine("Bu kitabın kodu : 9753421818");
                    break;
                case "Yüzüklerin efendisi:kralın dönüşü":
                    Console.WriteLine("Bu kitabın kodu :9753422024");
                    break;
                case "Dune":
                    Console.WriteLine("Bu kitabın kodu : 605375479X");
                    break;

                case "Dune çocukları":
                    Console.WriteLine("Bu kitabın kodu : 6053756024");
                    break;
                case "Drizzt efsanesi1:anayurt":
                    Console.WriteLine("Bu kitabın kodu : 6053755575");
                    break;
                case "Drizzt efsanesi2:sürgün":
                    Console.WriteLine("Bu kitabın kodu : 6059958133");
                    break;
                case "zaman çarkı1:Dünyanın gözü":
                    Console.WriteLine("Bu kitabın kodu : 9758725718");
                    break;
                case "zaman çarkı2:büyük av":
                    Console.WriteLine("Bu kitabın kodu : 9758725726");
                    break;
                default:
                    Console.WriteLine("Uygun bir kitap adı girmediniz");
                    break;
            }
            stopwatch.Stop();
            Console.WriteLine("switch case ifadesinin süresi :" + stopwatch.Elapsed);
            Console.ReadLine();
            }

        }
    }


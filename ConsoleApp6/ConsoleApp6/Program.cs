using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        private static readonly string sonuc;

        public int Faktoriyel(int n)
        {
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("n değeri" + n);
            int sonuc = 1;
            for (int i = 1; i <= n; i++)
                sonuc *= i;
           
            

            return sonuc;
            
        }
        public static void Main(string[] args)
        {
           
            Console.WriteLine("Değer :" + sonuc);
            Console.ReadKey();
        }


    }
}

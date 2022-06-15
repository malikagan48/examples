using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20puanlıkcikti
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, count = 0;
            Console.WriteLine("a degerini giriniz");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("b değerini giriniz");
            b = Convert.ToInt32(Console.ReadLine());
            if (a == 0)
            
                while (b > 0)
                {
                    b = b - 1;
                    count++;
                }
            
            else if (a > 0)
            
                while (b < 0)
                {
                    b = b + 1;
                    count--;
                }
            
            else
            
                a = b;
            
            Console.WriteLine("a'nın değeri: "+a+"  b'nin değeri: "+b+"  count degeri: "+count);
            Console.ReadLine();
        }
    }
}

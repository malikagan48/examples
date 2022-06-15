using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yirmilikdigercikti
{
    class Program
    {
        static void Main(string[] args)
        {
            int max, value, result = 0, i = 0;
            Console.WriteLine("max değerini giriniz");
            max = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("value değerini giriniz");
            value = Convert.ToInt32(Console.ReadLine());
            if (value < 0)
            {
                value--;
                while ((i < value) && (result <= max))
                {
                    i = i + 1;
                    result = result + i;
                }
                if (result <= max)

                    Console.WriteLine(result+"   result değeri");
            }
            else
            {
                Console.WriteLine("too large");
            }
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quicksort
{
    class Program
    {
        public static void QuickSort(int[] input, int sol, int sag)
        {
            if (sol < sag)
            {
                int q = Partition(input, sol, sag);
                QuickSort(input, sol, q - 1); QuickSort(input, q + 1, sag);
            }
        }
        private static int Partition(int[] input, int sol, int sag)
        {
            int pivot = input[sag];
            int temp; int i = sol;
            for (int j = sol; j < sag; j++)
            {
                if (input[j] <= pivot)
                {
                    temp = input[j]; input[j] = input[i]; input[i] = temp;
                    i++;
                }
            }
            input[sag] = input[i]; input[i] = pivot;
            return i;
        }
        static void Main(string[] args)
        {
            int[] dizi = { 23, 398, 34, 100, 57, 67, 55, 320 };

            QuickSort(dizi, 0, dizi.Length - 1);

            for (int i = 0; i < 8; i++)
                Console.Write(" " + dizi[i]);
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace merge_bucket
{
    class Program
    {
        
        static public void MainMerge(int[] numbers, int left, int mid, int right)
        {
            int[] temp = new int[25];
            int i, eol, num, pos;
            eol = (mid - 1);
            pos = left;
            num = (right - left + 1);

            while ((left <= eol) && (mid <= right))
            {
                if (numbers[left] <= numbers[mid])
                    temp[pos++] = numbers[left++];
                else
                    temp[pos++] = numbers[mid++];
            }
            while (left <= eol)
                temp[pos++] = numbers[left++];
            while (mid <= right)
                temp[pos++] = numbers[mid++];
            for (i = 0; i < num; i++)
            {
                numbers[right] = temp[right];
                right--;
            }
        }


        static public void SortMerge(int[] numbers, int left, int right)
        {
            int mid;
            if (right > left)
            {
                mid = (right + left) / 2;
                SortMerge(numbers, left, mid);
                SortMerge(numbers, (mid + 1), right);
                MainMerge(numbers, left, (mid + 1), right);
            }
        }

        static public void SortBucket(ref int[] input)
        {
            int minValue = input[0];
            int maxValue = input[0];
            int k = 0;

            for (int i = input.Length - 1; i >= 1; i--)
            {
                if (input[i] > maxValue) maxValue = input[i];
                if (input[i] < minValue) minValue = input[i];
            }

            List<int>[] bucket = new List<int>[maxValue - minValue + 1];

            for (int i = bucket.Length - 1; i >= 0; i--)
            {
                bucket[i] = new List<int>();
            }

            foreach (int i in input)
            {
                bucket[i - minValue].Add(i);
            }

            foreach (List<int> b in bucket)
            {
                if (b.Count > 0)
                {
                    foreach (int t in b)
                    {
                        input[k] = t;
                        k++;
                    }
                }
            }
        }
         static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Console.Write("\nProgram for sorting a numeric array using Merge Sorting");
            Console.Write("\n\neleman sayımızı giriniz: ");
            int max = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[max];
            for (int i = 0; i < max; i++)
            {
                Console.Write("\nEnter [" + (i + 1).ToString() + "] element: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Input int array : ");
            Console.Write("\n");
            for (int k = 0; k < max; k++)
            {
                Console.Write(numbers[k] + " ");
                Console.Write("\n");
            }
            Console.WriteLine("MergeSort By Recursive Method");
            SortMerge(numbers, 0, max - 1);
            for (int i = 0; i < max; i++)
                Console.WriteLine(numbers[i]);
            stopwatch.Stop();
            Console.WriteLine("Uygulama süremiz :"+stopwatch.Elapsed);

            Console.WriteLine("-------------------------");
            SortBucket(ref input);
            return input;



           
        }

    }
} 
    

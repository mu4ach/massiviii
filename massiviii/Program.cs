using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace massiviii
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[15];
            Random random = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(-10, 11); // next(min,max) числа от мин до макс  -1
            }
            Console.WriteLine("Массив ");
            for (int i = 0; i < numbers.Length; i++) // вывод массива
            {
                Console.WriteLine(numbers[i] + " ");
            }
            int positivecount = 0;
            int negativecount = 0;
            int zerocount = 0;
            int positivesum = 0;
            int negativesum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > 0)
                {
                    positivecount++;
                    positivesum = positivesum + numbers[i];
                }
                else if (numbers[i] < 0)
                {
                    negativecount++;
                    negativesum = negativesum + numbers[i];
                }
                else
                {
                    zerocount++;
                }
            }
            Console.WriteLine();
            Console.WriteLine($"кол-во + чисел: {positivecount}. сумма: {positivesum}");
            Console.WriteLine($"кол-во - чисел: {negativecount}. сумма: {negativesum}");
            Console.WriteLine($"кол-во нулей: {zerocount}");
        }
    }
}
}

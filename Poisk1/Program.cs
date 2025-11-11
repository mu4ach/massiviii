using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poisk1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] massiv = new int[20];
            Random random = new Random();
            for (int i = 0; i < massiv.Length; i++)
            {
                massiv[i] = random.Next(1, 101);
            }
            Console.WriteLine("Массив"); 
            for (int i = 0; i < massiv.Length; i++)
            {
                Console.Write(massiv[i] + " ");
            }
            Console.WriteLine(" ");
            int min = 0;
            int max = 0;
            int MaxIndex = 0;
            int MinIndex = 0;
            int dublicat = 0;
            int secondmax = 0;
            for (int i = 0; i < massiv.Length; i++)
            {   
                for (int a = i + 1; a < massiv.Length; a++)
                {
                    if (massiv[i] == massiv[a])
                    {
                        dublicat++;
                    }
                }
            }
            for (int i = 0; i < massiv.Length; i++)
            {
                min = massiv.Min();
                max = massiv.Max();
                if (massiv[i] < massiv[MinIndex])
                {
                    MinIndex = i;
                }
                if (massiv[i] > massiv[MaxIndex])
                {
                    MaxIndex = i;
                }
            }
            Console.WriteLine($"Минимальный элемент: {min}");
            Console.WriteLine($"Максимальный элемент: {max}");
            Console.WriteLine($"Максимальный индекс: {MaxIndex}");
            Console.WriteLine($"Минимальный индекс: {MinIndex}");
            for (int i = 0; i < massiv.Length; i++)
            {
                massiv[MaxIndex] = 0;
                secondmax = massiv.Max();

            }
            Console.WriteLine($"Второй по величине элемент:{secondmax}");
            Console.WriteLine(dublicat);
        }
    }
}

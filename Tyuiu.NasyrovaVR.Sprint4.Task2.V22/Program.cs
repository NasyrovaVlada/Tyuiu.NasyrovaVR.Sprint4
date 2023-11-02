using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.NasyrovaVR.Sprint4.Task2.V22.Lib;

namespace Tyuiu.NasyrovaVR.Sprint4.Task2.V22
{
    public class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнила: Насырова В. Р. | ИИПб-23-3";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы. (генератор случайных чисел)                   *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #22                                                             *");
            Console.WriteLine("* Выполнила: Насырова Влада Ренатовна | ИИПб-23-3                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 13 элементов заполненный         *");
            Console.WriteLine("* случайными значениями в диапазоне от 1 до 6 подсчитать произведение     *");
            Console.WriteLine("* нечетных элементов массива.                                             *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");


            Console.WriteLine("Введите количество элементов массива: ");
            int len = Convert.ToInt32(Console.ReadLine());
            int[] numsArray = new int[len];

            for (int i = 0; i <= len - 1; i++)
            {
                numsArray[i] = rnd.Next(1, 6);
            }
            
            Console.WriteLine("Массив: ");
            for (int i = 0; i <= len - 1; i++)
            {
                Console.Write(numsArray[i] + "\t");
            }
            Console.WriteLine();
            
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Произведение нечетных элементов:");
            int res = ds.Calculate(numsArray);

            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}

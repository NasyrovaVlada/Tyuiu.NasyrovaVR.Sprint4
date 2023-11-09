using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.NasyrovaVR.Sprint4.Task6.V14.Lib;

namespace Tyuiu.NasyrovaVR.Sprint4.Task6.V14
{
    public class Program
    {
        static void Main(string[] args)
        {

            DataService ds = new DataService();
            

            Console.Title = "Спринт #4 | Выполнила: Насырова В. Р. | ИИПб-23-3";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Класс Array                                                       *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #14                                                             *");
            Console.WriteLine("* Выполнила: Насырова Влада Ренатовна | ИИПб-23-3                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан строковый массив данных [Январь, Февраль, Март, Апрель, Май, Июнь   *");
            Console.WriteLine("* Июль], используя класс Array, выведите элементы массива, длина которых  *");
            Console.WriteLine("* больше 3 символа.                                                       *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            var week = new string[] { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль" };
            Console.WriteLine("Исходный массив: ");
            for (int i=0; i<=week.Length - 1; i++)
            {
                Console.WriteLine(week[i]);
            }
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Элементы длина которых больше 3:");
            string[] nums = ds.Calculate(week);
            var str = string.Join(", ", nums);
            Console.WriteLine(str);
            Console.ReadKey();
        }
    }
}

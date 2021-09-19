using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Лаб_роб_ООП__2_2_курс
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode; // для того, щоб консоль розпізнавав українські літери

            Console.WriteLine("Виконав роботу студент 2 курсу групи МН-205 ФАЕТ.");
            Console.WriteLine("Нагайченко Олександр Олегович");
            Console.WriteLine("Варіант-7");
            Console.WriteLine();

            Console.WriteLine("Завдання 1:");
            Console.WriteLine("Напишіть процедуру, що виводить повідомлення про версію встановленої операційної системи, поточної дати і часу.");
            Console.WriteLine();
            OperatingSystem os =
                System.Environment.OSVersion;
            Console.WriteLine("Platform: {0}", os.Platform);
            System.Console.WriteLine("The  current date and time is " + System.DateTime.Now); // дата і час
            Console.WriteLine();

            Console.WriteLine("Завдання 2:");
            Console.WriteLine("Скласти процедуру для виконання розрахунків функції, значення задавати в діалозі з використанням методу Console.ReadLine ().");
            Console.WriteLine();
            Console.WriteLine("Варіант 7. Дана така функція:");
            Console.WriteLine("G = (5/3) - Arctg√(2-Cos2x) - e^(-x/5)");

            Console.WriteLine();
            Console.Write("Input x =");
            double x = Convert.ToDouble(Console.ReadLine()); // Ми задаємо число x за допомогою введення в консоль (Console.ReadLine ()) і переводимо в його число (Convert.ToDouble)
            double z = Math.Atan(Math.Sqrt(2 - Math.Cos(2*x))); // Математична функція Arctg√(2-Cos2x)
            double c = Math.E;
            double b = -x / 5;
            double v = Math.Pow(c, b); // Підносимо експоненту в ступінь - (x / 5).
            double G = (5 / 3) - z - v; // Обчислюємо нашу функцію G.
            Console.WriteLine(" x = {0} \t G = {1}", x, G);

            Console.ReadKey();
        }
    }
}

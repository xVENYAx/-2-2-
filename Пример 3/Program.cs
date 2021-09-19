using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Пример_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Вывести версию операционной виситемы

            OperatingSystem os =
                System.Environment.OSVersion;
            Console.WriteLine("Platform: {0}", os.Platform);
            System.Console.WriteLine("The  current date and time is " + System.DateTime.Now); // дата и время
            System.Console.ReadLine();
        }
    }
}

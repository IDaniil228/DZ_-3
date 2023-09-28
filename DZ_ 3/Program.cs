using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ__3
{
    enum Mouth { Январь, Февраль, Март, Апрель, Май, Июнь, Июль, Август, Сентябрь, Октябрь, Ноябрь, Декабрь }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 4.1 Написать программу, которая читает с экрана число и переводит этот число в месяц и день месяца.");
            int[] daysOfMouth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            int[] daysOfMouthYear = { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            Console.Write("Введите год: ");
            bool isNum_1 = int.TryParse(Console.ReadLine(), out int year);
            Console.Write("Введите день: ");
            bool isNum = int.TryParse(Console.ReadLine(), out int day);
            string kindOfYear;
            int sum = 0, secondSum = 0, i = 0;
            if (isNum_1 && isNum)
            {
                if ((year % 4 == 0 && year % 100 == 0 && year % 400 == 0) || (year % 4 == 0 && year % 100 != 0))
                {
                    kindOfYear = "Високосный";
                }
                else
                {
                    kindOfYear = "Не високосный";
                }
                if (kindOfYear == "Не високосный")
                {
                    if (1 <= day && day <= 365)
                    {
                        while (sum < day)
                        {
                            secondSum = sum;
                            sum += daysOfMouth[i];
                            i++;
                        }
                        Console.WriteLine($"Число: {day - secondSum} \nМесяц: {(Mouth)i - 1}");
                    }
                    else
                    {
                        Console.WriteLine("Нужно ввести число от 1 до 365");
                    }
                }
                else
                {
                    if (1 <= day && day <= 366)
                    {
                        while (sum < day)
                        {
                            secondSum = sum;
                            sum += daysOfMouthYear[i];
                            i++;
                        }
                        Console.WriteLine($"Число: {day - secondSum} \nМесяц: {(Mouth)i - 1}");
                    }
                    else
                    {
                        Console.WriteLine("Нужно ввести число от 1 до 366");
                    }
                }
            }
            else
            {
                Console.WriteLine("Нужно ввести корректные данные");

            }
            Console.WriteLine("Нажмите любую клавишу, чтобы закрыть приложение");
            Console.ReadKey();
        }
    }
}

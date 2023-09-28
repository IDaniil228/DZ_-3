using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_3_2_
{
    enum DaysOfWeek
    {
        Понедельник = 1,
        Вторник = 2,
        Среда = 3,
        Четверг = 4,
        Пятница = 5,
        Суббота = 6,
        Воскресенье = 7
    }
 
    //enum Cards
    //{
    //    Шестерка = 6,
    //    Семерка = 7,
    //    Восьмерка = 8,
    //    Девятка = 9,
    //    Десятка = 10,
    //    Валет = 11,
    //    Дама = 12,
    //    Король = 13,
    //    Туз = 14
    //}
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1  последовательность из 10 чисел.");
            Console.WriteLine("Введите 10 чисел через одну запятую");
            string str = Console.ReadLine();
            string[] numbers = str.Split(',');
            double[] ints = new double[numbers.Length];
            bool flag = true;
            if (numbers.Length == 10)
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    bool isNum = Double.TryParse(numbers[i], out ints[i]);
                    if (!isNum)
                    {
                        flag = false;
                        Console.WriteLine("Вы ввели некорректные данные");
                        break;
                    }
                }
                if (flag)
                {
                    for (int i = 0; i < ints.Length - 1; i++)
                    {
                        if (ints[i] > ints[i + 1])
                        {
                            Console.WriteLine($"{i + 1} - индекс числа, который нарушает последовательность");
                            flag = false;
                            break;
                        }
                    }
                }
                if (flag)
                {
                    Console.WriteLine("Эта последовательность является упорядоченной по возрастанию");
                }

            }
            else
            {
                Console.WriteLine("Нужно ввести 10 чисел через запятую!");
            }

            Console.WriteLine("Нажмите любую клавишу, чтобы закрыть приложение");
            Console.ReadKey();

            Console.WriteLine("Задача 2  Определить карту по номеру");// спросить почему не получилось с enum!!!!!!!
            string[] cards = { "Шестерка", "Семерка", "Восьмерка", "Девятка", "Десятка", "Валет", "Дама", "Король", "Туз" };
            while (true)
            {
                Console.Write("Введите номер карты от 6 до 14: ");
                try
                {
                    int numb = Convert.ToInt32(Console.ReadLine()) - 6;
                    Console.WriteLine($"Ваша карта - {cards[numb]}");
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Нужно ввести число");
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Нужно ввести число от 6 до 14");
                }
            }
            Console.WriteLine("Нажмите любую клавишу, чтобы закрыть приложение");
            Console.ReadKey();

            Console.WriteLine("Задание 3  Программа, которая принимает на входе строку и производит выходные данные");
            Console.Write("Введите строку: ");
            string str_1 = Console.ReadLine();
            str_1 = str_1.ToLower();
            switch (str_1)
            {
                case "jobroni":
                    Console.WriteLine("Parton Tequila");
                    break;
                case "school counselor":
                    Console.WriteLine("Anything with Alcohol");
                    break;
                case "programmer":
                    Console.WriteLine("Hipster Craft Beer");
                    break;
                case "bike gang member":
                    Console.WriteLine("Moonshine");
                    break;
                case "politician":
                    Console.WriteLine("Your tax dollars");
                    break;
                case "rapper":
                    Console.WriteLine("Cristal");
                    break;
                default:
                    Console.WriteLine("Beer");
                    break;

            }
            Console.WriteLine("Нажмите любую клавишу, чтобы закрыть приложение");
            Console.ReadKey();

            Console.WriteLine("Задание 4 День недели");
            Console.Write("Введите номер дня недели:");
            try
            {
                int number = Convert.ToInt32(Console.ReadLine());
                if (1 <= number && number <= 7)
                {
                    Console.WriteLine($"День недели: {(DaysOfWeek)number}");
                }
                else
                {
                    Console.WriteLine("Нужно ввести цифру от 1 до 7");
                }

            }
            catch
            {
                Console.WriteLine("Нужно ввести одну цифру!");
            }
            Console.WriteLine("Нажмите любую клавишу, чтобы закрыть приложение");
            Console.ReadKey();

            Console.WriteLine("Задание 5  При помощи foreach обойти весь массив.");
            int sum = 0;
            string[] strings = { "Hello Kitty", "123", "ytrewq", "Barbie doll", "QWERTY"}; 
            foreach (string s in strings)
            {
                if (s == "Hello Kitty" || s == "Barbie doll")
                {
                    sum++;
                }
            }
            Console.WriteLine($"Кол-во кукол в сумке: {sum}");
            Console.WriteLine("Нажмите любую клавишу, чтобы закрыть приложение");
            Console.ReadKey();
        }
    }
}

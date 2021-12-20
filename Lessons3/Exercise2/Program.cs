using System;

/* 
   Задание 2
   С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой строке). 
   Требуется подсчитать сумму всех нечётных положительных чисел. 
   Сами числа и сумму вывести на экран, используя tryParse.

   Выполнил: Холкин Константин Юрьевич
   */
namespace Exercise2
{
    class Program
    {
        static string console_message = "Введите число:";
        static int a;

        static int GetNumber(string messager)// Метод ввода числа с защитой от дурака и выводом введеного числа
        {
            int a;
            bool flag;

            do
            {
                Console.Write(messager);
                flag = int.TryParse(Console.ReadLine(), out a);
                Console.WriteLine($"Введено число: {a}");
            } while (!flag);
            return a;
        }
        static int Summ()//метод подсчета суммы введены всех нечётных положительных чисел
        { int sum = 0;
            do
            {
                a = GetNumber(console_message);
                if(a > 0 && a%2 == 1)
                { 
                    sum = sum + a;
                }
            } while (a != 0);

            return sum;
        }
        static void Main()
        {
            int Resalt = Summ(); // Результат выполнение метода суммы записывае в результат

            Console.WriteLine($"сумму всех нечётных положительных чисел равна = {Resalt}"); // Вывод суммы в консоль

        }
    }
}
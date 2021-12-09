﻿using System;

namespace Exercese4
{
    class Program
    {
        /* 
       4.
         Написать программу обмена значениями двух переменных:
           а) с использованием третьей переменной;
	       б) *без использования третьей переменной.

       Выполнил: Холкин Константин Юрьевич
       */
        static void Main(string[] args)
        {
            Console.WriteLine("Программа обмена значениями двух переменных");

            Console.Write("Введите целое значение первой переменной:");//запрос
            int a = Convert.ToInt32(Console.ReadLine());// ввод и сохронение
            Console.Write("Введите целое значение второй переменной:");//запрос
            int b = Convert.ToInt32(Console.ReadLine());// ввод и сохронение

            //Решение а
            int c = a; //третья переменая
            a = b;// Обмен
            b = c;// Обмен
            Console.WriteLine($"Решение А: Теперь первая переменная равна {a}, а вторая равна {b}");//вывод


            // решение б
            (a, b) = (b, a);// Обмен без третей переменной


            Console.WriteLine($"Решение Б:Теперь первая переменная равна{a}, а вторая равна {b}");//вывод
        }
    }
}

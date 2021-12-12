using System;

namespace Exercise1

{
    /* 
    Задание 1
    Написать метод, возвращающий минимальное из трёх чисел.

    Выполнил: Холкин Константин Юрьевич
    */
    class Program
    {
        static void Main(string[] args)
        {
            // Запрос и сохронение чисел в переменную
            Console.Write("Введите первое целое число:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите первое целое число:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите первое целое число:");
            int c = Convert.ToInt32(Console.ReadLine());
            
            if(a<b && a<c) // Проверяем меньше ли число а чисел b и с
            {
                Console.Write($"Минимальное число: {a}"); // Если верно то выводим число а, если нет идем дальше
            } 
            else if (b<c)// Сравниваем b и с
            {
                Console.Write($"Минимальное число: {b}");// Если b меньше с, то выводим число b, если нет идем дальше
            }
            else// т.к. сравнили все числа и дошли до сюды, то условия не требуются выводим число с
            {
                Console.Write($"Минимальное число: {c}");
            }
        }
    }
}

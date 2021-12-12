using System;

namespace Exercise7
{
    /* 
    Задание 7

   a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b).
   б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.

    Выполнил: Холкин Константин Юрьевич
    */
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.Write("Введите число а: ");
            int a = Int32.Parse(Console.ReadLine());
            Console.Write("Введите число b (a<b): ");
            int b = Int32.Parse(Console.ReadLine());
           
            Namber(a, b); // Передаем данные и вызаваем метод
            Console.WriteLine(Summ(a, b));// Передаем данные и выводим результат метода


        }
        static void Namber(int a, int b) // Решения для а)
        {
            Console.WriteLine($" {a} "); // Выводим а
            if (a < b) Namber(a + 1, b); // Пока а < b к а будет плюсоваться + 1

        }

        static int Summ(int a, int b) // Решения для б)
        {                                            
            return a==b?b:a + Summ(a + 1, b); // Возвращаем сумму чисел от а до б              
           
        }
    }
}

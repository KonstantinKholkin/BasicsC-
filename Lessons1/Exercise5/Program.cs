using System;

namespace Exercise5
{      /* 
       5.
       а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
       б) *Сделать задание, только вывод организовать в центре экрана.
       в) **Сделать задание б с использованием собственных методов (например, Print(string ms, int x,int y).

       Выполнил: Холкин Константин Юрьевич
       */
    class Program
    {
        static void Print(string ms, int x, int y)
        {
            Console.SetCursorPosition(x, y);//кординаты
            Console.WriteLine(ms);//Текст
        }
        
        static void Main(string[] args)
        {   
            //решение а

            //задаем переменные
            string name = "Константин";
            string festname = "Холкин";
            string Sity = "Гатчина";
            
            Console.WriteLine($"Имя: {name} \nФамилия: {festname} \nГород проживания: {Sity}");//Выводим

            //решение б

            string centerText = "Имя: Константин Фамилия: Холкин Город проживания: Гатчина";//Задаем переменную
            int centerX = (Console.WindowWidth / 2) - (centerText.Length / 2);//Вычисляем центр консоли по строки и учитываем длину текста
            int centerY = (Console.WindowHeight / 2) ;//Вычисляем центр по высоте
            Console.SetCursorPosition(centerX, centerY);//Задаем новые кординаты
            Console.Write(centerText);//Выводим по центру

            //решение в

            //Вызываем метод и передаем значения
            Print("Имя: Константин Фамилия: Холкин Город проживания: Гатчина", (Console.WindowWidth / 2) - (centerText.Length / 2), (Console.WindowHeight / 2) - 1);
            

        }
    }
}

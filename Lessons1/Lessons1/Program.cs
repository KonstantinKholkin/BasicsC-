using System;

namespace Lessons1
{
    class Program
    {
       /* 
        1. Написать программу «Анкета». Последовательно задаются вопросы(имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку:
           а) используя склеивание;
           б) используя форматированный вывод;
           в) используя вывод со знаком $.

       Выполнил: Холкин Константин Юрьевич
       */
        static void Main(string[] args)
        {
            Console.Write("Введите свое имя:"); //запрос имени
            string NAME = Console.ReadLine(); //Создаем перименную и сохроняем в нее введеные данные

            Console.Write("Введите свою фамилию:"); //запрос фамилии
            string FESTNAME = Console.ReadLine(); //Создаем перименную и сохроняем в нее введеные данные

            Console.Write("Введите свой возраст:"); //запрос возраста
            int Age = Convert.ToInt32(Console.ReadLine()); //Создаем перименную и сохроняем в нее, конвертируя, введеные данные

            Console.Write("Введите свой рост:"); //запрос роста
            int Height = Convert.ToInt32(Console.ReadLine());//Создаем перименную и сохроняем в нее, конвертируя, введеные данные

            Console.Write("Введите свой вес (используя разделитель запятую):"); //запрос вес
            double Weight = Convert.ToDouble(Console.ReadLine());//Создаем перименную и сохроняем в нее, конвертируя, введеные данные

            Console.WriteLine("Ваши данные"); //Прилюдие))
            Console.WriteLine(NAME + FESTNAME + Age + Height + Weight);//склеивание
            Console.WriteLine("{0} {1} {2} {3} {4}",NAME,FESTNAME,Age,Height,Weight);//форматированный вывод
            Console.WriteLine($"{NAME} {FESTNAME}. Возраст: {Age} Рост: {Height} Вес: {Weight}");//вывод со знаком $ + прилюдие))

        }
    }
}

﻿

/*
   Задача 3
а) Дописать класс для работы с одномерным массивом. Реализовать конструктор, 
создающий массив определенного размера и заполняющий массив числами от начального значения с заданным шагом. 
Создать свойство Sum, которое возвращает сумму элементов массива, метод Inverse, 
возвращающий новый массив с измененными знаками у всех элементов массива (старый массив, остается без изменений),  
метод Multi, умножающий каждый элемент массива на определённое число, свойство MaxCount, возвращающее количество максимальных элементов. 
б)** Создать библиотеку содержащую класс для работы с массивом. Продемонстрировать работу библиотеки
в) *** Подсчитать частоту вхождения каждого элемента в массив (коллекция Dictionary<int,int>)



Выполнил Холкин Константин Юрьевич
*/
namespace Exercise3
{



    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину массива");
            int a = int.Parse(Console.ReadLine());
            MyArray ma = new(a);
            ma.MaxCounter();
            ma.Print();
            ma.Multi();
            ma.Print();
            ma.Sum();
            ma.Print();
            ma.Inverse();
           


        }

    }
}



        

    
    
   




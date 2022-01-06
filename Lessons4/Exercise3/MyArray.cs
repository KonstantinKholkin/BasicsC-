using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    class MyArray
    { 
        int[] array;
         public MyArray(int arr) // создаем конструктор класса
         {
            array = new int[arr]; 

            for (int i = 0; i < array.Length; i++) // Заполняем массив с шаго 2
            {
                array[i] = i+2;
            }

         }
        public void Print()
        {
            for(int i = 0; i < array.Length; i++)
            {
                Console.Write($" {array[i]} " );
            }
            Console.WriteLine("\n ___________________________________________________ \n");
        }
        
        public void Sum () //Вычисляем сумму
        {
            for(int i = 0; i < array.Length; i++)
            {
                array[i] += i;
            }
        }
        public void Multi()//Умножаем каждый элемент на задонное число "10"
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] *= 10;
            }
        }
        public int[] Inverse()//создаем экземпляр массива с изменеными знаками 
        {
            int [] res = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                res[i] = -array[i];
                Console.Write($" {res[i]} ");
            }
            return res;
        }
        public int MaxCounter()// Вычисляем количество мах
        {
            int max = array.Max();
            int s = 0;
            int a = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == max)
                    s += 1;
                    a = array [i];
            }
            Console.WriteLine($"\n\nMAX число {s} = {a}\n\n");
            return s;
        }

    }
}

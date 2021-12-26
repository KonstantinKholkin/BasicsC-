using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
   Задача 5
   *а) Реализовать библиотеку с классом для работы с двумерным массивом. Реализовать конструктор, заполняющий массив случайными числами.
   Создать методы, которые возвращают сумму всех элементов массива, сумму всех элементов массива больше заданного, свойство,
   возвращающее минимальный элемент массива, свойство, возвращающее максимальный элемент массива,
   метод, возвращающий номер максимального элемента массива (через параметры, используя модификатор ref или out).
   **б) Добавить конструктор и методы, которые загружают данные из файла и записывают данные в файл.
   **в) Обработать возможные исключительные ситуации при работе с файлами.




Выполнил Холкин Константин Юрьевич
*/

namespace Exercise5
{
    internal class Array2
    {
        int[,] array = new int[2,2];//Создаем массив
        Random random = new Random();

        public void Array()//Заполняем массив
        { 
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(10);
                }
            }
          
        }
        public void PrintArray()//Выводим массмв
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                   Console.Write($"  {array[i, j]}  " );
                }
                Console.Write("\n");
            }

        }
        public void Summ()//Сумма элементов массива
        {
            int sum = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    sum += array[i, j];
                }
                
            }
            Console.WriteLine($"\n Сумма всех чисел в массиве равна = {sum}");

        }

        public void SumElementss()//Число Элементов массива
        {
            int sum = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    sum++;
                }

            }
            Console.WriteLine($"\n Сумма элементов массива равна = {sum}");

        }
        public int MaxCounter()// Вычисляем максимальное число
        {
            int max = array[0, 0];
            
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] > 0 && array[i, j] >max)
                        max = array[i, j];
                    
                }
            }

            Console.WriteLine($"\n\nMAX число {max}\n\n");
            return max;
        }
        public int MinCounter()// Вычисляем минимально число
        {
            int min = array[0, 0];
           
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] > 0 && array[i, j] < min)
                        min = array[i, j];

                }
            }

            Console.WriteLine($"\n\nMIN число {min}\n\n");
            return min;
        }
        public int Max()// Вычисляем сумму чисел больше задонного
        {
            int c = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] > 0 && array[i, j] > 2)
                        c++;

                }
            }

            Console.WriteLine($"\n\nСумма чисел больше заданного {c}\n\n");
            return c;
        }
    }
}

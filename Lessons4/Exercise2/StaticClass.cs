using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
   Задача 2
Реализуйте задачу 1 в виде статического класса StaticClass;
а) Класс должен содержать статический метод, который принимает на вход массив и решает задачу 1;
б) *Добавьте статический метод для считывания массива из текстового файла. Метод должен возвращать массив целых чисел;
в)**Добавьте обработку ситуации отсутствия файла на диске.

Выполнил Холкин Константин Юрьевич
*/
namespace Exercise2
{
    static class StaticClass
    {
        public static void StaticMetod (int[] arr)
        {
            
            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++) // Цикал по перебору и заполнению рандомными числами от -10000 до 10000
            {
                arr[i] = rand.Next(-10000, 10001); // [-10000; 10000)
                string masstxt = String.Empty;
                masstxt += $"  {arr[i]}  ";
                File.AppendAllText("mass.txt", masstxt);// Запись массива в .txt
            }

            int c = 0; // щетчик пар
            for (int j = 0; j < arr.Length; j++) // Цикл перебора массива
            {
                if (arr[j] % 3 == 0 && j < arr.Length - 1 && j - 1 >= 0) //если число делится на 3 без остатка и соседнии числа не выходят за пределы массива, то
                {
                    if (arr[j - 1] % 3 != 0 || arr[j + 1] % 3 != 0) // проверяем если одно из соседних чисел не делится на 3 без остатка то плюсуем как пару
                    {
                        c++;
                    }

                }


            }
            Console.WriteLine($"{c} ");
        }
        public static void StaticReadMass(int[] arr)// Вывод массива из .txt
        {
            
            try// если файл есть то выводим содержимое
            {
                StreamReader sr = new StreamReader("E:\\GeekBrains\\BasicsC#\\Lessons4\\Exercise2\\bin\\Debug\\net6.0\\mass.txt");
                Console.WriteLine(sr.ReadToEnd());
            }
            
            catch (FileNotFoundException) // Если файла нет, выводим файл не найден
            {
                Console.WriteLine("Файл не найден");
            }

            
           
        }
    }
}

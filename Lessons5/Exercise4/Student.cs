using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{/*
    Задача4
   *Задача ЕГЭ.
   На вход программе подаются сведения о сдаче экзаменов учениками 9-х классов некоторой средней школы. 
В первой строке сообщается количество учеников N, которое не меньше 10, но не превосходит 100, каждая из следующих N строк имеет следующий формат: <Фамилия> <Имя> <оценки>,
 
где <Фамилия> — строка, состоящая не более чем из 20 символов,
<Имя> — строка, состоящая не более чем из 15 символов,
<оценки> — через пробел три целых числа, 
соответствующие оценкам по пятибалльной системе. 
<Фамилия> и <Имя>, а также <Имя> и <оценки> разделены одним пробелом. 
Пример входной строки:
Иванов Петр 4 5 3
Требуется написать как можно более эффективную программу, 
которая будет выводить на экран фамилии и имена трёх худших по среднему баллу учеников.
Если среди остальных есть ученики, набравшие тот же средний балл, что и один из трёх худших, следует вывести и их фамилии и имена.



   Выполнил Холкин Константин Юрьевич
   */
    class Student
    {
        int n;//Количество студентов
        string[,] student;//Массив данных о студентах
        int[] averagerating;//Массив оценнок студента
        int[] result;//Средняя арифмитическая оценок студентов
        public void RequestN()//Запрос на количество студентов
        {
            Console.WriteLine("Ведите количество студентов:");
            n = int.Parse(Console.ReadLine());
            CheckN();// Запрос на проверку
        }
        public void CheckN ()//Проверка на корректность количества студентов
        {
            if (n >= 10 && n<=100)
            {
                Console.WriteLine("Введенно коректное число учеников!");
            }
            else
            {
                Console.WriteLine("Ввод не корректен. Введите количество студентов от 10 до 100");
                RequestN();
            }
        }
        public void RequestStudent()// заполняем массив <имя>,<фамилия>,<оценки>
        {
            student = new string[n,3];
            for (int i = 0; i < n; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    if(j == 0)
                    {
                        Console.WriteLine("Введите Имя студента");
                        student[i,j] = Console.ReadLine();
                    }
                    else if(j == 1)
                    {
                        Console.WriteLine("Введите Фамилию студента");
                        student[i, j] = Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Введите оценки студента через пробел");
                        student[i, j] = Console.ReadLine();
                    }
                }
            }
            

        }
        public void AverageRating()//перевод ячейки оценнок в массив чисел и запись в массив среднюю оценку
        {
            
            result = new int[n];
            
            for (int i = 0;i < n;i++)
            {
               int summa=0;
               string[]rating = student[i, 2].Split(new char[]{' '},StringSplitOptions.RemoveEmptyEntries);
               averagerating = rating.ToArray().Select(i => int.Parse(i.ToString())).ToArray();//перевод в массив чисел
                for (int j = 0;j <averagerating.Length;j++)
                {
                    summa = summa + averagerating[j];
                }
                result[i] = summa/averagerating.Length;//запись средней оценки
                
            }      
                  
        }
        public int MinResult()//нахождение худшего студента
        {
            int min = 5;
            int i;
            for (i = 0;i < n; i++)
            {
                if(result[i] < min)
                { 
                    min = result[i];

                }
               
            }
            return i;
        }

        public void Print()//Печать массива
        {
            
            for (int i = MinResult();  i < student.GetLength(0); i++)
            {
                for(int j = 0; j < student.GetLength(1); j++)
                {
                    Console.Write($" {student[i,j]} ");
                }
                Console.WriteLine(" \n ------------------------------------------------");
            }
            

            
        }


    }
}

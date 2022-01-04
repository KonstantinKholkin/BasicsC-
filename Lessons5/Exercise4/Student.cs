using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
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
            if (n >= 1 && n<=3)//!!!!!!!!
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
                        Console.WriteLine("Введите 3 оценки студента через пробел");
                        student[i, j] = Console.ReadLine();
                    }
                }
            }
            

        }
        public void AverageRating()
        {
            
            result = new int[n];
            
            for (int i = 0;i < n;i++)
            {
               int summa=0;
               string[]rating = student[i, 2].Split(new char[]{' '},StringSplitOptions.RemoveEmptyEntries);
               averagerating = rating.ToArray().Select(i => int.Parse(i.ToString())).ToArray();
                for (int j = 0;j <averagerating.Length;j++)
                {
                    summa = summa + averagerating[i];
                }
                result[i] = summa/averagerating.Length;
                
            }      
                  
        }
        public int MinResult()
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

        public void Print()
        {
            
            for (int i = MinResult();  i < n; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    Console.Write($" {student[i,j]} ");
                }
                Console.WriteLine(" \n ------------------------------------------------");
            }
            

            
        }


    }
}

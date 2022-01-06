
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



    class Program
    {

        static void Main(string[] args)
        {
            int[] array;
            Console.Write("Введите длину массива:");
            int massiv = int.Parse(Console.ReadLine());
            array = new int[massiv];
            StaticClass.StaticMetod(array);
            StaticClass.StaticReadMass(array);
        }

    }
}


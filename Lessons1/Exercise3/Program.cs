using System;

namespace Exercise3
{
    class Program
    {

        /* 
       3.
         а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2). 
        Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);
         б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.

       Выполнил: Холкин Константин Юрьевич
       */

        // для решения б
        // объявляем переменные
        double y1;
        double y2;
        double x1;
        double x2;
        //создаем метод для решения б
        public double Distance()
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
        static void Main(string[] args)
        {
            //a

            Console.WriteLine("Программа расчета расстояние между точками");// прилюдие

            Console.WriteLine("Введите кординаты первой точки по X (используя разделитель запятую):");//запрос
            double X1 = Convert.ToDouble(Console.ReadLine());// сохранение введеных данных

            Console.WriteLine("Введите кординаты первой точки по Y (используя разделитель запятую):");//запрос
            double Y1 = Convert.ToDouble(Console.ReadLine());// сохранение введеных данных

            Console.WriteLine("Введите кординаты второй точки по X (используя разделитель запятую):");//запрос
            double X2 = Convert.ToDouble(Console.ReadLine());// сохранение введеных данных

            Console.WriteLine("Введите кординаты второй точки по Y (используя разделитель запятую):");//запрос
            double Y2 = Convert.ToDouble(Console.ReadLine());// сохранение введеных данных

            double R = Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2));//Вычисляем

            Console.WriteLine("{0:F2}", R);// выводим ответ
            
            //б
            Program myDistance = new Program();// оброщаемся к переменным обявленным в классе 

            Console.WriteLine("Введите кординаты первой точки по X (используя разделитель запятую):");//запрос
            myDistance.x1 = Convert.ToDouble(Console.ReadLine());// переназначаем переменную через консоль

            Console.WriteLine("Введите кординаты первой точки по Y (используя разделитель запятую):");//запрос
            myDistance.y1 = Convert.ToDouble(Console.ReadLine());// переназначаем переменную через консоль

            Console.WriteLine("Введите кординаты второй точки по X (используя разделитель запятую):");//запрос
            myDistance.x2 = Convert.ToDouble(Console.ReadLine());// переназначаем переменную через консоль

            Console.WriteLine("Введите кординаты второй точки по Y (используя разделитель запятую):");//запрос
            myDistance.y2 = Convert.ToDouble(Console.ReadLine());// переназначаем переменную через консоль

            double r = myDistance.Distance();//обращаемся к методу для вычисления

            Console.WriteLine("{0:F2}", r);// выводим ответ

        }
    }
}

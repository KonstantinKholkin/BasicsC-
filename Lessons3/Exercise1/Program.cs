using System;


namespace Exercise1
{
    /* 
    Задание 1
    а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры.
    б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса.
    в) Добавить диалог с использованием switch демонстрирующий работу класса.

    Выполнил: Холкин Константин Юрьевич
    */

    
// Задание а
struct Complex // Данна структура
    {
        public double im;
        public double re;
        

        public Complex Plus(Complex x)
        {
            Complex y;
            y.im = im + x.im;
            y.re = re + x.re;
            return y;
        }

        public Complex Multi(Complex x)
        {
            Complex y;
            y.im = re * x.im + im * x.re;
            y.re = re * x.re - im * x.im;
            return y;
        }

        public Complex Subtraction(Complex x)//добавляем метод вычитания комплексных чисел
        {
            Complex y;
            y.im = im - x.im;
            y.re = re - x.re;
            
            return y;
        }

        public string ToString()
        {
            return re + "+" + im + "i";
        }
    }

    // Задание б

    class ClassComplex // Дан класс
    {
        double re;
        double im;

        public ClassComplex()
        {
            re = 0;
            im = 0;
        }

        public ClassComplex(double re, double im)
        {
            this.re = re;
            this.im = im;
        }
        public ClassComplex Plus(ClassComplex x2)
        {
            ClassComplex x3 = new ClassComplex();
            x3.im = x2.im + im;
            x3.re = x2.re + re;
            return x3;
        }
        public ClassComplex Substract(ClassComplex x2) // Дописываем вычитание
        {
            ClassComplex x3 = new ClassComplex();
            x3.re = re - x2.re;
            x3.im = im - x2.im;
            return x3;
        }
        public ClassComplex Multiply(ClassComplex x2) // Дописываем происведение
        {
            ClassComplex x3 = new ClassComplex();
            x3.re = re * x2.re - im * x2.im;
            x3.im = re * x2.im + x2.re * im;
            return x3;
        }
        public ClassComplex Division(ClassComplex x2) // Ну и от себя дописал частное
        {
            ClassComplex x3 = new ClassComplex();
            x3.re = (re * x2.re + im * x2.im) / (Math.Pow(x2.re, 2) + Math.Pow(x2.im, 2));
            x3.im = (x2.re * im - re * x2.im) / (Math.Pow(x2.re, 2) + Math.Pow(x2.im, 2));
            return x3;
        }
        
        public string ConvertToString()
        {
            return re + "+" + im + "i";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Complex complex1;
            complex1.re = 1;
            complex1.im = 1;

            Complex complex2;
            complex2.re = 2;
            complex2.im = 2;
                      
            // Демонстрируем работу структуры
            Complex result = complex1.Plus(complex2);
            Console.WriteLine(result.ToString());
            result = complex1.Multi(complex2);
            Console.WriteLine(result.ToString());
            result = complex1.Subtraction(complex2);
            Console.WriteLine(result.ToString());


            // Задание в
            // Демонстрируем работу Класса через switch 

            //Запрос чисел
            Console.Write("Введите реальную часть комплексного числа №1: ");
            int a1 = int.Parse(Console.ReadLine());
            Console.Write("Введите мнимую часть комплексного числа №1: ");
            int a2 = int.Parse(Console.ReadLine());
            Console.Write("Введите реальную часть комплексного числа №2: ");
            int b1 = int.Parse(Console.ReadLine());
            Console.Write("Введите мнимую часть комплексного числа №2: ");
            int b2 = int.Parse(Console.ReadLine());

            //Присваиваем числа
            ClassComplex dig1 = new ClassComplex(a1, a2);
            ClassComplex dig2 = new ClassComplex(b1, b2);
            Console.WriteLine($"\nВведены два комплексных числа: {dig1.ConvertToString()}, {dig2.ConvertToString()}");
            int i = 0;


            do
            {


                Console.WriteLine("\nВ программе предусмотрены следующие арифметические операции:" //запрос операции
                    + "\n1 - Сложение"
                    + "\n2 - Вычитание"
                    + "\n3 - Умножение"
                    + "\n4 - Деление"
                    + "\n5 - Выход"
                    );

                Console.Write("Выберите необходимое действие:");
                int ans = int.Parse(Console.ReadLine());

                switch (ans) //вывод кейса согласно введеному числу
                {
                    case 1:
                        Console.WriteLine($"\nРезультат сложения: {dig1.Plus(dig2).ConvertToString()}");
                        break;
                    case 2:
                        Console.WriteLine($"\nРезультат вычитания: {dig1.Substract(dig2).ConvertToString()}");
                        break;
                    case 3:
                        Console.WriteLine($"\nРезультат умножения: {dig1.Multiply(dig2).ConvertToString()}");
                        break;
                    case 4:
                        Console.WriteLine($"\nРезультат деления: {dig1.Division(dig2).ConvertToString()}");
                        break;
                    case 5:
                        Console.WriteLine("выход");
                        i = 1;
                        break;
                }

            } while (i!=1);// если пользователь нажал выход, выходим. В противном случае продолжаем цикл
            
        }
    }
}

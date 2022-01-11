
/*
 Задание 1:
 Изменить программу вывода таблицы функции так, чтобы можно было передавать функции типа double (double, double). Продемонстрировать работу на функции с функцией a*x^2 и функцией a*sin(x).


   Выполнил: Холкин Константин Юрьевич
*/
namespace Exercise_1
{
    public delegate double Fun (double a,double x);//Объявляем делегат
    class Function
    {
        double a;//Объявляем переменную а
        double x;//Объявляем переменную х
        double x2;//Объявляем переменную х2, до которой нужно подсчитать 

        public void Input()//Создаем метод для ввода пользователем переменных + приветствие
        {
            Console.WriteLine("Добро пожаловать в программу для расчета функций a*x^2 и a*sin(x)\n");
            Console.Write("Введите число a:");
            a = double.Parse(Console.ReadLine());
            Console.Write("\nВведите число x:");
            x = double.Parse(Console.ReadLine());
            Console.Write("\nВведите число x до которого нужно подсчитать:");
            x2 = double.Parse(Console.ReadLine());
        }
        public void Table(Fun F, double x, double x2) //Метод, который принимает делегат
        {
            Console.WriteLine("------X --------Y-------");
            while (x <=x2)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", x, F (a, x));
                x += 1;
                
            }
            Console.WriteLine("--------------------------------------------");
        } 
        public double SquFunc(double a, double x)//Метод расчета функции a*x^2
        {
            return a*(x*x);
        }

        public double SinFunc(double a, double x)//Метод расчета функции a*sin(x)
        {
            return a * Math.Sin(x);
        }
        public void PrintSqu()//Вывод метода расчета функции a*x^2
        {
            Console.WriteLine("Расчет функции a*x^2");
            SquFunc(a, x);
            Table(new Fun(SquFunc), x, x2);
        }
        public void PrintSin()//Вывод метода расчета функции a*sin(x)
        {
            Console.WriteLine("Расчет функции a*sin(x)");
            SinFunc(a, x);
            Table(new Fun(SinFunc), x, x2);
        }


    }

   
}

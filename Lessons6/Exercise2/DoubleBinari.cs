

/*
 Задание 2:
 Модифицировать программу нахождения минимума функции так, чтобы можно было передавать функцию в виде делегата. 
 а) Сделать меню с различными функциями и представить пользователю выбор, для какой функции и на каком отрезке находить минимум. Использовать массив (или список) делегатов, в котором хранятся различные функции.
 б) *Переделать функцию Load, чтобы она возвращала массив считанных значений. Пусть она возвращает минимум через параметр (с использованием модификатора out).


   Выполнил: Холкин Константин Юрьевич
*/
namespace Exercise2
{
    class DoubleBinari
    {
        
        public delegate double Fun(double x);

        double a, b, h;//Объявляем переменые для ввода пользователем
        public void Input()//Создаем метод для ввода пользователем переменных + приветствие
        {
            Console.WriteLine("---Добро пожаловать в программу нахождения минимума функции---");
            Console.Write("\nВведите min значение х:");
            a = double.Parse(Console.ReadLine());
            Console.Write("\nВведите max значение х:");
            b = double.Parse(Console.ReadLine());
            Console.Write("\nУкажите шаг:");
            h = double.Parse(Console.ReadLine());
        }


        public static double F1(double x)//Метод расчета функции x * x - 50 * x + 10;
        {
            return x * x - 50 * x + 10;
        }
        public double F2(double x)//Метод расчета функции 10*x^2
        {
            return 10 * (x * x);
        }

        public double F3(double x)//Метод расчета функции 10*sin(x)
        {
            return 10 * Math.Sin(x);
        }
        public static void SaveFunc(string fileName, double a, double b, double h, Fun F)//Метод записи в файл от а до b  с шагом h
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            double x = a;
            while (x <= b)
            {
                bw.Write(F(x));
                x += h;
            }
            bw.Close();
            fs.Close();
        }
        
        public static double Load(string fileName)//Считываем с файла и находим минимум
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader bw = new BinaryReader(fs);
            double min = double.MaxValue;
            double d;
            for (int i = 0; i < fs.Length / sizeof(double); i++)
            {
                
                d = bw.ReadDouble();
                if (d < min) min = d;
            }
            bw.Close();
            fs.Close();
            return min;
        }
        public void Print()//Меню с выводом результата 
        {
            Fun[] F = { F1, F2, F3 };
            Console.WriteLine("\nВыбирите по какой функции расчитать:\n1. функция  x * x - 50 * x + 10,\n2. функция 10*x^2,\n3. функция 10*sin(x)\n ");
            int Num = int.Parse(Console.ReadLine());
            SaveFunc("Function.bin", a, b, h, F[Num - 1]);
            Console.WriteLine(Load("Function.bin"));
        }


    }
}

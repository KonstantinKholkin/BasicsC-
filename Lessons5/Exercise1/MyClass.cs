using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
/*
 Задача1
   Создать программу, которая будет проверять корректность ввода логина. Корректным логином будет строка от 2 до 10 символов, содержащая только буквы латинского алфавита или цифры, при этом цифра не может быть первой:
   а) без использования регулярных выражений;
   б) **с использованием регулярных выражений.

Выполнил Холкин Константин Юрьевич
*/

namespace Exercise1
{
    internal class MyClass
    {
        public void Regex()
        {
            Regex login_regex = new Regex("^[a-zA-Z][a-zA-Z0-9]{2,9}$");//Задаем параметр для ввода сторока от 2 до 10 символов первое не число последещие либо латиница либо цифра
            Console.WriteLine("Введите строку 1: от 2 до 10 символов, содержащая только буквы латинского алфавита или цифры, при этом цифра не может быть первой");
            string str1 = Console.ReadLine();

            if (login_regex.Match(str1).Success) // проверяем введеную строку 
            {
                Console.WriteLine("Введено корректно"); // Если введенно корректно
            }
            else
            {
                Console.WriteLine("Введено не корректно");// Если нет
            }
        }

        public void Cycle()
        {
            bool correct = true;
            Console.WriteLine("Введите строку 2: от 2 до 10 символов, содержащая только буквы латинского алфавита или цифры, при этом цифра не может быть первой");
            string str2 = Console.ReadLine();

            
            if (str2.Length < 2 || str2.Length > 10)//Проверяем длину строки
            {
                Console.WriteLine("Введено не корректно");
                correct = false;
            }


            if (Char.IsDigit(str2[0]))// Проверяем первый символ на наличие цифры
            {
                Console.WriteLine("Введено не корректно");
                correct = false;
            }
            else // если первая не цифра проверяем дальше
            {
                for (int i = 0; i < str2.Length; i++) //Проверяем введенная строка написана на латинице 
                {
                    if (Char.IsLetterOrDigit(str2[i]))
                    {
                        Console.WriteLine("Введено не корректно");
                        correct = false;
                        break;
                    }
                }
            }


            if (correct == true) // Если correct = true
            {
                Console.WriteLine("Введено корректно");
            }
          
        }
    }
}

// See https://aka.ms/new-console-template for more information
/*
   Задача 4
   Решить задачу с логинами из урока 2, только логины и пароли считать из файла в массив. Создайте структуру Account, содержащую Login и Password.



Выполнил Холкин Константин Юрьевич
*/
namespace Exercise4
{



    class Program
    {

        static void Main(string[] args)
        {
            AccountUsing my = new AccountUsing();
            my.FileSave();
            string accountFile = @"E:\GeekBrains\BasicsC#\Lessons4\Exercise4\account.txt";
            my.ReadArrayFromFile(accountFile);
            my.GetLoginPass();
        }

    }
}





   
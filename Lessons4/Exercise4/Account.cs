using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
   Задача 4
   Решить задачу с логинами из урока 2, только логины и пароли считать из файла в массив. Создайте структуру Account, содержащую Login и Password.



Выполнил Холкин Константин Юрьевич
*/
namespace Exercise4
{
    class AccountUsing
    {

        public string accountFile = @"E:\GeekBrains\BasicsC#\Lessons4\Exercise4\account.txt";
        public string accauntUsing =  "root, GeekBrains" ;
        struct Account //Создаем структуру Account 
        {
            static string Login = "root"; //Переменная содержит верный логин
            static string Password = "GeekBrains";//Переменная содержит верный пароль
            
            
            public static string getLogin()
            {
                return Login;
            }

            public static string getPassword()
            {
                return Password;
            }
            
        }
              

              
        public void FileSave()//сохранение файла
        {
            File.WriteAllText(accountFile, accauntUsing);
        }
        public string[] ReadArrayFromFile(string fileName)//Проверка файла
        {
            string[] retArr;
            try
            {
                retArr = File.ReadLines(fileName).Select(l => Convert.ToString(l)).ToArray();
            }
            catch (Exception ex)
            {
                retArr = new string[0];
                Console.WriteLine($"Файл {fileName} не найден. {ex}");
            }
            return retArr;
        }
        public bool Using(String login, String password)//Проверка логина и пароля
        {
            if (Account.getLogin() == login && Account.getPassword() == password)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        public void GetLoginPass()//Цикл ввода, данно 3 попытки
        {
            int tryCount = 3;

            do
            {
                Console.Write("Логин: ");
                String login = Console.ReadLine();
                Console.Write("Пароль: ");
                String password = Console.ReadLine();
                if (Using(login, password))
                {
                    Console.WriteLine("Вход выпонен!");
                    break;
                }
                else
                {
                    Console.WriteLine("Введенно не верно.");
                    tryCount--;
                }
            } while (tryCount != 0);
        }

    }
}         
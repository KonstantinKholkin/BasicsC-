using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    /*
    Задача3
   *Для двух строк написать метод, определяющий, является ли одна строка перестановкой другой.
   Например:
   badc являются перестановкой abcd.


   Выполнил Холкин Константин Юрьевич
   */
    internal class StringFlipOver
    {
        string a;
        string b;
        bool Flag = false;

        public string SaveStringA()
        {
            Console.Write("Введите первую строку:");
             a = Console.ReadLine();
            return a;
        }
        public string SaveStringB()
        {
            Console.Write("Введите вторую строку:");
           
            b = Console.ReadLine();
            return b;
        }
        public void ChecksLeningString()
        {
            if(a.Length==b.Length)
            {
                Flag = true;
            }
            else
            {
                Flag = false;
            }
        }
        public void Checkstring()
        {
            char [] s1 = a.ToCharArray();
            char[] s2 = b.ToCharArray();
            int c = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (s1[c] == s2[i])
                {
                    Flag = true;
                    c++;
                    i=0;                  
                }
                else
                {
                    Flag = false;
                }
            
            }
            
        }


        public void Print()
        {
            if(!Flag)
            {
                Console.WriteLine("Строка является перестановкой второй.");
            }
            else
            {
                Console.WriteLine("Строка не является перестановкой второй.");
            }
            

        }
     
   
      
    }
}

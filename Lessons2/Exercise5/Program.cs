﻿using System;

namespace Exercise5
{
    /* 
    Задание 5

    а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или всё в норме.
    б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.



    Выполнил: Холкин Константин Юрьевич
    */
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите свою массу тела в килограмах (В качестве разделителя использовать запятую):");
            double Weight = Convert.ToDouble(Console.ReadLine()) ;
            Console.Write("Введите свой рост в см:");
            double Height = Convert.ToDouble(Console.ReadLine()) / 100;
            double I = Weight / (Height * Height);//Расчитываем ИМТ
            if (I < 18.5)//Данные Согласно Википедии
            {
                // Решение а.

                Console.Write("У вас дефицит массы");
                
                // Для решения б.

                double normalI = ((Height*100)*0.7-50) - Weight; //Индекс Брейтмана. Нормальная масса тела = рост [см] • 0,7 - 50 кг
                Console.Write("Bам следует набрать - {0:F2} кг",normalI);
               
            }
            else if (I > 18.5 && I<25)//Данные Согласно Википедии
            {
                // Решение а.

                Console.Write("У вас нормальное ИМТ");
            }
            else
            {
                // Решение а.
                Console.Write("У вас избыток массы.");
                
                //Для решения б.

                double normalI = Weight - ((Height * 100) * 0.7 - 50);//  Индекс Брейтмана. Нормальная масса тела = рост [см] • 0,7 - 50 кг
                Console.Write("Вам следует скинуть - {0:F2} кг",normalI);

            }

        }
    }
}
// See https://aka.ms/new-console-template for more information
using Exercise_1;
/*
 Задание 1:
 Изменить программу вывода таблицы функции так, чтобы можно было передавать функции типа double (double, double). Продемонстрировать работу на функции с функцией a*x^2 и функцией a*sin(x).


   Выполнил: Холкин Константин Юрьевич
*/
Function m = new();
m.Input();//Вызываем ввод дынных (а и х)
m.PrintSin();//Печать функции a*sin(x)
m.PrintSqu();//Печать функции a*x^2
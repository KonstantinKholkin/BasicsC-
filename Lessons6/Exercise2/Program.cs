﻿// See https://aka.ms/new-console-template for more information
/*
 Задание 2:
 Модифицировать программу нахождения минимума функции так, чтобы можно было передавать функцию в виде делегата. 
 а) Сделать меню с различными функциями и представить пользователю выбор, для какой функции и на каком отрезке находить минимум. Использовать массив (или список) делегатов, в котором хранятся различные функции.
 б) *Переделать функцию Load, чтобы она возвращала массив считанных значений. Пусть она возвращает минимум через параметр (с использованием модификатора out).


   Выполнил: Холкин Константин Юрьевич
*/
using Exercise2;

DoubleBinari m = new();
m.Input();//Запрос на переменные
m.Print();//Вывод меню и результата
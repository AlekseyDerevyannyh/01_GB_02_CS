// Напишите программу, которая будет принимать на вход два числа и выводить
// является ли второе число кратное превому. Если число 2 не кратно
// числу 1, то программа выводит остаток от деления

using System;
using static System.Console;

Clear();
Write("Введите 1-ое число: ");
int number1 = Convert.ToInt32(ReadLine());
Write("Введите 2-ое число: ");
int number2 = Convert.ToInt32(ReadLine());

if ((number1 % number2) == 0)	Write("{0}, {1} -> кратно", number1, number2);
else							Write("{0}, {1} -> не кратно, остаток {2}", number1, number2, number1 % number2);

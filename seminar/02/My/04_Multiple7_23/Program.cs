// Напишите программу, которая принимает на вход число и проверяет,
// кратно ли оно одновременно 7 и 23
using System;
using static System.Console;

Clear();
Write("Введите число: ");
int number = Convert.ToInt32(ReadLine());

if (((number % 7) == 0) && ((number % 23) == 0))
	Write("{0} -> да", number);
else
	Write("{0} -> нет", number);
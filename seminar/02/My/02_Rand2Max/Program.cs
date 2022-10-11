// Напишите программу, которая выводит случайное число из отезка [10, 99]
// и показывает наибольшую цифру числа
using System;
using static System.Console;

Clear();
int number = new Random().Next(10, 100);
if ((number / 10) > (number % 10))	Write("{0} -> {1}", number, number / 10);
else								Write("{0} -> {1}", number, number % 10);

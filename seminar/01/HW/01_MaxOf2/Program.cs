//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
using System;

Console.Clear();
Console.Write("Введите число a = ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b = ");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b) {
	Console.WriteLine("max = a = {0}", a);
	Console.Write("min = b = {0}", b);
	return;
}
if (a < b) {
	Console.WriteLine("max = b = {0}", b);
	Console.Write("min = a = {0}", a);
	return;
}
Console.WriteLine("max = min = a = b = {0}", a);

//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
using System;

Console.Clear();
Console.Write("Введите число N = ");
int N = Convert.ToInt32(Console.ReadLine());

int count = 1;

if (N < 2) {
	Console.WriteLine("Ошибка: N должно быть >= 2");
	return;
}
while (count <= N) {
	if (count % 2 == 0) Console.WriteLine(count);
	count++;
}

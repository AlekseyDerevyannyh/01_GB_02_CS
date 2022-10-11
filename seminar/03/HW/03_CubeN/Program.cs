// Задача 23. Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N
using System;
using static System.Console;

Clear();
int N;
Write ("Введите число N: ");
if (!int.TryParse(ReadLine(), out N)) {
	WriteLine("Ошибка ввода числа!");
	return;
}
if (N < 1) {
	WriteLine("ОШИБКА: число N дожно быть >= 1 !");
	return;
}
Write($"{N} -> ");
for (int i = 1; i < N; i ++) {
	Write($"{Math.Pow(i, 3)}, ");
}
Write($"{Math.Pow(N, 3)}");
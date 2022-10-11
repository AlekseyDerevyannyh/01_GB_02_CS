// Задача 10: Напишите программу, которая принимает на вход трёхзначное
// число и на выходе показывает вторую цифру этого числа
using System;
using static System.Console;

Clear();
int number;
Write("Введите трёхзначное число: ");
if (!int.TryParse(ReadLine(), out number)) {
	Write("Ошибка ввода числа!");
	return;
}
if ((Math.Abs(number) < 100) || (Math.Abs(number) > 999)) {
	Write("ОШИБКА! Число не трёхзначное!!!");
	return;
}
Write($"{number} -> {(number / 10) % 10}");

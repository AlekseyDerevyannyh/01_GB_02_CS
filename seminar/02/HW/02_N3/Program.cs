// Задача 13: Напишите программу, которая выводит третью цифру заданного
// числа или сообщает, что третьей цифры нет
using System;
using static System.Console;

Clear();
int number;
Write("Введите число: ");
if (!int.TryParse(ReadLine(), out number)) {
	Write("Ошибка ввода числа!");
	return;
}
if (Math.Abs(number) < 100) {
	Write($"{number} -> ОШИБКА! Третьей цифры нет!");
	return;
}
int count = 0;
int number1 = number;
while (number1 != 0) {
	number1 /= 10;
	count ++;
}
Write($"{number} -> {(Math.Abs(number) / Convert.ToInt32(Math.Pow(10, (count - 3)))) % 10}");

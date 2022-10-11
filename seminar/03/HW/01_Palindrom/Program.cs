// Задача 19. Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом
using System;
using static System.Console;

Clear();
int number;
Write ("Введите пятизначное число: ");
if (!int.TryParse(ReadLine(), out number)) {
	WriteLine("Ошибка ввода числа!");
	return;
}
if (Math.Abs(number) < 10000 || Math.Abs(number) > 99999) {
	WriteLine("ОШИБКА: число не пятизначное!");
	return;
}
Write ((number/10000 == number%10) && ((number/1000)%10 == (number/10)%10) ? $"{number} -> да" : $"{number} -> нет");

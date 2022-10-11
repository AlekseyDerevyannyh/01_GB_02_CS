// Программа поиска максимального элемента из 9 с использованием функций
using System;
using static System.Console;

int[] number = {15, 21, 39, 12, 23, 57, 13, 23, 33};
Clear();
int Max (int arg1, int arg2, int arg3) {
	int result = arg1;
	if (arg2 > result)	result = arg2;
	if (arg3 > result)	result = arg3;
	return result;
}

int max = Max(
	Max(number[0], number[1], number[2]),
	Max(number[3], number[4], number[5]),
	Max(number[6], number[7], number[8]));
Write($"Максимальное число = {max}");

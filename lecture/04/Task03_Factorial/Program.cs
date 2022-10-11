// Факториал числа через рекурсию
using System;
using static System.Console;

Clear();

Write($"{Factorial(5)}");

int Factorial (int n) {
	if (n == 1) 	return 1;
	else			return n * Factorial(n - 1);
}

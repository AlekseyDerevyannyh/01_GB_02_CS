// Собрать строку с числами от a до b, a <= b
using System;
using static System.Console;

Clear();
WriteLine(NumbersRec(2, 5));

string NumbersRec (int a, int b) {
	if (a <= b) return $"{a} " + NumbersRec(a + 1, b);
	else		return String.Empty;
}
// Заполняем двумерную матрицу числами и выводим её на экран
using System;
using static System.Console;

Clear();
int[,] matrix = new int[3,4];
PrintArray(matrix);
FillArray(matrix);
WriteLine();
PrintArray(matrix);

void PrintArray(int[,] matr) {
	for (int i = 0; i < matr.GetLength(0); i ++) {
		for (int j = 0; j < matr.GetLength(1); j ++) {
			Write($"{matr[i, j]} ");
		}
		WriteLine();
	}
}

void FillArray (int[,] matr) {
	for (int i = 0; i < matr.GetLength(0); i ++) {
		for (int j = 0; j < matr.GetLength(1); j ++) {
			matr[i, j] = new Random().Next(1, 10);
		}
	}
}
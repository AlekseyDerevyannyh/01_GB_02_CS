// Задача 21. Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D
using System;
using static System.Console;

Clear();
int xa, ya, za,
	xb, yb, zb;
Write ("Введите координату х точки А: xa = ");
if (!int.TryParse(ReadLine(), out xa)) {
	WriteLine("Ошибка ввода числа!");
	return;
}
Write ("Введите координату y точки А: ya = ");
if (!int.TryParse(ReadLine(), out ya)) {
	WriteLine("Ошибка ввода числа!");
	return;
}
Write ("Введите координату z точки А: za = ");
if (!int.TryParse(ReadLine(), out za)) {
	WriteLine("Ошибка ввода числа!");
	return;
}
Write ("Введите координату х точки B: xb = ");
if (!int.TryParse(ReadLine(), out xb)) {
	WriteLine("Ошибка ввода числа!");
	return;
}
Write ("Введите координату y точки B: yb = ");
if (!int.TryParse(ReadLine(), out yb)) {
	WriteLine("Ошибка ввода числа!");
	return;
}
Write ("Введите координату z точки B: zb = ");
if (!int.TryParse(ReadLine(), out zb)) {
	WriteLine("Ошибка ввода числа!");
	return;
}
WriteLine($"A({xa},{ya},{za}); B({xb},{yb},{zb}) -> {Math.Sqrt(Math.Pow((xb - xa), 2) + Math.Pow((yb - ya), 2) + Math.Pow((zb - za), 2)):f2}");

// Задача 2: Напишите программу, которая выводит случайное трёхзначное
// число и удаляет вторую цифру этого числа
using System;
using static System.Console;

Clear();
int number = new Random().Next(100, 1000);
Write("{0} -> {1}", number, (number / 100) * 10 + (number % 10));

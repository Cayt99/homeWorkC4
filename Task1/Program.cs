﻿// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите степень: ");
int numberB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Число {numberA} В степени {numberB} Равна {Math.Pow(numberA, numberB)}");

// Console.Write("Введите число: ");
// int numberA = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите степень: ");
// int numberB = Convert.ToInt32(Console.ReadLine());

// int result = 1;

// for (int i = 1; i <= numberB; i++)
// {
//     result *= numberA;
// }

// Console.WriteLine($"Число {numberA} в степени {numberB} равно {result}");

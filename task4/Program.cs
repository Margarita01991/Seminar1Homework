﻿// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел. 2, 3, 7 -> 7; 44 5 78 -> 78; 22 3 9 -> 22
Console.WriteLine("Введите число А: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число C: ");
int numberC = Convert.ToInt32(Console.ReadLine());

int max = numberA;

if (numberA > max ) max = numberA; //можно убрать, так как в 9 строке уже есть max = numberA
if (numberB > max ) max = numberB;
if (numberC > max ) max = numberC;

Console.Write("Максимальное число равно ");    
Console.WriteLine(max);

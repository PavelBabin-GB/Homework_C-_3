﻿// Программа, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.Write("Введите целое число: ");
int number = int.Parse(Console.ReadLine());
double Result(int iLocal)
{
    return Math.Pow(iLocal, 3);
}
for (int i = 1; i <= number; i++)
{
    Console.WriteLine(Result(i));
} 
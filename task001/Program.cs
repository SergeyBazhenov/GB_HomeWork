﻿//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Write("Введите первое число: ");
string inputA = Console.ReadLine();
Console.Write("Введите второе число: ");
string inputB = Console.ReadLine();
int a = Convert.ToInt32(inputA);
int b = Convert.ToInt32(inputB);
if (a == b)
{
    Console.WriteLine("Числа равны!");
}
else if (a > b)
{
    Console.WriteLine("Число " + a + " больше числа " + b);
}
else
{
    Console.WriteLine("Число " + b + " больше числа " + a);
}
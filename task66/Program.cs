﻿Console.Write("Введите M: ");
var str = Console.ReadLine() ?? "";
var M = int.Parse(str);
Console.Write("Введите N: ");
str = Console.ReadLine() ?? "";
var N = int.Parse(str);

if (M > N)
{
    Console.WriteLine("Начальное число промежутка больше конечного.");
    return;
}

var sum = 0;

for (int i = M; i <= N; i++)
    sum += i;

Console.WriteLine($"Сумма натуральных чисел в промежуте от {M} до {N} равна: {sum}");
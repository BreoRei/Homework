// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Введите число номер 1: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число номер 2: ");
int numB = Convert.ToInt32(Console.ReadLine());
int Max = numA;

if (Max > numB)
{
    Console.WriteLine("Max = " + numA);
    Console.WriteLine("Min = " + numB);
}
else
{
    Console.WriteLine("Max = " + numB);
    Console.WriteLine("Min = " + numA);
}
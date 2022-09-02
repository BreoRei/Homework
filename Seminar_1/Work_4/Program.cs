// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Введите число номер 1: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число номер 2: ");
int numB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число номер 3: ");
int numC = Convert.ToInt32(Console.ReadLine());
int Max = numA;
int help = 0;

if (numB < numC)
{
    help = numC;
}
else
{
    help = numB;
}
if (Max < help)
{
    Max = help;
}
Console.Write(Max);

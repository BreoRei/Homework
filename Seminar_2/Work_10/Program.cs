// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (100 <= num && num < 1000)
{
    num = (num %= 100) / 10;
    Console.WriteLine($"{num}");
}
else
    Console.WriteLine($"Не верный ввод");

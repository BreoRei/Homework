// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int n1 = 0;

if (99 < num)
{
    while (num > 999)
    {
        n1 = num / 10;
        num = n1;
    }
    n1 = num % 10;
    Console.WriteLine($"{n1}");
}
else
    Console.WriteLine($"Третьей цифры нет");

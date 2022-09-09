// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Console.Write("Введите число A: ");
// int numA = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число B: ");
// int numB = Convert.ToInt32(Console.ReadLine());

// int degree = numA;
// for (; numB > 1; numB--)
// {
//     sum *= numA;
// }
// Console.Write($"{degree}");

Console.Write("Введите число A: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int numB = Convert.ToInt32(Console.ReadLine());

int degree = numA;
for (int i = 1; numB > i; i++)
{
    degree *= numA;
}
Console.Write($"Число {numA} в степени {numB} = {degree}");
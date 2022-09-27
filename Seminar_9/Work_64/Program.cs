// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void PrintTextToString(String text)
{
    Console.Write(text);
}

int UserInput()
{
    int a = Convert.ToInt32(Console.ReadLine());
    return a;
}

void Integers(int num)
{
    if (num != 0)
    {
        PrintTextToString($"{num} ");
        Integers(num - 1);
    }
}

Console.Clear();
PrintTextToString("Введите число: ");
int number = UserInput();
Console.Clear();
PrintTextToString($"Промежуток натуральных элементов от:\nN = {number} -> ");
Integers(number);
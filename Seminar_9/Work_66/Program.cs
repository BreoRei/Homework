// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

void PrintTextToString(String text)
{
    Console.Write(text);
}

int UserInput()
{
    int a = Convert.ToInt32(Console.ReadLine());
    return a;
}

int Integers(int i, int j, int s)
{
    if (j != i)
    {
        s += i;
        return Integers(i + 1, j, s);
    }
    return s;
}

Console.Clear();
PrintTextToString("Введите начальное число промежутка: ");
int a = UserInput();
PrintTextToString("Введите конечное число промежутка: ");
int b = UserInput();
int sum = b;
Console.Clear();
PrintTextToString($"Сумму натуральных элементов:\nM = {a}; N = {b} -> {Integers(a, b, sum)}");

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


void PrintTextToString(String text)
{
    Console.Write(text);
}

int UserInput()
{
    int a = Convert.ToInt32(Console.ReadLine());
    return a;
}

double Integers(double m, double n)
{
    if (m == 0) return n + 1;
    else if (m != 0 && n == 0) return Integers(m - 1, 1);
    else return Integers(m - 1, Integers(m, n - 1));
}

Console.Clear();
PrintTextToString("Введите число M: ");
double a = UserInput();
PrintTextToString("Введите число N: ");
double b = UserInput();
Console.Clear();
PrintTextToString($"m = {a}, n = {b} -> A(m,n) = {Integers(a, b)}");


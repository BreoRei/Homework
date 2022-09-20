// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

void PrintTextToString(String text)
{
    Console.Write(text);
}

int UserInput()
{
    int a = Convert.ToInt32(Console.ReadLine());
    return a;
}

double[,] FillingAnArray(int m, int n, int min, int max)
{
    double[,] arr = new double[m, n];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = Math.Round(Convert.ToDouble(new Random().Next(min, max) * 0.1), 1);
        }
    }
    return arr;
}

void PrintArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

PrintTextToString("Введите количество строк: ");
int line = UserInput();
PrintTextToString("Введите количество столбцов: ");
int column = UserInput();
PrintTextToString("Введите начальное значение массива: ");
int first = UserInput();
PrintTextToString("Введите конечное значение массива: ");
int second = UserInput();
Console.Clear();
double[,] array = FillingAnArray(line, column, first, second);
PrintArray(array);
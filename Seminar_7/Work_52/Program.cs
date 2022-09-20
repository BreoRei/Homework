// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void PrintTextWithLineBreak(String text = "")
{
    Console.WriteLine(text);
}

void PrintTextToString(String text)
{
    Console.Write(text);
}

int UserInput()
{
    int a = Convert.ToInt32(Console.ReadLine());
    return a;
}

int[,] FillingAnArray(int m, int n, int min, int max)
{
    int[,] arr = new int[m, n];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(min, max);
        }
    }
    return arr;
}

double[] ArithmeticMeanOfAColumn(int[,] arr)
{
    double[] arrA = new double[arr.GetLength(1)];
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            sum += arr[i, j];
        }
        arrA[j] = Math.Round(sum / arr.GetLength(0), 1);
    }
    return arrA;
}

void PrintTwoArray(int[,] arr)
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

void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i != arr.Length - 1) Console.Write($"{arr[i]}; ");
        else Console.Write($"{arr[i]}. ");
    }
}

PrintTextToString("Введите количество строк: ");
int line = UserInput();
PrintTextToString("Введите количество столбцов: ");
int column = UserInput();
PrintTextToString("Введите начальное значение диапазона для массива: ");
int first = UserInput();
PrintTextToString("Введите конечное значение диапазона для массива: ");
int second = UserInput();
Console.Clear();
int[,] twoArray = FillingAnArray(line, column, first, second);
PrintTwoArray(twoArray);
PrintTextWithLineBreak();
PrintTextToString("Среднее арифметическое каждого столбца: ");
double[] oneArray = ArithmeticMeanOfAColumn(twoArray);
PrintArray(oneArray);




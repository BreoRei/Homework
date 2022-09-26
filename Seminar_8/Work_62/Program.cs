// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

void PrintTextToString(String text)
{
    Console.Write(text);
}

int UserInput()
{
    int a = Convert.ToInt32(Console.ReadLine());
    return a;
}

int[,] FillArray(int[,] arr)
{
    int numbersInAnArray = arr.GetLength(0) * arr.GetLength(1);
    int i = 0;
    int j = 0;
    int side = 0;
    int circle = 0;
    arr[i, j] = 1;
    for (int h = 2; h <= numbersInAnArray; h++)
    {
        if ((j + 1 < arr.GetLength(1) - circle && side == 0))
        {
            arr[i, j + 1] = h;
            j++;
            if (j == arr.GetLength(1) - 1 - circle) side++;
        }
        else if (i + 1 + circle < arr.GetLength(0) && side == 1)
        {
            arr[i + 1, j] = h;
            i++;
            if (i == arr.GetLength(0) - 1 - circle) side++;
        }
        else if (j - 1 - circle >= 0 && side == 2)
        {
            arr[i, j - 1] = h;
            j--;
            if (j == 0 + circle)
            {
                side++;
                circle++;
            }
        }
        else if (i - 1 - circle >= 0 && side == 3)
        {
            arr[i - 1, j] = h;
            i--;
            if (i == 0 + circle) side = 0;
        }
    }
    return arr;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            string a = Convert.ToString((arr[i, j]));
            if (1 == a.Length) Console.Write($"0{arr[i, j]} ");
            else Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

Console.Clear();
PrintTextToString("Введите количество строк: ");
int line = UserInput();
PrintTextToString("Введите количество столбцов: ");
int column = UserInput();
int[,] array = new int[line, column];
Console.Clear();
PrintArray(FillArray(array));


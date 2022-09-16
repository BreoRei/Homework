// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

void PrintTextToString(String text)
{
    Console.Write(text);
}

void ArrayСreation(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Clear();
        Console.Write("Введите число: ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
}

void NumbersAfterZero(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) count++;

    }
    Console.Write($"{count}");
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
}
Console.Clear();
PrintTextToString("Сколько чисел вы хотите ввести: ");
int numbers = Convert.ToInt32(Console.ReadLine());
int[] array = new int[numbers];
ArrayСreation(array);
PrintArray(array);
PrintTextToString($" -> ");
NumbersAfterZero(array);








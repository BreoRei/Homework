// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

Console.Write("Введите число массива: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите диапозон для массива: ");
int A = Convert.ToInt32(Console.ReadLine());
int B = Convert.ToInt32(Console.ReadLine());

int[] array = new int[number];

for (int index = 0; index < number; index++)
{
    array[index] = new Random().Next(A, B);
    Console.Write($"{array[index]}, ");
}
    
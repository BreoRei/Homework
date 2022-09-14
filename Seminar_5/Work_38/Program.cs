// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Clear();
Console.Write("Введите длинну массива: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите диапазон чисел в  массиве:\nПервая величина -> ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Вторая величина -> ");
int numB = Convert.ToInt32(Console.ReadLine());

double[] array = new double[number];

for (int index = 0; index < number; index++)
{
    array[index] = Math.Round((new Random().Next(numA, numB) * 0.1), 1);
    Console.Write($"{array[index]} ");
}
Console.WriteLine();

double minNumber = array[0];
double maxNumber = array[0];
for (int index = 1; index < number; index++)
{
    if (array[index] < minNumber)
    {
        minNumber = array[index];
    }
    if (array[index] > maxNumber)
    {
        maxNumber = array[index];
    }
}
double comparison = maxNumber - minNumber;
Console.WriteLine($"Разница между {minNumber} и {maxNumber} элементом = {comparison}");
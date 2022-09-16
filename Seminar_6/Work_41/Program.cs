// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

void PrintTextToString(String text)
{
    Console.Write(text);
}

int count = 0;
for (int i = 0; ; i++)
{
    Console.Clear();
    PrintTextToString("Хотите ввести число? Введите 1 если 'да'\nЛюбую другую цифру есть нет: ");
    int examination = Convert.ToInt32(Console.ReadLine());
    if (examination == 1)
    {
        PrintTextToString("Введите число: ");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number > 0)
        {
            count++;
        }
    }
    else break;
}
PrintTextToString($"Чисел больше 0 = {count}");
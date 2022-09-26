// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void PrintTextToString(String text)
{
    Console.Write(text);
}

double NumberIntroduction()
{
    double number = Convert.ToDouble(Console.ReadLine());
    return number;
}
Console.Clear();
PrintTextToString("Введите длину b1: ");
double b1 = NumberIntroduction();
PrintTextToString("Введите угол  k1: ");
double k1 = NumberIntroduction();
PrintTextToString("Введите длину b2: ");
double b2 = NumberIntroduction();
PrintTextToString("Введите угол  k2: ");
double k2 = NumberIntroduction();

if (k1 == k2 && b1 == b2)
{
    PrintTextToString($"Точки пересечения бесконечны, прямые равны.");
}
else if (k1 == k2 && b1 != b2)
{
    PrintTextToString($"Точки пересечения отсутствуют, прямые параллельны.");
}
else
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * (b2 - b1) / (k1 - k2) + b1;
    PrintTextToString($"Точка пересечения прямых b1 и b2 в координате по (x:y) = ({x}:{y})");
}

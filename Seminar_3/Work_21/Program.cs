// Задача.21 Напишите программу, которая принимает на вход координаты двух точек и 
//находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите три кординаты точки A:");
Console.Write("по x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("по y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("по z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите три кординаты точки B:");
Console.Write("по x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("по y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("по z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double AB = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
Console.Clear();
Console.WriteLine($"Расстояние между точками AB в 3D пространстве: \n{AB}");

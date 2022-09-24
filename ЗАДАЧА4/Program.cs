// Найти расстояние между точками в пространстве 2D/3D

//Решение для расстояние между точками в пространстве 3D
Console.WriteLine("Введите значение x1");
double x1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите значение x2");
double x2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите значение y1");
double y1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите значение y2");
double y2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите значение z1");
double z1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите значение z2");
double z2 = double.Parse(Console.ReadLine());
double distance1 = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
Console.WriteLine("Расстояние между точками в пространстве 3D: " + distance1);

//Решение для расстояние между точками в пространстве 2D
double distance2 = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
Console.WriteLine("Расстояние между точками в пространстве 2D: " + distance2);
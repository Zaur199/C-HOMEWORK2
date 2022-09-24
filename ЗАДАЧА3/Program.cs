// Задать номер четверти, показать диапазоны для возможных координат
Console.WriteLine("Введите координату x");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату y");
int y = int.Parse(Console.ReadLine());

if(x > 0 && y > 0)
{
   Console.WriteLine("Точка в 1-й четверти"); 
}

if(x < 0 && y > 0)
{
   Console.WriteLine("Точка во 2-й четверти");  
}

if(x < 0 && y < 0)
{
   Console.WriteLine("Точка в 3-й четверти");  
}

if(x > 0 && y < 0)
{
   Console.WriteLine("Точка во 2-й четверти");  
}
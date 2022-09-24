//Дано число обозначающее день недели. Выяснить является номер дня недели выходным
Console.WriteLine("Введите число в диапазоне");
int number = int.Parse(Console.ReadLine());

if(number==6 || number==7)
{
    Console.WriteLine("Номер дня недели является выходным");
}

else
     Console.WriteLine("Номер дня недели не является выходным");
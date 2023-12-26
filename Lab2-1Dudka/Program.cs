Console.Write("Введите x: ");
double x = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите y: ");
double y = Convert.ToDouble(Console.ReadLine());
if (x >= y && x >= -y && x <= 1)
{
    Console.WriteLine("Принадлежит");
}
else
{
    Console.WriteLine("Не принадлежит");
}
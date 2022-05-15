// Отрисовка треугольника

Console.Write("Введите высоту треугольника: ");
int heigth = int.Parse(Console.ReadLine());

for (int i = 0; i < heigth; i++)
{
    for (int j = 0; j <= i; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}
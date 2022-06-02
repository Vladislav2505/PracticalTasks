// Таблица умножения 

Console.WriteLine("Таблица умножония\n");

for (int i = 1; i < 9; i++)
{
    Console.WriteLine($"На {i}\n");
    for (int j = 1; j < 9; j++)
    {
        Console.WriteLine($"{i} * {j} = {i * j}\t");
    }
    Console.WriteLine("\n");
}
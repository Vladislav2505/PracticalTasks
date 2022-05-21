// Метод вывода строки на экран

static void PrintLine(string sign, uint quantity)
{
    for (int i = 0; i < quantity; i++)
    {
        Console.Write(sign + " ");
    }
}

Console.Write("Введите символ: ");
string symbol = Console.ReadLine();

Console.Write("Количество повторений: ");
uint symbolsCount = uint.Parse(Console.ReadLine());

PrintLine(symbol, symbolsCount);
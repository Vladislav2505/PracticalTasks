// Счетчик четных и нечетных чисел

uint oddNumbersCount = 0;
uint evenNumbersCount = 0;
int sumevenNumbersCount = 0;
int sumoddNumbersCount = 0;

Console.Write("Введите первое число диапозона: ");
int currentValue = int.Parse(Console.ReadLine());

Console.Write("Введите второе число диапозона: ");
int limit = int.Parse(Console.ReadLine());

while (currentValue <= limit)
{
    if (currentValue % 2 == 0)
    {
        evenNumbersCount++;
        sumevenNumbersCount += currentValue;
    }
    else
    {
        oddNumbersCount++;
        sumoddNumbersCount += currentValue;
    }
    currentValue++;
}

Console.WriteLine($"Количество четных чисел: {evenNumbersCount}");
Console.WriteLine($"Количество нечетных чисел: {oddNumbersCount}");
Console.WriteLine($"Сумма всех четных числе: {sumevenNumbersCount}");
Console.WriteLine($"Сумма всех нечетных чисел: {sumoddNumbersCount}");
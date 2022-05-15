// Простой калькулятор

while (true)
{
    Console.Clear();

    double firstNumber, secondNumber;
    char sign;

    try
    {
        Console.Write("Введите первое число: ");
        firstNumber = double.Parse(Console.ReadLine());

        Console.Write("Введите второе число: ");
        secondNumber = double.Parse(Console.ReadLine());
    }
    catch (Exception)
    {
        Console.WriteLine("Введите ЧИСЛО!!!!");
        Console.ReadLine();
        continue;
    }

    Console.Write("Введите первое число: ");
    firstNumber = double.Parse(Console.ReadLine());

    Console.Write("Введите второе число: ");
    secondNumber = double.Parse(Console.ReadLine());

    Console.Write("Введите математический знак(+, -, *, /): ");
    sign = char.Parse(Console.ReadLine());

    switch (sign)
    {
        case ('+'):
            Console.WriteLine($"Твой ответ: {firstNumber + secondNumber}");
            break;
        case ('-'):
            Console.WriteLine($"Твой ответ: {firstNumber - secondNumber}");
            break;
        case '*':
            Console.WriteLine($"Твой ответ: {firstNumber * secondNumber}");
            break;
        case ('/'):
            if (secondNumber == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine($"Твой ответ: {firstNumber / secondNumber}");
            }
            break;
        default:
            Console.WriteLine("Умные люди на 0 не делят)))");
            break;
    }

    Console.ReadLine();
}


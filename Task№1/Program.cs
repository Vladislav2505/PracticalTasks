//Среднее арифметическое.

double firestValue, secondValue;

Console.WriteLine("Введите число 1");
firestValue = double.Parse(Console.ReadLine());
Console.WriteLine("Введите число 2");
secondValue = Convert.ToDouble(Console.ReadLine());

double result = ((firestValue + secondValue) / 2);

Console.WriteLine($"Среднее арифметическое двух чисел = {result}");

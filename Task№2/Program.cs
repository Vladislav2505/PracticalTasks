//Сумма и произведение трех чисел.

double firestValue, secondValue, thirdValue;

Console.WriteLine("Введите число 1");
firestValue = double.Parse(Console.ReadLine());
Console.WriteLine("Введите число 2");
secondValue = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число 3");
thirdValue = Convert.ToDouble(Console.ReadLine());

double sumResult = ((firestValue + secondValue + thirdValue));
double multResult = (firestValue * secondValue * thirdValue);

Console.WriteLine($"Сумма трех чисел = {sumResult}");
Console.WriteLine($"Произведение трех чисел = {multResult}");
//Ковертор валют

double UsdToRub = 68.45;
double UsdToUah = 27.24;
double USD;

Console.WriteLine("Введите сумму в USD");
USD = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(USD + " USD" + " в RUB = " + USD * UsdToRub);
Console.WriteLine(USD + " USD" + " в Uah = " + USD * UsdToUah);


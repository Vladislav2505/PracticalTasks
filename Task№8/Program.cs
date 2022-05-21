// Массивы


//int[] newArray = new int[5];

//Console.WriteLine("Введие элементы массива");

//for (int i = 0; i < newArray.Length; i++)
//{
//    newArray[i] = int.Parse(Console.ReadLine());
//}

//Console.Write("Массив: ");

//for (int j = 0; j < newArray.Length; j++)
//{
//    Console.Write(newArray[j]);
//}


int[] newArray = { 1, 2, 3, 4, 5, 6 };

Console.WriteLine("Массив: ");

for (int j = 0; j < newArray.Length; j++)
{
    Console.WriteLine(newArray[j]);
}

Console.WriteLine("Массив в обратном порядке: ");

for (int i = newArray.Length - 1; i >= 0; i--)
{
    Console.WriteLine(newArray[i]);
}
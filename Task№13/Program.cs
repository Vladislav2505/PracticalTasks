// Изменение размера массива

static void Resize(ref int[] arr, ref int newSize)
{
    int[] newArray = new int[newSize];

    for (int i = 0; i < arr.Length && i < newArray.Length; i++)
    {
        newArray[i] = arr[i];
    }
    arr = newArray;
}

int[] myArray = { 1, 4, 5 };
Console.Write("Массив: ");

for (int i = 0; i < myArray.Length; i++)
{
    Console.Write(myArray[i] + " ");
}

Console.Write("\nВведите кол элементов массива: ");
int value = int.Parse(Console.ReadLine());


Resize(ref myArray, ref value);

for (int i = 0; i < myArray.Length; i++)
{
    Console.WriteLine(myArray[i]);
}


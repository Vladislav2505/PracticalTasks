// Минимальный элемент массива

int[] myArray = { 123, 3, 12, 44, 56, 99 };
int minValue = myArray[0];

for (int i = 0; i < myArray.Length; i++)
{
    if (myArray[i] < minValue)
    {
        minValue = myArray[i];
    }
}

Console.WriteLine($"Минимальный элемент массива:\t{minValue}");
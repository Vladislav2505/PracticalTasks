// Метод нахождения элемента по индексу
static int indexFind(int[] array, int value)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == value)
        {
            return i;
        }
    }
    return -1;
}

// Метод создания случайного массива
static int[] randomArray(uint lenght, int minValue, int maxValue)
{
    int[] myArray = new int[lenght];
    Random rand = new Random();

    for (int i = 0; i < myArray.Length; i++)
    {
        myArray[i] = rand.Next(minValue, maxValue);
    }
    return myArray;
}

int[] myArray = randomArray(10, -10, 10);
int index;

Console.Write("Массив: ");
for (int i = 0; i < myArray.Length; i++)
{
    Console.Write(myArray[i] + " ");
}

Console.Write("\nВведите номер элемента: ");
index = int.Parse(Console.ReadLine());

Console.WriteLine("Индекс элемента: " + indexFind(myArray, index));

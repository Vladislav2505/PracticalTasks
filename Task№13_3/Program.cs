// Удаление элемента из массива по индексу 

static void Insert(ref int[] array, int index)
{
    int[] newArray = new int[array.Length - 1];

    for (int i = 0; i < index; i++)
        newArray[i] = array[i];

    for (int i = index + 1; i < newArray.Length; i++)
        newArray[i - 1] = array[i];

    array = newArray;
}

int[] myArray = { 1, 3, 5, 45, 34, 1, 3 };

Console.Write("Массив: ");

for (int i = 0; i < myArray.Length; i++)
{
    Console.Write(myArray[i] + " ");
}


Console.Write($"\nИндекс не более {myArray.Length}: ");
int index = int.Parse(Console.ReadLine());

Insert(ref myArray, index);

Console.Write("Новый массив: ");
for (int i = 0; i < myArray.Length; i++)
{
    Console.Write(myArray[i] + " ");
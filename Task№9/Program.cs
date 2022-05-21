// Сумма четныx чисел массива

int[] myArray = new int[10] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

int[] evenNumber = new int[5];
int sumEvenNumber = 0;

Console.Write("Массив: ");

for (int e = 0; e < myArray.Length; e++)
{
    Console.Write(myArray[e]);
}

for (int i = 0, q = 0; i < myArray.Length; i++)
{
    if(myArray[i] % 2 == 0)
    {
        evenNumber[q] = myArray[i];
        sumEvenNumber += myArray[i];
        q++;
    }
}

Console.Write("\nЧетные числа массива: ");

for (int j = 0; j < evenNumber.Length; j++)
{
    Console.Write(evenNumber[j]);
}

Console.Write("\nСумма четных чисел массива: " + sumEvenNumber);


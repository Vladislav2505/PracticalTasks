// Сумма цифр числа

static int Foo(int value)
{
    if (value < 10)
    {
        return value;
    }

    return value % 10 + Foo(value / 10);
}


int value = 561;
int result = Foo(value);

Console.WriteLine(result);

//int value = 157;
//int i = 0;

//while (value > 0)
//{
//    i += value % 10;
//    value /= 10;
//}

//Console.WriteLine(i);
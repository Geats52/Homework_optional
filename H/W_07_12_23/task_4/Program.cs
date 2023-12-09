// Задача 4**(не обязательно): Дано натуральное число в диапазоне от 1 до 100 000. Создайте массив, состоящий из цифр этого числа. 
//Старший разряд числа должен располагаться на 0-м индексе массива, младший – на последнем. Размер массива должен быть равен количеству цифр.

void Print(int [] arr)
{
    int size = arr.Length;

    for(int i = 0; i < size; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

int[] MassNums(int size, int num)
{
    int[] arr = new int[size];

    for(int i = size - 1; i >= 0; i--)
    {
        arr[i] = num % 10;
        num /= 10;
    }
    return arr;
}

int NumLen(int number)
{
    int count = 0;

    for(; number > 0; number /= 10)
        count += 1;
    return count;
}



int num = new Random().Next(1, 100001);
int result = NumLen(num);
Console.WriteLine(num);
int[] mass = MassNums(result, num);
Print(mass);


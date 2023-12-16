// Задание 3: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//НЕ РАБОТАЕТ!

void Print(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
            Console.Write($"{arr[i,j]} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] MassNums(int row, int column,int from, int to)
{
    int[,] arr = new int[row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            arr[i,j] = new Random().Next(from, to + 1);
    
    return arr;
}

string SumNum(int[,] arr)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);
    int[] all_nums = new int[row];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            all_nums[i] += arr[i, j];
        }
    }
    return all_nums;
}


string FindMin(int[,] arr)
{
    int min_ind = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < arr[min_ind]) min_ind = i;
    }
    Console.WriteLine($"Sum of elements: {arr[min_ind]}, line: {min_ind + 1}");
}

Console.Write("Enter the number of rows: ");
int row_num = int.Parse(Console.ReadLine()!);
Console.Write("Enter the number of columns: ");
int column_num = int.Parse(Console.ReadLine()!);

Console.Write("Enter the min number of massive ");
int start = int.Parse(Console.ReadLine()!);
Console.Write("Enter the max number of massive ");
int stop = int.Parse(Console.ReadLine()!);

int[,] mass = MassNums(row_num, column_num, start, stop);
Print(mass);

int[] mass_sum = SumNums(mass);
FindMin(mass_sum);
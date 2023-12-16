//  Задание 4*(не обязательная): Задайте двумерный массив из целых чисел. 
//Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива. 
//Под удалением понимается создание нового двумерного массива без строки и столбца
//НЕ РАБОТАЕТ
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

int[] MinEl(int[,] arr, int f, int s)
{
    int row = arr.GetLength(0);
    int  column = arr.GetLength(1);
    int min_num = arr[0, 0];
    int [] indexes = new int[2];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        if(min_num > arr[i, j])
        {
            min_num = arr[i, j];
            indexes[0] = i;
            indexes[1] = j;
        }
    }
    Console.WriteLine(arr[indexes[0], indexes[1]]);
    return indexes;    
}

void WithoutRowColumn(int[,] arr,  int[] m_insexes)
{
    int row = arr.GetLength(0);
    int  column = arr.GetLength(1);
   
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
            if(m_insexes[0] == i || m_insexes[1] == j) continue;
            else Console.WriteLine($"{arr[i,j],3}");
        Console.WriteLine();      
    }
    Console.WriteLine();   
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

int[] mass_new = MinEl(mass);
WithoutRowColumn(mass, mass_new);
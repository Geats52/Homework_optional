// Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли. Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого четная.

void Print(int[] arr)
{
while(true)
    {
        Console.Write("Введите число или 'q' для выхода: ");
        string input = Console.ReadLine();

        if (input == "q")
        {
            break;
        }
    }
}

int number;
if(int.TryParse(input, out number))
{
int sum = 0;
while (number > 0)
    {
        sum += number % 10;
        number /= 10;
    }
    if (sum % 2 == 0)
    {
        Console.WriteLine("[STOP]");
        break;
    }
}

else
{
    Console.WriteLine("Неверный ввод. Пожалуйста, введите целое числоили 'q'.");

}

Print();
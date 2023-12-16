// Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли. Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого четная.

void InfEnter()
{
    string word;

    while (true)
    {
        Console.Write("Output any number: ");
        word = Console.ReadLine();
        if(word != "q")
        {
            int count = 0;
            int number = 0;
            number = int.Parse(word);
            for(; number > 0; number /= 10)
                count += number % 10;

            if (count % 2 == 0)
            {
                Console.WriteLine("Game is over! Number is odd");
                return;
            }
        }
        else
            return;
    }
}

InfEnter();



//Мой неправилный вариант

// void Print(int[] arr)
// {
// while(true)
//     {
//         Console.Write("Введите число или 'q' для выхода: ");
//         string input = Console.ReadLine();

//         if (input == "q")
//         {
//             break;
//         }
//     }
// }

// int number;
// if(int.TryParse(input, out number))
// {
// int sum = 0;
// while (number > 0)
//     {
//         sum += number % 10;
//         number /= 10;
//     }
//     if (sum % 2 == 0)
//     {
//         Console.WriteLine("[STOP]");
//         break;
//     }
// }

// else
// {
//     Console.WriteLine("Неверный ввод. Пожалуйста, введите целое числоили 'q'.");

// }

// Print();
//Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//Неправвильно решенная

int m = InputNumbers("Введите m: ");
int n = InputNumbers("Введите n: ");

int functionAkkerman = A(m, n);

Console.Write($"Функция Аккермана = {functionAkkerman} ");

int A(int m, int n)
{
    if (n == 0) return m + 1;
    if (n != 0 && m == 0) return A(n - 1, 1);
    if (n > 0 && m > 0) return A(n - 1, A(n, m - 1));
    return A(n,m);
}

int InputNumbers(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

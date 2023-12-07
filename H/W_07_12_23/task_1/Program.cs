// Задача 1: Задайте одномерный массив из 10 целых чисел от 1 до 100. Найдите количество элементов массива, значения которых лежат в отрезке [20,90].

namespace task_1
{
    public class Task_01
    {

        public const int MIN = 1;
        public const int MAX = 100;

        public const int FROM = 20;
        public const int TO = 90;

       public static void Main(string[] args) {
        System.Console.Write("Size Array: ");

        int arraySize = GetArraySizeFromConsole();
        while (arraySize < 0) {
            arraySize = GetArraySizeFromConsole();
        }

        int[] array = GetArrayWithRandomValue(arraySize);

        System.Console.WriteLine("Array:");
        System.Console.WriteLine(PrintArray(array));

        System.Console.WriteLine($"Array range {FROM} to {TO}:");
        System.Console.WriteLine(CountElementInRange(FROM, TO, array));
       }

        public static int GetArraySizeFromConsole() {
            try{
                return Convert.ToInt32(Console.ReadLine());
            } catch (Exception)
                {
                System.Console.WriteLine("Error.");
            }
            return -1;
        }

        public static int[] GetArrayWithRandomValue(int size) {
            int[] array = new int[size];
            for(int i = 0; i < size; i++) {
                array[i] = new Random().Next(MIN, MAX);
            }
            return array;
        }

        public static int CountElementInRange(int from, int to, int[] array) {
            int count = 0;
            foreach(int item in array) {
                if(from <= item & item <= to) count++;
            }
            return count;
        }

        public static string PrintArray(int[] array) {
            string result = "";
            foreach(int item in array) {
                result = result + item + " ";
            }
            return result;
        }  
    }
}
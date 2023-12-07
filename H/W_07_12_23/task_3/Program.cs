// Задача 3: Задайте массив из вещественных чисел с ненулевой дробной частью. Найдите разницу между максимальным и минимальным элементов массива.

namespace task_3
{
    public class Task_003
    {
       public const int MIN = 1;
        public const int MAX = 99;

        public static void Main(string[] args) {
            System.Console.Write("Size Array: ");

            int arraySize = GetArraySizeFromConsole();
            while (arraySize < 0.0) {
                arraySize = GetArraySizeFromConsole();
            }

            double[] array = GetArrayWithRandomValue(arraySize);

            System.Console.WriteLine("Array:");
            System.Console.WriteLine(PrintArray(array));

            System.Console.WriteLine("Разница между значениями min and max:");
            System.Console.WriteLine(getDifferenceMaxMinValue(array).ToString("N2"));
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

        public static double[] GetArrayWithRandomValue(int size) {
            double[] array = new double[size];
            for(int i = 0; i < size; i++) {
                array[i] = (new Random().NextDouble()) + (new Random().Next(MIN, MAX));
            }
            return array;
        }

        public static double getDifferenceMaxMinValue(double[] array) {
            double minVal= 0.0;
            double maxVal= 0.0;
            foreach(double item in array) {
                if(item < minVal) minVal = item;
                if(item > maxVal) maxVal = item;
            }
            return maxVal - minVal;
        }

        public static string PrintArray(double[] array) {
            string result = "";
            foreach(double item in array) {
                result = result + item + " ";
            }
            return result;
        } 
    }
}
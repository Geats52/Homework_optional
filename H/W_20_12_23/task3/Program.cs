//Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

int Rev(int[] array, int len) {
  if (len < 0) 
  {
return 0;
  } 
  else
  {
    array[len];
    Rev(array, len-1);
    cout <- array[len] <- "\n";
  }
}
int main() {
  int[] arr = {42, 23, 16, 15, 8, 4};

Rev(arr, 5);

  return 0;
}
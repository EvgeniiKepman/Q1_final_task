// Написать программу, которая из имеющегося массива строк формирует массив строк, длина которых меньше либо равна трем символам.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется
// пользоваться коллекциями. Лучше обойтись иключительно массивами.

Console.Clear();

Console.WriteLine("Введите колличество элементов в массиве: ");
int m = int.Parse(Console.ReadLine());

string[] array1 = new string[m];

for(int i = 0; i < m; i++)
{
  Console.WriteLine($"Введите {i + 1} элемент массива: ");
  array1[i] = Console.ReadLine();
}

string[] array2 = new string[m];

  int n = 0;
  for(int i = 0; i < array1.Length; i++)
  {
    if(array1[i].Length <= 3)
    {
      array2[n] = array1[i];
      n = n + 1;
    }
  }

  Console.Write("[");

  for (int i = 0; i < array1.Length; i++)
  {
    Console.Write($"{array1[i]}");

    if(i == array1.Length - 1)

      Console.Write("] -> [");

      else Console.Write(", ");
  }

  for (int i = 0; i < n; i++)
  {
    Console.Write($"{array2[i]}");

    if(i == n - 1)

      Console.Write("]");

      else Console.Write(", ");
  }
  Console.WriteLine();
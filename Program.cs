// Написать программу, которая из имеющегося массива строк формирует массив строк, длина которых меньше либо равна трем символам.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется
// пользоваться коллекциями. Лучше обойтись иключительно массивами.

Console.Clear();

// Ввод количества элементов в формируемом массиве
Console.WriteLine("Введите колличество элементов в массиве: ");
int m = int.Parse(Console.ReadLine());

// Создание исходного массива
string[] array1 = new string[m];

// Заполнение исходного массива данными с консоли
for(int i = 0; i < m; i++)
{
  Console.WriteLine($"Введите {i + 1} элемент массива: ");
  array1[i] = Console.ReadLine();
}

// Создание итогового массива
string[] array2 = new string[m];

// Отбор данных для итогового массива
int n = 0;
for(int i = 0; i < array1.Length; i++)
{
  if(array1[i].Length <= 3)
  {
    array2[n] = array1[i];
    n = n + 1;
  }
}

// Вывод исходного и итогового массива, согласно заданию
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

// Вывод нулевого массива, если нет удовлетворяющих элементов для итогового массива
if(n == 0)
Console.Write("]");

Console.WriteLine();
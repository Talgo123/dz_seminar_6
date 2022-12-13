// Задача 41:  Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 4


System.Console.Write("Введите цифры через пробел: ");
int[] array = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
int count = CountNumbers(array);
System.Console.WriteLine("[" + string.Join(", ", array) + "]" + " -> ", count);

int CountNumbers(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            count++;
        }
    }
    return count;
}

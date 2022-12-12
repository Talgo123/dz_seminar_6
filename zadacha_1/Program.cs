// Задача 41:  Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 4


System.Console.Write("Введите цифры через пробел: ");
string text = Console.ReadLine();
string[] result = text.Split(" ");
CountNumbers(result);

void CountNumbers(string[] text)
{
    int i = 0;
    while (i < result.Length)
    {
        i++;
    }
    System.Console.WriteLine(i);
}

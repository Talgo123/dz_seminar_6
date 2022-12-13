// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


int EntryNumber(string str)
{
    Console.WriteLine(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int b1 = EntryNumber("Введите координату b1: ");
int k1 = EntryNumber("Введите координату k1: ");
int b2 = EntryNumber("Введите координату b2: ");
int k2 = EntryNumber("Введите координату k2: ");
int x = FindCoordinate(b1, k1, b2, k2);
int y = k1 * x + b1;
System.Console.WriteLine($"Точка пересечения двух прямых равна ({x}, {y})");

int FindCoordinate(int b1, int k1, int b2, int k2)
{
    int x;
    x = (b2 - b1) / (k1 - k2);
    return x;
}

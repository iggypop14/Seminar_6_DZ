// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
//----------------- Создание функций, начало -------------------------------------------
int[] ReadInt(string text)
{
    System.Console.Write(text);
    int[] array = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
    return array;
}

double Find_x(int[] array)
{
    double b1 = array[0];
    double k1 = array[1];
    double b2 = array[2];
    double k2 = array[3];
    double x = (b2 - b1) / (k2 - k1);   // Решение
    return x;
}
//----------------------- Создание функций, конец ---------------------------------------
int[] array = ReadInt("Введите значения b1, k1, b2 и k2 через пробел. Клавиша 'Enter' - завершает ввод: ");
System.Console.WriteLine(Find_x(array));
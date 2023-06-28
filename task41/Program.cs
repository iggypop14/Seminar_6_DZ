// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
//int[] array = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
//----------------- Создание функций, начало -------------------------------------------
int[] ReadInt(string text)
{
   System.Console.Write(text);
    int[] array = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
    return array;
}

void SumF(int[] array, out int sum)
{
sum = 0;
for (int i = 0; i < array.Length; i++)
{
    if(array[i] > 0) sum += array[i];
}
System.Console.WriteLine(sum);
}
//----------------------- Создание функций, конец ---------------------------------------
int[] array = ReadInt("Введите числа через пробел. Клавиша 'Enter' - завершает ввод: ");
SumF(array, out int sum);
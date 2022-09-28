
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());


bool arr(int num)
{
    int a = number / 10000 % 10;
    int b = number / 1000 % 10;
    int c = number / 10 % 10;
    int d = number % 10;
    return a == d && b == c;


}
if (number < 10000 || number > 99999) Console.WriteLine("Не корректные значения");
else
{
    if (arr(number)) Console.Write($"да");
    else Console.Write($"нет");
}

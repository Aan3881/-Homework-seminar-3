// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

void cub(int number)
{
    int counter = 1;
    while (counter <= number)
    {
        Console.WriteLine($" |{counter,1}|  |{counter * counter * counter,3}| ");
        counter++;
    }
}
if (num > 0) cub(num);
else Console.WriteLine("Введено некорректное значение ");
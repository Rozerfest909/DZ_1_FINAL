// Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

int ReadInt(string message) 
{
    Console.Write($"{message} >"); 
    int value = Convert.ToInt32(Console.ReadLine()); 
    return value;
}

int num = ReadInt("Введите число ");

if (num % 2 == 1)
{
     num = num - 1;
     while (num != 0)
     {
        Console.WriteLine($"Четное число {num} ");
        num = num - 2;
     }
}
else
{
     while (num != 0)
     {
        Console.WriteLine($"Четное число {num} ");
        num = num - 2;
     }
}
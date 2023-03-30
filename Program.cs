// Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

int ReadInt(string message) 
{
    Console.Write($"{message} >"); 
    int value = Convert.ToInt32(Console.ReadLine()); 
    return value;
}

int num = ReadInt("Введите число ");

if (num % 2 == 1)
{
     Console.WriteLine($"Число {num} нечетное");
}
else
{
    Console.WriteLine($"Число {num} четное");
}
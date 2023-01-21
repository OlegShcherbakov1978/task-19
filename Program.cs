// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

begin:

System.Console.WriteLine("Введите пятизначное число: ");
string number = Console.ReadLine();
if (number.Length != 5)
{
    System.Console.WriteLine("Неверный ввод");
    goto begin;
}

else if (number[0] == number[4] && number[1] == number[3])
{
    System.Console.WriteLine("Это число - палиндром");
}

else
{
    System.Console.WriteLine("Это не палиндром");
}

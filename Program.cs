﻿using System;

class MainClass
{
    public static void Main(string[] args)
    {
        Console.Write("Введите имя: ");
        var name = Console.ReadLine();
        Console.Write("Введите возраст: ");
        var age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Твое имя {0} и возраст {1}", name, age);
        Console.Write("Введите дату рождения: ");
        var birthdate = Console.ReadLine();
        Console.WriteLine("Твоя дата рождения {0}", birthdate);
        Console.ReadKey();
    }
}
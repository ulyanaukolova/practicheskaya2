using System;
using System.Globalization;
using System.Security.Cryptography;
Console.WriteLine("выберите программу, которую вы хотите запустить: \r\n1-Угадай число\r\n2-Таблица умножения\r\n3-Выйти из программы");
Console.WriteLine("введите операцию: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("отгадай число от 1 до 100!");


switch (a)
{
    case 1:
        int b = 1;
        Random rand = new Random();
        int chislo = rand.Next(9);
        int k = Convert.ToInt32(Console.ReadLine());
        while (k != chislo)
        {
            if (k < chislo)
            {
                Console.WriteLine("нужно больше ваше число!");
            }
            else
            {
                Console.WriteLine("нужно меньше ваше число!");
            }

            {
                b++;

                Console.WriteLine("Нет, это не число " + k + "! Попытка № " + b + ":");
                k = Convert.ToInt32(Console.ReadLine());
            }
        }

        if (k == chislo)
        {
            Console.WriteLine("Да! Компьютер загадал число " + k + "!");

        }
        Console.WriteLine();
        break;

    case 2:
        int x = 2;
        Console.WriteLine();



        Console.WriteLine("Выберите программу, которую вы хотите запустить \r\n1- Угадай число\r\n2- Таблица умножения\r\n3- Выйти из программы");
        Console.WriteLine("Введите операцию: ");
        int i;
        int umn;
        for (i = 1; i <= 9; i++)
        {
            Console.WriteLine("\t");
            for (umn = 1; umn <= 9; umn++)
            {
                Console.Write("\t" + i * umn);
            }
        }
        Console.WriteLine();
        break;
}

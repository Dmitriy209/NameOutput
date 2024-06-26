﻿using System;

namespace NameOutput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите символ:");
            char symbol = Console.ReadKey(true).KeyChar;

            Console.WriteLine("Введите имя:");
            string name = Console.ReadLine();

            string lastLines = "";
            string middleLine = $"{symbol}{name}{symbol}";

            for (int i = 0; i < middleLine.Length; i++)
            {
                lastLines += Convert.ToString(symbol);
            }

            Console.WriteLine($"{lastLines}\n" +
                $"{middleLine}\n" +
                $"{lastLines}");
        }
    }
}

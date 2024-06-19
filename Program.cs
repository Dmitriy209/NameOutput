using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameOutput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int symbolsLength = 2;

            Console.WriteLine("Введите символ:");
            char symbol = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Введите имя:");
            string name = Console.ReadLine();

            string lastLines = "";
            string middleLine = Convert.ToString(symbol) + name + Convert.ToString(symbol);
            
            int lineLength = name.Length + symbolsLength;

            for (int i = 0; i < lineLength; i++)
            {
                lastLines += Convert.ToString(symbol);
            }

            Console.WriteLine(lastLines);
            Console.WriteLine(middleLine);
            Console.WriteLine(lastLines);
        }
    }
}

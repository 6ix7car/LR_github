using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа, для сложения двуз чисел."); //добавил
            Console.WriteLine("Введите первое число:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число:");
            int num2 = int.Parse(Console.ReadLine());
            
            //добавил
            Console.WriteLine("Введите операцию (+, -, *, /):");
            string operation = Console.ReadLine();

            switch (operation)
            {
                case "+":
                    Console.WriteLine($"Сумма: {num1 + num2}");
                    break;
                case "-":
                    Console.WriteLine($"Разность: {num1 - num2}");
                    break;
                case "*":
                    Console.WriteLine($"Произведение: {num1 * num2}");
                    break;
                case "/":
                    Console.WriteLine($"Частное: {num1 / num2}");
                    break;
                default:
                    Console.WriteLine("Неизвестная операция");
                    break;
            }
            //

            Console.ReadKey();
        }
    }
}
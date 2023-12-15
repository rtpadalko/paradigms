using System;
using System.Drawing;

namespace QuadraticEquation
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            //TryParse конвертирует значения

            if (args.Length == 3 && double.TryParse(args[0], out a) && double.TryParse(args[1], out b) && double.TryParse(args[2], out c))
            {
                SolveAndPrint(a, b, c);
            }
            else
            {
                Console.Write("Введите A: ");
                while (!double.TryParse(Console.ReadLine(), out a))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Неверный ввод. Попробуйте еще раз.");
                    Console.ResetColor();
                    Console.Write("Введите A: ");
                }

                Console.Write("Введите B: ");
                while (!double.TryParse(Console.ReadLine(), out b))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Неверный ввод. Попробуйте еще раз.");
                    Console.ResetColor();
                    Console.Write("Введите B: ");
                }

                Console.Write("Введите C: ");
                while (!double.TryParse(Console.ReadLine(), out c))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Неверный ввод. Попробуйте еще раз.");
                    Console.ResetColor();
                    Console.Write("Введите C: ");
                }

                SolveAndPrint(a, b, c);
            }
        }

        static void SolveAndPrint(double a, double b, double c)
        {
            double D = b * b - 4 * a * c;

            if (D > 0)
            {
                double x1 = (-b + Math.Sqrt(D)) / (2 * a);
                double x2 = (-b - Math.Sqrt(D)) / (2 * a);

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"x1 = {x1}, x2 = {x2}");
                Console.ResetColor();
            }
            else if (D == 0)
            {
                double x = -b / (2 * a);

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"x = {x}");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Нет корней.");
                Console.ResetColor();
            }
            Console.ReadLine();
        }
    }
}

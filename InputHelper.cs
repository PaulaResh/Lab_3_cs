using System;

namespace LabWork
{
    public static class InputHelper
    {
        public static int ReadInt(
            string prompt = "",
            bool allowNegative = true)
        {
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();

                if (int.TryParse(
                        input, out int result))
                {
                    if (!allowNegative
                        && result < 0)
                    {
                        Console.WriteLine(
                            "Ошибка: " +
                            "неотрицательное.");
                        continue;
                    }
                    return result;
                }
                else
                {
                    Console.WriteLine(
                        "Ошибка: " +
                        "некорректное число.");
                }
            }
        }

        public static double ReadDouble(
            string prompt = "",
            bool allowNegative = true)
        {
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();

                if (double.TryParse(
                        input, out double result))
                {
                    if (!allowNegative
                        && result < 0)
                    {
                        Console.WriteLine(
                            "Ошибка: " +
                            "неотрицательное.");
                        continue;
                    }
                    return result;
                }
                else
                {
                    Console.WriteLine(
                        "Ошибка: " +
                        "некорректное число.");
                }
            }
        }

        public static string ReadString(
            string prompt = "")
        {
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(input))
                {
                    return input;
                }
                else
                {
                    Console.WriteLine(
                        "Ошибка: " +
                        "непустая строка.");
                }
            }
        }
    }
}
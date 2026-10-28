using System;
using System.IO;
using System.Xml.Serialization;

namespace LabWork
{
    [Serializable]
    public struct BaggageItem
    {
        public string Name;
        public double Mass;
    }

    [Serializable]
    public class Passenger
    {
        public BaggageItem[] Items;
    }

    public static class FileOperations
    {
        // Задание 4: Бинарные файлы (четные числа)
        public static void FillBinaryFile(string fileName)
        {
            int count = InputHelper.ReadInt("Количество чисел: ", false);
            Random rnd = new Random();
            using (BinaryWriter writer = new BinaryWriter(File.Open(fileName, FileMode.Create)))
            {
                for (int i = 0; i < count; i++)
                {
                    writer.Write(rnd.Next(-100, 101));
                }
            }
        }

        public static void ExtractEvenNumbers(string inputFile, string outputFile)
        {
            using (BinaryReader reader = new BinaryReader(File.Open(inputFile, FileMode.Open)))
            using (BinaryWriter writer = new BinaryWriter(File.Open(outputFile, FileMode.Create)))
            {
                while (reader.BaseStream.Position < reader.BaseStream.Length)
                {
                    int num = reader.ReadInt32();
                    if (num % 2 == 0)
                    {
                        writer.Write(num);
                    }
                }
            }
        }

        // Задание 5: XML сериализация багажа
        public static void FillBaggageFile(string fileName)
        {
            int passengersCount = InputHelper.ReadInt("Количество пассажиров: ", false);
            Random rnd = new Random();
            string[] names = { "Чемодан", "Сумка", "Коробка", "Рюкзак", "Пакет" };

            Passenger[] pass = new Passenger[passengersCount];
            for (int i = 0; i < passengersCount; i++)
            {
                int itemCount = rnd.Next(2, 5);
                pass[i] = new Passenger();
                pass[i].Items = new BaggageItem[itemCount];
                for (int j = 0; j < itemCount; j++)
                {
                    pass[i].Items[j].Name = names[rnd.Next(names.Length)];
                    pass[i].Items[j].Mass = rnd.Next(1, 21);
                }
            }

            XmlSerializer serializer = new XmlSerializer(typeof(Passenger[]));
            using (FileStream fs = new FileStream(fileName, FileMode.Create))
            {
                serializer.Serialize(fs, pass);
            }
        }

        public static void FindPassengersByAverageMass(string inputFile)
        {
            double m = InputHelper.ReadDouble("Допустимое отклонение m: ", false);
            XmlSerializer serializer = new XmlSerializer(typeof(Passenger[]));
            Passenger[] passengers;

            using (FileStream fs = new FileStream(inputFile, FileMode.Open))
            {
                passengers = (Passenger[])serializer.Deserialize(fs);
            }

            double totalMass = 0;
            int totalItems = 0;
            for (int i = 0; i < passengers.Length; i++)
            {
                for (int j = 0; j < passengers[i].Items.Length; j++)
                {
                    totalMass += passengers[i].Items[j].Mass;
                    totalItems++;
                }
            }
            double globalAverage = totalMass / totalItems;
            Console.WriteLine("Общая средняя масса: " + globalAverage.ToString("F2"));

            for (int i = 0; i < passengers.Length; i++)
            {
                double passengerMass = 0;
                for (int j = 0; j < passengers[i].Items.Length; j++)
                {
                    passengerMass += passengers[i].Items[j].Mass;
                }
                double passengerAverage = passengerMass / passengers[i].Items.Length;
                double diff = passengerAverage - globalAverage;
                if (diff < 0) diff = -diff;

                if (diff <= m)
                {
                    Console.WriteLine("Пассажир со средней массой: " + passengerAverage.ToString("F2"));
                }
            }
        }

        // Задание 6: Текстовый файл (по одному числу в строке)
        public static void FillTextFileSingle(string fileName)
        {
            int count = InputHelper.ReadInt("Количество чисел (четное): ", false);
            if (count % 2 != 0)
            {
                count++;
                Console.WriteLine("Скорректировано до четного: " + count);
            }
            Random rnd = new Random();
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                for (int i = 0; i < count; i++)
                {
                    writer.WriteLine(rnd.Next(-50, 51));
                }
            }
        }

        public static void CalculateDifference(string inputFile)
        {
            string[] lines = File.ReadAllLines(inputFile);
            int count = lines.Length;

            if (count % 2 != 0)
            {
                throw new Exception("Количество элементов нечетно");
            }

            int half = count / 2;
            int sum1 = 0;
            int sum2 = 0;
            for (int i = 0; i < count; i++)
            {
                int number = int.Parse(lines[i]);
                if (i < half)
                {
                    sum1 += number;
                }
                else
                {
                    sum2 += number;
                }
            }
            Console.WriteLine("Разность сумм: " + (sum1 - sum2));
        }

        // Задание 7: Текстовый файл (несколько чисел в строке)
        public static void FillTextFileMultiple(string fileName)
        {
            int rows = InputHelper.ReadInt("Количество строк: ", false);
            int cols = InputHelper.ReadInt("Чисел в строке: ", false);
            Random rnd = new Random();
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                for (int i = 0; i < rows; i++)
                {
                    string line = "";
                    for (int j = 0; j < cols; j++)
                    {
                        line += rnd.Next(-20, 21);
                        if (j < cols - 1)
                        {
                            line += " ";
                        }
                    }
                    writer.WriteLine(line);
                }
            }
        }

        public static void CalculateSum(string inputFile)
        {
            int sum = 0;
            using (StreamReader reader = new StreamReader(inputFile))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(' ');
                    for (int i = 0; i < parts.Length; i++)
                    {
                        if (parts[i] != null && parts[i].Length > 0)
                        {
                            sum += int.Parse(parts[i]);
                        }
                    }
                }
            }
            Console.WriteLine("Сумма элементов: " + sum);
        }

        // Задание 8: Текстовый файл (короткая и длинная строки)
        public static void FillTextFile(string fileName)
        {
            string[] lines = {
                "Короткая строка",
                "Это средняя по длине строка текста",
                "Очень длинная строка, которая содержит много слов и символов для демонстрации",
                "Еще одна короткая",
                "Самая длинная строка в этом файле, которая точно будет выбрана как максимальная"
            };
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                for (int i = 0; i < lines.Length; i++)
                {
                    writer.WriteLine(lines[i]);
                }
            }
        }

        public static void CopyShortestAndLongest(string inputFile, string outputFile)
        {
            string shortest = null;
            string longest = null;

            using (StreamReader reader = new StreamReader(inputFile))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (shortest == null || line.Length < shortest.Length)
                    {
                        shortest = line;
                    }
                    if (longest == null || line.Length > longest.Length)
                    {
                        longest = line;
                    }
                }
            }

            using (StreamWriter writer = new StreamWriter(outputFile))
            {
                writer.WriteLine(shortest);
                writer.WriteLine(longest);
            }

            Console.WriteLine("Самая короткая: " + shortest);
            Console.WriteLine("Самая длинная: " + longest);
        }
    }
}
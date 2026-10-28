using System;
using System.IO;

namespace LabWork
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding =
                System.Text.Encoding.UTF8;

            Console.WriteLine(
                "Задание 1. " +
                "Заполнение массивов");

            Console.WriteLine(
                "\n1. С клавиатуры:");
            int n1 = InputHelper.ReadInt(
                "Строки: ", false);
            int m1 = InputHelper.ReadInt(
                "Столбцы: ", false);
            Matrix matrix1 = new Matrix(
                n1, m1, true);
            Console.WriteLine(
                "\nМатрица 1:\n" + matrix1);

            Console.WriteLine(
                "\n2. По диагоналям:");
            int n2 = InputHelper.ReadInt(
                "Размер n: ", false);
            Matrix matrix2 = new Matrix(
                n2, MatrixFillType.Diagonal);
            Console.WriteLine(
                "\nМатрица 2:\n" + matrix2);

            Console.WriteLine(
                "\n3. Треугольное:");
            int n3 = InputHelper.ReadInt(
                "Размер n: ", false);
            Matrix matrix3 = new Matrix(
                n3, MatrixFillType.Triangle);
            Console.WriteLine(
                "\nМатрица 3:\n" + matrix3);


            Console.WriteLine(
                "\nЗадание 2. " +
                "Макс. уникальный");
            Console.WriteLine(
                "Введите размерность:");
            int rows2 = InputHelper.ReadInt(
                "Строки: ", false);
            int cols2 = InputHelper.ReadInt(
                "Столбцы: ", false);
            double[,] arr2 = new double[
                rows2, cols2];

            Console.WriteLine(
                "Введите элементы:");
            for (int i = 0; i < rows2; i++)
            {
                for (int j = 0; j < cols2; j++)
                {
                    Console.Write(
                        $"[{i},{j}]: ");
                    arr2[i, j] =
                        InputHelper.ReadDouble(
                            "", true);
                }
            }

            try
            {
                double max =
                    Matrix.FindMaxUnique(arr2);
                Console.WriteLine(
                    "\nМаксимальный " +
                    "уникальный: " + max);
            }
            catch (Exception ex)
            {
                Console.WriteLine(
                    "\n" + ex.Message);
            }


            Console.WriteLine(
                "\nЗадание 3. " +
                "Матричное выражение");
            Console.WriteLine(
                "Размерность матриц:");
            int n3_task = InputHelper.ReadInt(
                "Размер n: ", false);

            Console.WriteLine(
                "\nМатрица A:");
            Matrix A = new Matrix(
                n3_task, n3_task, true);
            Console.WriteLine(
                "\nМатрица B:");
            Matrix B = new Matrix(
                n3_task, n3_task, true);
            Console.WriteLine(
                "\nМатрица C:");
            Matrix C = new Matrix(
                n3_task, n3_task, true);

            Matrix result = 2 * A - 3 * B * C;
            Console.WriteLine(
                "\nРезультат 2*A - 3*B*C:");
            Console.WriteLine(result);


            Console.WriteLine(
                "\nЗадание 4. " +
                "Бинарные файлы");
            string binIn = "input.bin";
            string binOut = "output.bin";
            FileOperations.FillBinaryFile(
                binIn);
            Console.WriteLine(
                $"Файл {binIn} заполнен.");

            FileOperations.ExtractEvenNumbers(
                binIn, binOut);
            Console.WriteLine(
                $"Четные в {binOut}");

            Console.WriteLine(
                "\nСодержимое:");
            using (BinaryReader reader =
                new BinaryReader(
                    File.Open(binOut,
                    FileMode.Open)))
            {
                while (reader.BaseStream.Position
                       < reader.BaseStream.Length)
                {
                    Console.Write(
                        reader.ReadInt32() + " ");
                }
            }
            Console.WriteLine();


            Console.WriteLine(
                "\nЗадание 5. Багаж");
            string xmlFile = "baggage.xml";
            FileOperations.FillBaggageFile(
                xmlFile);
            Console.WriteLine(
                $"Файл {xmlFile} заполнен.");

            FileOperations
                .FindPassengersByAverageMass(
                    xmlFile);


            Console.WriteLine(
                "\nЗадание 6. " +
                "Текстовый файл");
            string txt1 = "nums1.txt";
            FileOperations.FillTextFileSingle(
                txt1);
            Console.WriteLine(
                $"Файл {txt1} заполнен.");

            FileOperations.CalculateDifference(
                txt1);


            Console.WriteLine(
                "\nЗадание 7. " +
                "Несколько чисел");
            string txt2 = "nums2.txt";
            FileOperations.FillTextFileMultiple(
                txt2);
            Console.WriteLine(
                $"Файл {txt2} заполнен.");

            FileOperations.CalculateSum(txt2);


            Console.WriteLine(
                "\nЗадание 8. " +
                "Короткая и длинная");
            string txt3 = "text.txt";
            string txt4 = "result.txt";
            FileOperations.FillTextFile(txt3);
            Console.WriteLine(
                $"Файл {txt3} заполнен.");

            FileOperations
                .CopyShortestAndLongest(
                    txt3, txt4);
            Console.WriteLine(
                $"\nРезультат в {txt4}");


            Console.WriteLine(
                "\nНажмите любую клавишу");
            Console.ReadKey();
        }
    }
}
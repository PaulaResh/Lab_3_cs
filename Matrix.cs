using System;

namespace LabWork
{
    public enum MatrixFillType
    {
        Diagonal,
        Triangle
    }

    public class Matrix
    {
        private double[,] _data;

        public Matrix(int rows, int cols)
        {
            _data = new double[rows, cols];
        }

        public Matrix(int rows, int cols,
                      bool fromKeyboard)
        {
            _data = new double[rows, cols];
            FillFromKeyboard();
        }

        public Matrix(int n, MatrixFillType fillType)
        {
            _data = new double[n, n];
            if (fillType == MatrixFillType.Diagonal)
            {
                FillDiagonal();
            }
            else
            {
                FillTriangle();
            }
        }

        private void FillFromKeyboard()
        {
            int rows = _data.GetLength(0);
            int cols = _data.GetLength(1);
            Console.WriteLine(
                "Заполнение по строкам " +
                "от последних к первым:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = cols - 1; j >= 0; j--)
                {
                    Console.Write($"[{i},{j}]: ");
                    _data[i, j] =
                        InputHelper.ReadDouble();
                }
            }
        }

        private void FillDiagonal()
        {
            int n = _data.GetLength(0);
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i > j)
                    {
                        _data[i, j] =
                            rnd.Next(-17, 37);
                    }
                    else
                    {
                        _data[i, j] =
                            rnd.Next(100, 10001);
                    }
                }
            }
        }

        private void FillTriangle()
        {
            int n = _data.GetLength(0);
            int num = 1;
            for (int i = n - 1; i >= 0; i--)
            {
                for (int j = 0;
                     j <= n - 1 - i; j++)
                {
                    _data[i, j] = num++;
                }
            }
        }

        public static Matrix operator *(
            Matrix a, Matrix b)
        {
            int rowsA = a._data.GetLength(0);
            int colsA = a._data.GetLength(1);
            int colsB = b._data.GetLength(1);

            if (colsA != b._data.GetLength(0))
            {
                throw new Exception(
                    "Нельзя умножить матрицы");
            }

            Matrix result =
                new Matrix(rowsA, colsB);
            for (int i = 0; i < rowsA; i++)
            {
                for (int j = 0; j < colsB; j++)
                {
                    double sum = 0;
                    for (int k = 0; k < colsA; k++)
                    {
                        sum += a._data[i, k] *
                               b._data[k, j];
                    }
                    result._data[i, j] = sum;
                }
            }
            return result;
        }

        public static Matrix operator *(
            double scalar, Matrix matrix)
        {
            int rows = matrix._data.GetLength(0);
            int cols = matrix._data.GetLength(1);
            Matrix result =
                new Matrix(rows, cols);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result._data[i, j] =
                        scalar * matrix._data[i, j];
                }
            }
            return result;
        }

        public static Matrix operator -(
            Matrix a, Matrix b)
        {
            int rows = a._data.GetLength(0);
            int cols = a._data.GetLength(1);
            if (rows != b._data.GetLength(0) ||
                cols != b._data.GetLength(1))
            {
                throw new Exception(
                    "Нельзя вычесть матрицы");
            }
            Matrix result =
                new Matrix(rows, cols);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result._data[i, j] =
                        a._data[i, j] -
                        b._data[i, j];
                }
            }
            return result;
        }

        public override string ToString()
        {
            int rows = _data.GetLength(0);
            int cols = _data.GetLength(1);
            string result = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result += _data[i, j]
                        .ToString().PadLeft(8);
                }
                result += "\n";
            }
            return result;
        }

        public static double FindMaxUnique(
            double[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            double maxUnique = double.MinValue;
            bool found = false;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    double current = matrix[i, j];
                    int count = 0;

                    for (int r = 0; r < rows; r++)
                    {
                        for (int c = 0; c < cols; c++)
                        {
                            if (matrix[r, c] == current)
                            {
                                count++;
                            }
                        }
                    }

                    if (count == 1 &&
                        current > maxUnique)
                    {
                        maxUnique = current;
                        found = true;
                    }
                }
            }

            if (!found)
            {
                throw new Exception(
                    "Нет уникальных элементов");
            }

            return maxUnique;
        }
    }
}

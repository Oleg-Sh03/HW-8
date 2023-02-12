// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18



int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
int[,] matrix = new int[rows, columns]; // 0, 1
Random rnd = new Random();

for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
matrix[i, j] = rnd.Next(min, max + 1);
}
}
return matrix;
}
void PrintMatrix(int[,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
Console.Write("|");
for (int j = 0; j < matrix.GetLength(1); j++)
{
if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 4} | ");
else Console.Write($"{matrix[i, j], 4} ");
}
Console.WriteLine("|");
}
}

int[,] array2D = CreateMatrixRndInt(2, 2, -10, 10);
PrintMatrix(array2D);
Console.WriteLine();
int[,] array2DD = CreateMatrixRndInt(2, 2, -10, 10);
PrintMatrix(array2DD);
Console.WriteLine();
int[,] array2DDD = MatrixMultiplication(array2D, array2DD);
PrintMatrix(array2DDD);


//  bool СheckingСondition(int[,]M1, int[,]M2)
// {
// return M1.GetLength(1) == M2.GetLength(0);
// }
// // bool res = СheckingСondition(array2D, array2DD);
// int[,] array2DDD;
// bool res = СheckingСondition(array2D, array2DD);
// if (res) 
// {
//   array2DDD = MatrixMultiplication(array2D, array2DD);
// }
//  else Console.Write("Умножение невозможно");


int[,] MatrixMultiplication(int[,] A, int[,] B)
    {
       {
            int temp = 0;
            int[,] multi = new int[A.GetLength(0), B.GetLength(1)];
            for (int i = 0; i < A.GetLength(0); i++)
       {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    temp = 0;
                    for (int k = 0; k < A.GetLength(0); k++)
                    {
                        temp += A[i, k] * B[k, j];
                    }
                multi[i, j] = temp;
                }
            }
            return multi;
        }
    }
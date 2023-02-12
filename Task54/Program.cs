// Задача 54: Задайте двумерный matrix. Напишите программу, которая упорядочит по убыванию элементы 
// каждой строки двумерного массива.
// Например, задан matrix:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой matrix:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2



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
int[,] array2D = CreateMatrixRndInt(3, 3, -10, 10);
PrintMatrix(array2D);
Console.WriteLine();


int[,] SortLine(int[,] matrixx)
{
    for (int i = 0; i < matrixx.GetLength(0); i++)
    {
        for (int j = 0; j < matrixx.GetLength(1); j++)
        {
            for (int k = 0; k < matrixx.GetLength(1) - 1; k++)
            {
                if (matrixx[i, k] < matrixx[i, k + 1])
                {
                    int temp = matrixx[i, k + 1];
                    matrixx[i, k + 1] = matrixx[i, k];
                    matrixx[i, k] = temp;
                }
            }
        }
    }
    return matrixx;
}
int[,] sortLine = SortLine(array2D);
PrintMatrix(sortLine);

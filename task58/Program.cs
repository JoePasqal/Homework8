// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 6 16
// // 9 6
int[,] array1 = 
{
{ 5, 1, 2, 2 },
{ 1, 4, 8, 9 },
{ 2, 5, 9, 9 },
{ 5, 9, 8, 6 }
};

int[,] array2 = 
{
{ 2, 1, 2, 2 },
 { 2, 3, 2, 2 },
{ 2, 2, 2, 2 },
{ 2, 2, 1, 6 }
};

if (array1.GetLength(1) != array2.GetLength(0))
    {
    Console.WriteLine("Операция умножения двух матриц выполнима только в том случае, если число столбцов в первом сомножителе равно числу строк во втором; в этом случае говорят, что матрицы согласованы.");
    return;
    }

        
 int[,] umnozh(int[,] array1, int[,] array2)
{
    int row1 = array1.GetLength(0);
    int column1 = array1.GetLength(1);
    int row2 = array2.GetLength(0);
    int column2 = array2.GetLength(1);

    int[,] result = new int[row1, column2];

    for (int i = 0; i < row1; i++)
    {
    for (int j = 0; j < column2; j++)
        {
    for (int k = 0; k < column1; k++)
            {
                result[i, j] += array1[i, k] * array2[k, j];
            }
        }
    }
        return result;
    }

void PrintMatrix(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
            Console.WriteLine();
        }
    }
int[,] result = umnozh(array1, array2);

 PrintMatrix(result);
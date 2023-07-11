// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] array = 
{
{ 5, 4, 7, 2, 6 },
{ 5, 8, 2, 4, 4 },
{ 8, 4, 1, 4, 8 }
};

int rows = array.GetLength(0);
int columns = array.GetLength(1);

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns - 1; j++)
    {
        for (int k = 0; k < columns - 1 - j; k++)
        {
            if (array[i, k] < array[i, k + 1])
            {
                int temp = array[i, k];
                array[i, k] = array[i, k + 1];
                array[i, k + 1] = temp;
            }
        }
    }
}
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}
// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] array = 
{
{ 5, 1, 2, 2 },
{ 1, 4, 8, 9 },
{ 2, 5, 9, 9 },
{ 5, 9, 8, 6 }
};

int rows = array.GetLength(0);
int columns = array.GetLength(1);

int[] sums = new int[rows];

for(int i = 0; i < rows; i++)
{
    int sum = 0;
    for (int j = 0; j < columns; j++)
    {
        sum += array[i, j];
    }
    sums[i] = sum;
}
int FindMinSumIndex(int[] sums)
{
    int minIndex = 0;
    for (int i = 1; i < sums.Length; i++)
    {
        if (sums[i] < sums[minIndex])
        {
            minIndex = i;
        }
    }
    return minIndex;
}

int minSumIndex = FindMinSumIndex(sums);
Console.WriteLine("Наименьшая сумма элементов в строке: " + (minSumIndex + 1));
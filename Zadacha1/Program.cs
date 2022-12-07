// Задайте двумерный массив размером m*n, заполненный случайными вещественными числами.

int n = 4;
int m = 3;
double[,] numbers = new double[m, n];

FillMatrixRandomNumbers(numbers);
WriteMatrix(numbers);

void FillMatrixRandomNumbers(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-10,10) + Math.Round(new Random().NextDouble(), 2);
        }
    }
}

void WriteMatrix(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
    Console.WriteLine();
    }
}
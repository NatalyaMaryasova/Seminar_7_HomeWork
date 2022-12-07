// Задайте двумерный массив из целых чисел
// Найдите среднее арифметическое в каждом столбце

int m = ReadInt("Введите количество строк массива: ");
int n = ReadInt("Введите количество столбцов массива: ");
int[,] numbers = new int[m, n];

FillMatrixRandomNumbers(numbers);
WriteMatrix(numbers);
Console.WriteLine();

double sum = 0;

for (int i = 0; i < numbers.GetLength(1); i++)
{
    for (int j = 0; j < numbers.GetLength(0); j++)
    {
        sum +=  numbers[j, i];
    }
    double srAr = sum/m;
    Console.WriteLine(Math.Round((srAr), 2));
    sum = 0;
}


void FillMatrixRandomNumbers(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1,10);
        }
    }
}

void WriteMatrix(int[,] array)
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

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
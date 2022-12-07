// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или указание, что такого элемента нет.

int m = ReadInt("Введите количество строк массива: ");
int n = ReadInt("Введите количество столбцов массива: ");
int[,] numbers = new int[m, n];

FillMatrixRandomNumbers(numbers);
WriteMatrix(numbers);

Console.WriteLine("Введите позиции элемента массива через пробел: ");
int[] position = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

int a = position[0];
int b = position[1];

if (a >= m || b >= n)
{
    Console.WriteLine("Такого элемента в массиве нет");
}
else 
{
   Console.WriteLine("Элемент массива имеет значение: " + " " + numbers[a, b]);
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

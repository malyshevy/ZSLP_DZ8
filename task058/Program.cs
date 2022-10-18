// Задача 58: Задайте две матрицы. 
//Напишите программу, которая будет находить произведение двух матриц.

Console.Clear();
int[,] numersArrayFirst = UserEnterNumersConsol(0);
Console.Write("Матрица 1 : ");
OutputArrayConsol(numersArrayFirst);
int[,] numersArraySecond = UserEnterNumersConsol(numersArrayFirst.GetLength(1));
Console.Write("Матрица 2 : ");
OutputArrayConsol(numersArraySecond);
Console.WriteLine("Результат умножения матриц : ");
OutputArrayConsol(ResultMultiplyArrays(numersArrayFirst, numersArraySecond));

int[,] UserEnterNumersConsol(int sizeString)
{
    if (sizeString == 0)
    {
        Console.Write("Введите количество строк матрицы 1: ");
        int siseString = int.Parse(Console.ReadLine());
        Console.Write("Введите количество столбцов матрицы 1: ");
        int siseColumn = int.Parse(Console.ReadLine());
        int[,] enterNumersArray = new int[siseString, siseColumn];
        for (int i = 0; i < siseString; i++)
        {
            for (int j = 0; j < siseColumn; j++)
            {
                enterNumersArray[i, j] = new Random().Next(1, 5);
            }
        }
        Console.WriteLine();
        return (enterNumersArray);
    }
    else
    {
        Console.WriteLine($"Kоличество строк матрицы 2: {sizeString}");
        int siseString = sizeString;
        Console.Write("Введите количество столбцов матрицы 2: ");
        int siseColumn = int.Parse(Console.ReadLine());
        int[,] enterNumersArray = new int[siseString, siseColumn];
        for (int i = 0; i < siseString; i++)
        {
            for (int j = 0; j < siseColumn; j++)
            {
                enterNumersArray[i, j] = new Random().Next(1, 5);
            }
        }
        Console.WriteLine();
        return (enterNumersArray);
    }

}

void OutputArrayConsol(int[,] numerArray)
{
    Console.WriteLine();
    for (int i = 0; i <= numerArray.GetUpperBound(0); i++)
    {
        for (int j = 0; j <= numerArray.GetUpperBound(1); j++)
        {
            Console.Write($"{numerArray[i, j]}, ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


int[,] ResultMultiplyArrays(int[,] numerMatrixFirst, int[,] numerMatrixSecond)
{
    int[,] multiplyMatrix = new int[numerMatrixFirst.GetLength(0), numerMatrixSecond.GetLength(1)];
    for (int i = 0; i < numerMatrixFirst.GetLength(0); i++)
    {
        for (int j = 0; j < numerMatrixSecond.GetLength(1); j++)
        {
            for (int y = 0; y < numerMatrixSecond.GetLength(0); y++)
            {
                multiplyMatrix[i, j] += (numerMatrixFirst[i, y] * numerMatrixSecond[y, j]);
            }
        }
    }
    return (multiplyMatrix);
}
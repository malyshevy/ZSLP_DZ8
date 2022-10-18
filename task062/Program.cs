// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

Console.Clear();
int size = 4;
ResultOutputConsol(EnterArray(size));

int[,] EnterArray(int size)
{
    int[,] numArray = new int[size, size];
    for (int i = 0, j = 0, num = 1; num <= size * size; num++)
    {
        numArray[i, j] = num;
        if (i <= j + 1 && i + j < size - 1)
        {
            j++;
        }
        else if (i < j && i + j >= size - 1)
        {
            i++;
        }
        else if (i >= j && i + j > size - 1)
        {
            j--;
        }
        else
        {
            i--;
        }
    }
    return (numArray);
}

void ResultOutputConsol(int[,] numerArray)
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

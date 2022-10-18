// Задача 54: Задайте двумерный массив. 
//Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

Console.Clear();
int[,] numersArray = UserEnterNumersConsol();
Console.Write("Массив без сортировки :");
OutputArrayConsol(numersArray);
numersArray = ResultOutputSortingArray(numersArray);
Console.Write("Массив сортированный по убыванию :");
OutputArrayConsol(numersArray);

int[,] UserEnterNumersConsol()
{
    Console.Write("Введите количество строк массива ");
    int siseString = int.Parse(Console.ReadLine());
    Console.Write("Введите количество столбцов массива ");
    int siseColumn = int.Parse(Console.ReadLine());
    int[,] enterNumersArray = new int[siseString, siseColumn];
    for (int i = 0; i < siseString; i++)
    {
        for (int j = 0; j < siseColumn; j++)
        {
            enterNumersArray[i, j] = new Random().Next(-99, 100);
        }
    }
    Console.WriteLine();
    return (enterNumersArray);
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


int[,] ResultOutputSortingArray(int[,] numerArray)
{
    for (int i = 0; i <= numerArray.GetUpperBound(0); i++)
    {
        for (int j = 0, max; j <= numerArray.GetUpperBound(1); j++)
        {
            for (int k = j; k <= numerArray.GetUpperBound(1); k++)
            {
                max = numerArray[i, j];
                if ((max != numerArray[i, k]) && (max < numerArray[i,k]))
                {
                    numerArray[i, j] = numerArray[i, k];
                    numerArray[i, k] = max;
                }
            }
        }
    }
    return (numerArray);
}
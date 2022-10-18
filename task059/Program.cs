// Задача 59: Из двумерного массива целых чисел 
//удалить строку и столбец, на пересечении которых расположен наименьший элемент.

Console.Clear();
int[,] numersArray = UserEnterNumersConsol();
Console.Write("Массив :");
OutputArrayConsol(numersArray);
numersArray = DeleteNumersArray(numersArray);
Console.Write("Массив после удаления данных :");
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


int[,] DeleteNumersArray(int[,] numerArray)
{
    int indexI = 0, indexJ = 0, min = numerArray[0, 0];
    for (int i = 0; i <= numerArray.GetUpperBound(0); i++)
    {
        for (int j = 0; j <= numerArray.GetUpperBound(1); j++)
        {
            for (int y = j; y <= numerArray.GetUpperBound(1); y++)
            {
                if ((min != numerArray[i, y]) && (min > numerArray[i, y]))
                {
                    min = numerArray[i, y];
                    indexI = i;
                    indexJ = y;
                }
            }
        }
    }
    Console.WriteLine($"Номер минимального значения в массиве ({indexI+1},{indexJ+1}). Значение = {min} .");
    int[,] deleteArray = new int[numerArray.GetUpperBound(0), numerArray.GetUpperBound(1)];
    for (int i = 0, k = 0; i <= numerArray.GetUpperBound(0); i++, k++)
    {
        if (indexI != i)
        {
            for (int j = 0, y = 0; j <= numerArray.GetUpperBound(1); j++, y++)
            {
                if (indexJ != j)
                {
                    deleteArray[k, y] = numerArray[i, j];
                }
                else
                {
                    y -= 1;
                }
            }
        }
        else
        {
            k-=1;
        }
    }
    return (deleteArray);
}

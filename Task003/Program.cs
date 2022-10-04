// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Метод заполнения двумерного массива рандомными числами
int[,] GetArray(int[,] array)
{
    Console.WriteLine("Массив:");
     for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
    return array;
}

// Метод для вывода двумерного массива на экран
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j]);;
        }
        Console.WriteLine();
    }  
}

// Метод нахождения среднего арифметического элементов в каждом столбце

void GetFindAverageInColumn(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++) // j  номер столбца
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++) // i номер строки
        {
            sum = sum + array[i, j];
        }
        double average = Math.Round(sum/array.GetLength(0), 2);
        Console.WriteLine($"Среднее арифметическое столбца {j} = {average}");
    }
}

int[,] myArray = new int[3, 3];
int[,] randomArray = GetArray(myArray);
PrintArray(randomArray);
GetFindAverageInColumn(randomArray);
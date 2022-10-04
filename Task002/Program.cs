// Напишите программу, которая на вход принимает позиции элемента в двумерном
// массиве, и возвращает значение этого элемента или же указание, что такого
// элемента нет.

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

// Определяем входные данные и их корректность
Console.Write("Введите индекс строки элемента(indexN): ");
int indexN = 0;
bool parseNIsOk = int.TryParse(Console.ReadLine(), out int numberN);
if (parseNIsOk)
{
    indexN = numberN;
}
else
{
    Console.WriteLine("Введено значение некоректного формата");
    return;
}

Console.Write("Введите индекс столбца элемента(indexM): ");
int indexM = 0;
bool parseMIsOk = int.TryParse(Console.ReadLine(), out int numberM);
if (parseMIsOk)
{
    indexM = numberM; 
}
else
{
    Console.WriteLine("Введено значение некоректного формата");
    return;
}

int[,] myArray = new int[5, 5];
int[,] randomArray = GetArray(myArray);
PrintArray(randomArray);

if (indexN < randomArray.GetLength(0) && indexM < randomArray.GetLength(0))
    {
        Console.WriteLine($"Значение элемента = {myArray[indexN, indexM]}");
    }
    else
    {
        Console.WriteLine($"[{indexN},{indexM}]- такого значения в массиве нет");
    }



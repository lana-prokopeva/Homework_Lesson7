// Задайте двумерный массив размером m×n, заполненный случайными вещественными 
// числами.

// Метод заполнения двумерного массива вещественными числами
double[,] GetDoubleNumbersArray(int line, int column)
{
    double [,] newArray = new double[line, column];
    for (int i = 0; i < line; i++)
    {
        for (int j = 0; j < column; j++)
        {
            newArray[i, j] = Convert.ToDouble(new Random().Next(-99, 100))/10;
        }
    }
    return newArray;
}

// Метод для вывода двумерного массива на экран
void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");;
        }
        Console.WriteLine();
    }  
}


// Определяем входные данные и их корректность
Console.Write("Введите количество строк(N): ");
int n = 0;
bool parseNIsOk = int.TryParse(Console.ReadLine(), out int numberN);
if (parseNIsOk)
{
    n = numberN;
}
else
{
    Console.WriteLine("Введено значение некоректного формата");
    return;
}

Console.Write("Введите количество столбцов(M): ");
int m = 0;
bool parseMIsOk = int.TryParse(Console.ReadLine(), out int numberM);
if (parseMIsOk)
{
    m = numberM; 
}
else
{
    Console.WriteLine("Введено значение некоректного формата");
    return;
}

double[,] DoubleNumbersArray = GetDoubleNumbersArray(m, n);
PrintArray(DoubleNumbersArray);



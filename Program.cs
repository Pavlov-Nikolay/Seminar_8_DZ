// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.WriteLine("Задача 54");
Console.WriteLine();

int[,] array = CreateArray(4, 5); // создаем двумерный массив 

SortArray(array); // сортируем двумерный массивж

int[,] CreateArray(int i, int j)
{
    int[,] array = new int[i, j];

    Random digit = new Random();

    for (i = 0; i < array.GetLength(0); i++) // заполняем массив случайными числами
    {
        for (j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = digit.Next(0, 10);
        }
    }

    for (i = 0; i < array.GetLength(0); i++) // распечатываем массив
    {
        for (j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }

    Console.WriteLine();

    return array;
}

void SortArray(int[,] array)
{
    int[,] sortArray = (int[,])array.Clone(); // создали новый массив для сортировки;

    for (int i = 0; i <= sortArray.GetLength(0); i++) // задаем кол-во проходов сортировки массива по строкам;
    {
        for (int j = 0; j < sortArray.GetLength(1) - 1; j++) // задаем кол-во проходов сортировки массива по столбцам;
        {
            for (int c = 0; c < sortArray.GetLength(0); c++) // задаем кол-во проходов сортировки строки массива по элементам;
            {
                if (sortArray[c, j] < sortArray[c, j + 1])
                {
                    int prom = sortArray[c, j];
                    sortArray[c, j] = sortArray[c, j + 1];
                    sortArray[c, j + 1] = prom;
                }
            }
        }
    }

    for (int i = 0; i < sortArray.GetLength(0); i++) // распечатываем массив
    {
        for (int j = 0; j < sortArray.GetLength(1); j++)
        {
            Console.Write($"{sortArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine();
Console.WriteLine();

//___________________________________________________________________________________________________________

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.WriteLine("Задача 56");
Console.WriteLine();

int[,] arr = CreateArr(3, 3); // создаем двумерный массив 

int[,] CreateArr(int i, int j) // метод для создания двумерного массива
{
    int[,] arr = new int[i, j];

    Random digit = new Random();

    for (i = 0; i < arr.GetLength(0); i++) // заполняем массив случайными числами
    {
        for (j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = digit.Next(0, 10);
        }
    }

    for (i = 0; i < arr.GetLength(0); i++) // распечатываем массив
    {
        for (j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }

    Console.WriteLine();

    return arr;
}


SumOfString(arr); // вызываем метод для получения суммы элементов в одной строке

int SumOfString(int[,] arr) // метод для получения суммы элементов в одной строке и записи их в новый массив
{
    int sumOfString = 0;
    int[] resultingArray = new int[arr.GetLength(0)];

    for (int i = 0; i < arr.GetLength(0); i++)
    {

        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sumOfString = sumOfString + arr[i, j];
        }

        resultingArray[i] = sumOfString;

        System.Console.WriteLine($"сумма элементов {i + 1}-й строки равна {sumOfString}");
        sumOfString = 0;
    }

    System.Console.WriteLine();
    int min = resultingArray.Min();
    int indexOfMin = Array.IndexOf(resultingArray, min);
    System.Console.WriteLine($"Номер строки с наименьшей суммой элементов: {indexOfMin + 1}");

    return sumOfString;

}
System.Console.WriteLine();

//________________________________________________________________________________________________________________

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.WriteLine("Задача 58");
Console.WriteLine();

System.Console.WriteLine("Введите размер матрицы А");
int a = int.Parse(Console.ReadLine()); // кол-во строк матрицы А
int b = int.Parse(Console.ReadLine()); // кол-во столбцов матрицы А

System.Console.WriteLine("Введите размер матрицы B");
int c = int.Parse(Console.ReadLine()); // кол-во строк матрицы В
int d = int.Parse(Console.ReadLine()); // кол-во столбцов матрицы В

if (b != c)
{
    System.Console.WriteLine("Для умножения матриц необходимо, что бы число строк матрица А было равно числу столбцов матрицы В. Попробуйте ещё раз");
    return;
}

else
{
    System.Console.WriteLine($"Кол-во строк матрицы А - {a}");
    System.Console.WriteLine($"Кол-во столбцов матрицы А - {b}");
    System.Console.WriteLine($"Кол-во строк матрицы В - {c}");
    System.Console.WriteLine($"Кол-во столбцов матрицы В - {d}");
}

System.Console.WriteLine();

int[,] matrixA = CreateMatrix(a, b); // создаем двумерный массив 

int[,] matrixB = CreateMatrix(c, d); // создаем двумерный массив 

int[,] CreateMatrix(int i, int j) // метод для создания двумерного массива
{
    int[,] arr = new int[i, j];

    Random digit = new Random();

    for (i = 0; i < arr.GetLength(0); i++) // заполняем массив случайными числами
    {
        for (j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = digit.Next(1, 6);
        }
    }

    return arr;
}


System.Console.WriteLine("Матрица А");

for (int i = 0; i < matrixA.GetLength(0); i++) // распечатываем массив А
{
    for (int j = 0; j < matrixA.GetLength(1); j++)
    {
        System.Console.Write($"{matrixA[i, j]} ");
    }
    System.Console.WriteLine();
}

System.Console.WriteLine();
System.Console.WriteLine("Матрица В");

for (int i = 0; i < matrixB.GetLength(0); i++) // распечатываем массив В
{
    for (int j = 0; j < matrixB.GetLength(1); j++)
    {
        System.Console.Write($"{matrixB[i, j]} ");
    }
    System.Console.WriteLine();
}

int[,] matrixC = new int[matrixA.GetLength(0), matrixB.GetLength(1)];

System.Console.WriteLine();

matrixC = Multu(matrixA, matrixB, matrixC); // заполнение матрицы С с помощью функции умножения матриц

int[,] Multu(int[,] matrixA, int[,] matrixB, int[,] matrixC) // функция умножения матрицы А на матрицу В
{
    for (int i = 0; i < matrixA.GetLength(0); i++)
    {
        for (int j = 0; j < matrixB.GetLength(1); j++)
        {
            for (int l = 0; l < matrixA.GetLength(1); l++)
            {
                int prom = matrixA[i, l] * matrixB[l, j];
                matrixC[i, j] = matrixC[i, j] + prom;
            }
        }
    }

    return matrixC;
}



System.Console.WriteLine();

for (int i = 0; i < matrixC.GetLength(0); i++)
{
    for (int j = 0; j < matrixC.GetLength(1); j++)
    {
        System.Console.Write($"{matrixC[i, j]} ");
    }
    System.Console.WriteLine();
}





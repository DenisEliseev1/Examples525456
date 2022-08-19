//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
void Zadacha54 ()
{
    Random random = new Random();
    int rows = random.Next(2, 5);
    int coloms = random.Next(4, 10);
    int[,] array = new int[rows, coloms];
    FillArray (array);
    PrintArray (array);
    Console.WriteLine();
    SortArrayRows (array);
    PrintArray (array);
}


//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов.
void Zadacha56 ()
{
    Random random = new Random();
    int rows = random.Next(4, 10);
    int coloms = random.Next(4, 10);
    int[,] array = new int[rows, coloms];
    FillArray (array);
    PrintArray (array);
    Console.WriteLine("Сумма строк элементов: ");
    int [] sumRowsArray = new int [rows];
    int min = 0;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < coloms; j++)
        {
            sumRowsArray[i] += array [i,j];
        }
        Console.WriteLine($"{i+1} строка - {sumRowsArray[i]}");
        if ((i > 0) && (sumRowsArray[i] < sumRowsArray[min])) 
        {
            min = i;
        } 
    }
    Console.WriteLine ($"Строка с минимальным суммой элементов - {min+1}");
}

//Задача 58. Заполните спирально массив 4 на 4.
void Zadacha58()
{   
    Random random = new Random();
    int rows = random.Next(4, 13);
    int coloms = random.Next(4, 13);
    int[,] array = new int[rows, coloms];
    int count = 1;
    int startOne = 0;
    int finishOne = coloms - 1;
    int startTwo = 1;
    int finishTwo = rows - 1;
    int startThree = coloms - 2;
    int finishThree = 0;
    int startFour = rows - 2;
    int finishFour = 1;
    int weight = coloms * rows;
    while (count < weight)
    {    
        for (int i = startOne; i <= finishOne; i++)
            {
                if (weight < count) break;
                array [(finishFour-1), i] = count;
                count++;
            }
        for (int i = startTwo; i <= finishTwo; i++)
            {
                if (weight < count) break;
                array [i, finishOne] = count;
                count++;                
            }
        for (int i = startThree; i >= finishThree; i--)
            {
                if (weight < count) break;
                array [finishTwo, i] = count;
                count++;  
            }
        for (int i = startFour; i >= finishFour; i--)
            {
                if (weight < count) break;
                array [i, finishThree] = count;
                count++;
            }
        finishOne --;
        startOne ++;
        finishTwo --;
        startTwo ++;
        finishThree ++;
        startThree --;
        finishFour ++;
        startFour --;
    }

    Console.WriteLine ($"Спираль в массиве размерностью {rows}x{coloms}:");
    PrintArray (array);
}

void FillArray(int[,] array, int startNumber = -9, int finishNumber = 9)
{
    int rows = array.GetLength(0);
    int coloms = array.GetLength(1);
    Random random = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < coloms; j++)
        {
            array[i, j] = random.Next(startNumber, finishNumber);
        }
    }
}

void PrintArray(int[,] array)
{
    int rows = array.GetLength(0);
    int coloms = array.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < coloms; j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void SortArrayRows (int [,] array)
{
    int temp = 0;
    int rows = array.GetLength(0);
    int coloms = array.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < coloms; j++)
        {
            for (int k = j; k < coloms; k++)
            {
                if (array [i, j] > array [i, k])
                {
                    temp = array [i, j];
                    array [i, j] = array [i, k];
                    array [i, k] = temp;                
                }
            }
        }
    }
}

//Zadacha54();
Zadacha56();
//Zadacha58();
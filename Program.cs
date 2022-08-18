//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
void Zadacha54 ()
{

}


//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
void Zadacha56 ()
{

}

//Задача 58. Заполните спирально массив 4 на 4.
void Zadacha58()
{   
    Random random = new Random();
    int rows = random.Next(4, 10);
    int coloms = random.Next(4, 10);
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
    int fixNumber = 0;
    int weight = coloms * rows;
    while (count < weight)
    {    
        for (int i = startOne; i <= finishOne; i++)
            {
                if (weight < count) break;
                array [fixNumber, i] = count;
                count++;
            }
        fixNumber = finishOne;
        for (int i = startTwo; i <= finishTwo; i++)
            {
                if (weight < count) break;
                array [i, fixNumber] = count;
                count++;                
            }
        fixNumber = finishTwo;
        for (int i = startThree; i >= finishThree; i--)
            {
                if (weight < count) break;
                array [fixNumber, i] = count;
                count++;  
            }
        fixNumber = finishThree;
        for (int i = startFour; i >= finishFour; i--)
            {
                if (weight < count) break;
                array [i, fixNumber] = count;
                count++;
            }
        fixNumber = finishFour;
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



Zadacha58();
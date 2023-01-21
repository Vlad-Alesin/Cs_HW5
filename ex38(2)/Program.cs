/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76 */

// метод, который считывает с консоли (для размерности массива + границы случ. чисел)
int GetNumber(string message)
{
    int result = 0;

    while(true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число");
        }
    }

    return result;
}

//метод для инициализации массива рандомными числами
float[] InitArray(int dimension, int leftBound, int rightBound)
{
    float[] result = new float[dimension];
    Random rnd = new Random();

    for (int i = 0; i < dimension; i++)
    {
        result[i] = rnd.Next(leftBound, rightBound);
    }
    return result;
}

//метод для печати массива
void PrintArray(float [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

// поиск min max
float MinMax (float[] array)
{
    float Min = array[0];
    float Max = array[0];
    float result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]<Min)
            Min = array[i];
    }
    
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]>Max)
            Max = array[i];
    }
    result = Max - Min;
    Console.WriteLine(result);
    return result;
}


int dimensin = GetNumber("Введите размерность массива");
int leftBound = GetNumber("Введите левую границу значений");
int rightBound = GetNumber("Введите правую границу значений");

float[] arr = InitArray(dimensin, leftBound, rightBound);

PrintArray(arr);

float rez = MinMax(arr);

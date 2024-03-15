int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (1 == array.Length -1)
        {
            Console.Write($"{array[i]}");
        }
        else
        {
            Console.Write($"{array[i]}, ");
        }
    }
    Console.Write("]");
}

void PrintReverseArray (int[] array, int count)
{
    if (count == 0) return;
    {
        Console.Write($"{array[count - 1]} ");
        PrintReverseArray(array, count - 1);
    }
}

int minimum = 1;
int maximum = 100;

Console.WriteLine("Введите размер массива: ");
int count = Convert.ToInt32(Console.ReadLine());

int[] arrayMain = CreateArrayRndInt(count, minimum, maximum);
PrintArray(arrayMain);
Console.Write(" => ");
PrintReverseArray(arrayMain, arrayMain.Length);
Console.WriteLine();

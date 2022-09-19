System.Console.Write("Введите количество элементов массива (целое положительное число): ");
int size = Convert.ToInt32(Console.ReadLine());

string[] CreateArray(int size)
{
    string[] array = new string[size];

    for (int i = 0; i < size; i++)
    {
        System.Console.Write($"Строка № {i + 1}: ");
        array[i] = Console.ReadLine();
    }
    
    return array;
}

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write(array[i]);
    }
    Console.Write("]");
}

string[] arr = CreateArray(size);
PrintArray(arr);
string[] CreateArray()
{
    System.Console.Write("Введите количество элементов массива (целое положительное число): ");
    int size = Convert.ToInt32(Console.ReadLine());

    string[] array = new string[size];

    for (int i = 0; i < size; i++)
    {
        System.Console.Write($"Элемент № {i + 1}: ");
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

string[] NumberOfCharacters(string[] array)
{
    int count = default;
    string[] arrayTwo = new string[array.Length];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            arrayTwo[count] = array[i];
            count++;
        }
    }
    return arrayTwo;
}

string[] arr = CreateArray();
string[] arr2 = NumberOfCharacters(arr);
PrintArray(arr);
Console.Write(" -> ");
PrintArray(arr2);
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

string[] arr = CreateArray(size);
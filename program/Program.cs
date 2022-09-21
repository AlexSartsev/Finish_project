string[] CreateArray()
{
    string[] array = new string[] {"hello", "2", "world", ":-)", "1234", "1567",
                                     "-2", "computer science", "Russia", "Denmark", "Kazan"};
    
    return array;
}

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            if (i < array.Length - i) Console.Write($"{array[i]}, ");
            else Console.Write(array[i]);
        }
    }
    Console.Write("]");
}

string[] arr = CreateArray();
PrintArray(arr);
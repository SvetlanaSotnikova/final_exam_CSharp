string[] CreareArray(int count)
{
    string[] UserArray = new string[count];
    for (int i = 0; i < count; i++)
    {
        Console.Write($"Input line {i + 1}: ");
        UserArray[i] = Console.ReadLine();
    }
    return UserArray;
}

void WriteArray(string[] array)
{ 
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"\"{array[i]}\"");
        if (i < array.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.Write(" ]");
    
    // ну или так :D
    // string result = "[ " + string.Join(", ", array.Select(s => $"\"{s}\"")) + " ]";
    // Console.Write(result);
    
}

string[] FilterArray(string[] Array)
{
    string[] doneArray = new string[Array.Length];

    int count = 0;
    for (int i = 0; i < Array.Length; i++)
    {
        string str = Array[i];

        if (str.Length <= 3)
        {
            doneArray[count] = str;
            count++;
        }
    }
    string[] finalArray = new string[count]; // удаление пустых строк [как вы и просили, массивом все :( ]
    for (int i = 0; i < count; i++)
    {
        finalArray[i] = doneArray[i];
    }
    return finalArray;
}

Console.Write("Input the count of lines: ");
while (true)
{
    int count;

    if (int.TryParse(Console.ReadLine(), out count))
    {
        string[] ResultArray = CreareArray(count);
        Console.WriteLine();
        WriteArray(ResultArray);

        string[] ResultFilterArray = FilterArray(ResultArray);
        Console.Write(" -> ");
        WriteArray(ResultFilterArray);
        break;
    }
    else
    {
        Console.WriteLine("Please enter a valid number( ");
        Console.WriteLine();
    }
}
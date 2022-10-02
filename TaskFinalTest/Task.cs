
string[] GetArray(int size)
{
    string[] result = new string[size];

    for (int i = 0; i < size; i++)
    {
        Console.Write($"Enter {i + 1} element of the array: ");
        result[i] = Console.ReadLine();
    }
    return result;
}

string[] SortArray(string[] array)
{
    string result = String.Empty;
    int elementLength = 3;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= elementLength)
        {
            if (result.Length > 0) result += ", ";
            result += $"{array[i]}";
        }
    }   
    return result.Split(", ");
}

Console.Write("Enter the number of array elements: ");
int sizeArray = Convert.ToInt32(Console.ReadLine());

string[] myArray = GetArray(sizeArray);
string[] newArray = SortArray(myArray);

Console.WriteLine($"[{string.Join(", ", myArray)}] -> [{string.Join(", ", newArray)}]");

string[] FillArray()
{
    Console.WriteLine("Введите элементы первичного массива: ");
    var array = Console.ReadLine().Split(" ");
    return array;
}

string[] ELement3signs(string[] array)
{
    string index = String.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            index += " " + array[i];
        }
    }
    var FinalArray = index.Split(" ");
    return FinalArray;
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(" " + array[i]);
    }
}


string[] array = FillArray();
string[] FinalArray = ELement3signs(array);
PrintArray(FinalArray);
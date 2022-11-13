Console.Clear();

string[] CreateArray()
{
    string[] array = new string[new Random().Next(2, 11)];
    return array;
}

string CreateRngString()
{
    Random generator = new Random();

    int stringlen = generator.Next(1, 11);
    int randValue;
    string str = string.Empty;
    char letter;

    for (int i = 0; i < stringlen; i++)
    {
        randValue = generator.Next(0, 26);
        letter = Convert.ToChar(randValue + 65);
        str = str + letter;
    }

    return str;
}

void FillArray(string[] collection)
{
    for(int i = 0; i < collection.Length; i++)
    {
        collection[i] = CreateRngString();
    }
}

string[] arr = CreateArray();
FillArray(arr);
Console.Write(String.Join(", ", arr));

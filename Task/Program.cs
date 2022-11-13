Console.Clear();
Random generator = new Random();

string[] CreateArray()
{
    string[] array = new string[generator.Next(2, 11)];
    return array;
}

string CreateRngString()
{
    int stringLen = generator.Next(1, 11);
    int randValue;
    string str = string.Empty;
    char letter;

    for (int i = 0; i < stringLen; i++)
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

int NewArrayLen(string[] array)
{
    int count = 0;

    for(int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            count++;
        }
    }

    return count;
}


string[] arr = CreateArray();
FillArray(arr);
Console.WriteLine(String.Join(", ", arr));

string[] newArr = new string[NewArrayLen(arr)];

for(int i = 0, j = 0; i < arr.Length; i++)
{
    if (arr[i].Length <= 3)
    {
        newArr[j] = arr[i];
        j++;
    }
}

Console.WriteLine(String.Join(", ", newArr));

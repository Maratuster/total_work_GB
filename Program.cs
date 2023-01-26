string[] GetStringArray(string someString)
{
    string[] array = someString.Split(" ", StringSplitOptions.None);
    return array;
}

string[] GetThreeDigitWords(string[] array)
{
    string[] newArray = {};
    int i=0;
    foreach (var item in array)
    {
        if (item.Length <4 ) 
        {
            Array.Resize(ref newArray, i+1);
            newArray[i] = item;
            i++;
        }
    }

    return newArray;
}

Console.WriteLine("Введите текст для проверки задания:");
string testString = Console.ReadLine();
string[] testText = GetStringArray(testString);
string[] testText2 = GetThreeDigitWords(testText);
Console.WriteLine(string.Join(",", testText));
Console.WriteLine($"[{string.Join(",", testText2)}]");
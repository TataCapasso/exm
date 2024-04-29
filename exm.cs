string[] workArray = FillArray();
string[] resultArray = GenerateNewArray(workArray);
string firstArray = PrintArray(workArray);
string secondArray = PrintArray(resultArray);
Console.WriteLine(firstArray + " -> " + secondArray);

string[] FillArray()
{
    Console.WriteLine("Введите данные через пробел, по окончании ввода нажмите Enter: ");
    string? enterSymbols = Console.ReadLine();
    if (enterSymbols == null) { enterSymbols = ""; };
    char[] separators = new char[] { ',', ' ' };
    string[] workArray = enterSymbols.Split(separators, StringSplitOptions.RemoveEmptyEntries);
    return workArray;
}

string PrintArray(string[] workArray)

{
    string stringArray = "[";
    for (int i = 0; i < workArray.Length; i++)
    {
        if (i == workArray.Length - 1)
        {
            stringArray += $"\"{workArray[i]}\"";
            break;
        }
        stringArray += ($"\"{workArray[i]}\", ");
    }
    stringArray += "]";
    return stringArray;
}

int CountStringSymbols(string[] workArray)
{
    int counter = 0;
    foreach (string item in workArray)
    {
        if (item.Length <= 3)
        {
            counter++;
        }
    }
    return counter;
}
string[] GenerateNewArray(string[] workArray)
{
    int resultArrayLength = CountStringSymbols(workArray);
    string[] resultArray = new string[resultArrayLength];
    int i = 0;
    foreach (string item in workArray)
    {
        if (item.Length <= 3)
        {
            resultArray[i] = item;
            i++;
        }
    }
    return resultArray;
}
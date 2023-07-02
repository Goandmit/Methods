Console.WriteLine("1. Метод разделения строки на слова");
Console.WriteLine();

static string[] SplitText(string userText)
{

    userText = userText + " ";

    string userWord = "";

    string[] userResult = new string[userText.Length];

    int j = 0;

    for (int i = 0; i < userText.Length; i++)
    {
        switch (Convert.ToString(userText[i]))
        {
            case " ":
                userResult[j] = userWord;
                userWord = "";
                j++;
                break;
            default:
                userWord = userWord + userText[i];
                break;
        }
    }

    string[] userResultOptimized = new string[j];

    for (int k = 0; k < j; k++)
    {
        userResultOptimized[k] = userResult[k];
    }

    Console.WriteLine();
    Console.WriteLine("Ваш текст преобразован в набор отдельных слов:");
    return userResultOptimized;
}

static void PrintArray(string[] userArray)
{
    for (int i = 0; i < userArray.Length; i++)
    {
        Console.WriteLine(userArray[i]);
    }
}

Console.WriteLine("Введите текст:");
PrintArray(SplitText(Console.ReadLine()));
Console.WriteLine();
Console.ReadKey();


/////////////////////////////////////////////////


Console.WriteLine("2. Перестановка слов в предложении");
Console.WriteLine();

static string[] textReverse(string userText)
{
    string[] userResult = userText.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);

    Array.Reverse(userResult);

    Console.WriteLine();
    Console.WriteLine("Ваш текст в обратной последовательности:");
    return userResult;    
}

static void PrintArrayOneLine(string[] userArray)
{
    for (int i = 0; i < userArray.Length; i++)
    {
        Console.Write(userArray[i] + " ");
    }
}

Console.WriteLine("Введите текст:");
PrintArrayOneLine(textReverse(Console.ReadLine()));
Console.ReadKey();
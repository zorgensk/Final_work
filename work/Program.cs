void PrintArray(string[] arr) // Метод вывода массива в терминал
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

string userInput = "hello friend how are you ? =)";
string[] arrUser = userInput.Split(' ', ',', '.', ';').ToArray();

string temp = String.Empty;
for (int i = 0; i < arrUser.Length; i++)
{
    if (arrUser[i].Length <= 3)
        temp = temp + " " + arrUser[i];
}

string[] result = temp.Split(' ', StringSplitOptions.RemoveEmptyEntries);
PrintArray(result);

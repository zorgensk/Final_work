void PrintArray(string[] arr) // Метод вывода массива в терминал
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

string s = "hello friend how are you ? =)";
string []arr = s.Split().ToArray();
var newarr = arr.Where(x => x.Length <= 3).ToArray();

 PrintArray(newarr);
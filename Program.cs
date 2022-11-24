
Console.Clear();

string[] array = { "Hello", "2", "world", ":-)", "go", "pen" };
string[] array1 = new string[array.Length];

int maxWordLength = 3;

void MassivPhrases(string[] arr, string[] arr1)
{
  int count = 0;
  for (int i = 0; i < arr.Length; i++)
  {
    if (arr[i].Length <= maxWordLength)
    {
      arr1[count] = arr[i];
      count++;
    }
  }
}

void PrintArray(string[] array)
{
  for (int i = 0; i < array.Length; i++)
  {
    Console.Write(($"{array[i]} "));
  }
  Console.WriteLine();
}
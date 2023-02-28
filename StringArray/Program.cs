string[] arrayString = {"hello", "2", "world", ":-)", "-2", "999", "hey", "hi"};
string[] arrayNewString = new string[arrayString.Length];

void FillShortArray(string[] arrayString, string[] arrayNewString)
{
    int count = 0;
    for (int i = 0; i < arrayString.Length; i++)
    {
    if (arrayString[i].Length <= 3)
        {
        arrayNewString[count] = arrayString[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}
FillShortArray(arrayString, arrayNewString);
PrintArray(arrayNewString);
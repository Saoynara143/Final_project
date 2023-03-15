
string[] array1;
Console.WriteLine("Введите массив строк, через запятую, без пробелов:");
string stroka = Console.ReadLine();
array1 = stroka.Split(',');
string[] array2 = new string[array1.Length];
void SecondArrayWithIF(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
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
    Console.WriteLine();
}
SecondArrayWithIF(array1, array2);
Console.WriteLine("Массив состоящий из строк, чья длинна меньше, либо ровна 3 символа:");
PrintArray(array2);
string [] array = new string [8] {"hi", "hello", "good", "morning", "I", "am", "do", "it"}; 
string [] OtherArray(string[] array)
{
    string[] result = new string[array.Length];
    int count = 0;
    for(int i = 0; i <= array.Length; i++)
    {
        if(array[i].Length <= 3)
        result[count] = array[i];
        count++;
    }
return result;
} 

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
PrintArray(array);


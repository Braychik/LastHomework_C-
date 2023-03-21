Console.Clear();
string [] array = new string [8] {"hi", "hello", "good", "morning", "I", "am", "do", "it"}; 
string[] result = OtherArray(array);

string[] OtherArray(string[] array)
{
    string[] array1 = new string[array.Length];
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3)
        {
            array1[count] = array[i];
            count++;
        }
    }
    return array1;
} 
Console.WriteLine(result);




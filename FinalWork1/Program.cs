string[] Array(int n)
{
    string[] array = new string[n];
    for(int i = 0; i < n; i++)
    {
        array[i] = Console.ReadLine();
    }
    return array;
}

void ShowArray(string[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3)
        {
            Console.Write(array[i] + "\t");
        } 
    }
}

Console.Write("Введите размер массива: ");
int n = Convert.ToInt32(Console.ReadLine());
string[] res = Array(n);
ShowArray(res);

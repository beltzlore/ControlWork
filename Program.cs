string[] ChooseStrings (string[] array1)
{
    string[] array2=new string[array1.Length];
    int t=0;
    for (int i=0;i<array1.Length;++i)
    {
        if (array1[i].Length<=3) 
        {
            array2[t]=array1[i];
            ++t;
        }
    }
    Array.Resize<string>(ref array2, t);
    return array2;
}

void PrintArray(string[] a)
{
for (int i=0;i<a.Length;i++)
    System.Console.Write($"'{a[i]}' ");
System.Console.WriteLine();
}

System.Console.WriteLine("Введите строки, разделённые запятыми: ");
string s=Console.ReadLine();
string[] stringArray=s.Split(',');
string[] shortStrings = ChooseStrings(stringArray);
PrintArray(shortStrings);

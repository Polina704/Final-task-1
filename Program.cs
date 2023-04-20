
string[] s1 = Vvod();
Vivod(s1);
Console.Write($" -> ");
Vivod(Result(s1));


string[] Vvod()
{
    string[] AS;
    int count;
    string s;
    string[] AS2;
    int k = 0;

    Console.WriteLine("Введите строку:");
    count = 0;
    AS = new string[count];
    do
    {
        s = Console.ReadLine();
        if (s != "")
        {
            count++;           
            AS2 = new string[count];

            for (int i = 0; i < AS2.Length - 1; i++)
                AS2[i] = AS[i];


            AS2[count - 1] = s;
            AS = AS2;
        }
        if(s.Length <=3)
        k++;
    } while (s != "");
    return AS;
}

void Vivod(string[] AS)
{
Console.Write($"[");
    for (int i = 0; i < AS.Length; i++)
    {
       Console.Write($"\"{AS[i]}\"");
       if (i < AS.Length-1)
        Console.Write(", ");
    }
    Console.Write($"]");      
}

string[] Result(string[] AS)
{
    int k = 0;
    for (int i = 0; i < AS.Length; i++)
    {
        if(AS[i].Length <=3)
        k++;
    }
    string[] AS2 = new string[k];
    int j = 0;
    for (int i = 0; i < AS.Length; i++)
    {
        if(AS[i].Length <=3)
        {
            AS2[j] = AS[i];
            j++;
        }

    }
    return AS2;
}
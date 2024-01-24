string input = Console.ReadLine();
string result = CheckBrackets(input);
string CheckBrackets(string a)
{
    int count = 0;
    foreach (char c in a)
    {
        if (c == '(')
        {
            count++;
        }
        else if (c == ')')
        {
            count--;
        }
    }
    int count2 = 0;
    foreach (char c in a)
    {
        if (c == '[')
        {
            count2++;
        }
        else if (c == ']')
        {
            count2--;
        }
    }
    int count3 = 0;
    foreach (char c in a)
    {
        if (c == '{')
        {
            count3++;
        }
        else if (c == '}')
        {
            count3--;
        }
    }

    if (count == 0 && count2==0 && count3==0)
    {
        Console.WriteLine("true");
        return "true";
    }
    else
    {
        Console.WriteLine("false");
        return "false";
    }

}


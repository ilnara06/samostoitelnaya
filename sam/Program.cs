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

        if (count == 0)
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


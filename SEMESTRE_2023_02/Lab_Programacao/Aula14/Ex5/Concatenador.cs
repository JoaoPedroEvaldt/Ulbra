class Concatenador {
     public string Concatenar(string str1, string str2)
    {
        return str1 + str2;
    }

    public string Concatenar(string str1, string str2, string str3)
    {
        return str1 + str2 + str3;
    }

    public string Concatenar(params string[] strings)
    {
        string result = "";
        foreach (string str in strings)
        {
            result += str;
        }
        return result;
    }

    public string Concatenar(int num1, int num2)
    {
        return num1.ToString() + num2.ToString();
    }

    
}


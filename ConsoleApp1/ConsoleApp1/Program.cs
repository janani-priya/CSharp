using System;
using System.Text;


public class TextInput
{

    protected StringBuilder input = new StringBuilder();



    protected virtual String Add(char c)
    {

        input.Append(c);

    }

    protected string GetValue()
    {
        Console.WriteLine(input);

    }
}

public class NumberInput : TextInput
{

    protected overrides String Add(char c)
    {
        int number;
        bool success = Int32.TryParse(c, out number);
        if (success)
        {
            base.Add(c);
        }


    }


}

public class UserInput
{
    public static void Main(string[] args)
    {
        TextInput input = new NumericInput();
        input.Add('a');
        input.Add('0');
        Console.WriteLine(input.GetValue());
    }
}
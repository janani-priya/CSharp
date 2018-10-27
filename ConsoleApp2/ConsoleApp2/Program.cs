using System;
using System.Text;


public class TextInput
{

    public StringBuilder input = new StringBuilder();



    public virtual void Add(char c)
    {

        input.Append(c);

    }

    public String GetValue()
    {
       return input.ToString();

    }
}

public class NumberInput : TextInput
{

    public override void Add(char c)
    {
        int number;
        bool success = Int32.TryParse(c.ToString(), out number);
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
        TextInput input = new NumberInput();
        input.Add('1');
        input.Add('a');
        input.Add('0');
        
         Console.WriteLine(input.GetValue());
        Console.ReadLine();
    }
}
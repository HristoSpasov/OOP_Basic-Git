using System.Collections.Generic;
using System.Linq;

public class StackOfStrings
{
    private List<string> data;

    public void Push(string newString)
    {
        this.data.Add(newString);
    }

    public string Pop()
    {
        return "return";
    }

    public string Peek()
    {
        return "return";
    }

    public bool IsEmpty()
    {
        return data.Any();
    }
}
using System;
using System.Collections.Generic;
using System.Text;
class Operation
{
    public string Type;
    public string Data;
    public Operation(string type,string data)
    {
        Type=type;
        Data=data;
    }
}
class TextEditor
{
    private StringBuilder text;
    private Stack<Operation> operations;
    public TextEditor()
    {
        text = new StringBuilder();
        operations = new Stack<Operation>();
    }
    public void Type(string input)
    {
        text.Append(input);
        operations.Push(new Operation("Type",input));
    }
    public void Delete(int n)
    {
        string deleteText= text.ToString(text.Length-n,n);
        text.Remove(text.Length-n,n);
        operations.Push(new Operation("Delete",deleteText));
    }
    public void Undo()
    {
        if (operations.Count == 0)
        {
            return;
        }
        Operation operation = operations.Pop();
        if (operation.Type == "Type")
        {
            text.Remove(text.Length-operation.Data.Length,operation.Data.Length);
        }
        else if (operation.Type == "Delete")
        {
            text.Append(operation.Data);
        }
    }
    public string GetText()
    {
        return text.ToString();
    }
}
class Program
{
    static void Main(string[] args)
    {
        TextEditor e = new TextEditor();
        e.Type("Hello");
        e.Type(" World");
        e.Delete(6);
        Console.WriteLine(e.GetText());
        e.Undo();
        Console.WriteLine(e.GetText());
        e.Undo();
        Console.WriteLine(e.GetText());
        Console.WriteLine(e.GetText());
    }
}
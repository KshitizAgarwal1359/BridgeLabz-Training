using System;
public class PageNode
{
    public string Url;
    public PageNode Prev;
    public PageNode Next;
    public PageNode(string url)
    {
        Url=url;
        Prev=null;
        Next=null;
    }
}
public class BrowserHistory
{
    private PageNode current;
    public BrowserHistory(string homepage)
    {
        current = new PageNode(homepage);
    }
    public void Visit(string url)
    {
        PageNode newPage = new PageNode(url);
        current.Next=null;
        newPage.Prev=current;
        current.Next=newPage;
        current=newPage;
    }
    public string Back(int steps)
    {
        while(steps>0 && current.Prev != null)
        {
            current=current.Prev;
            steps--;
        }
        return current.Url;
    }
    public string Forward(int steps)
    {
        while(steps>0 && current.Next != null)
        {
            current=current.Next;
            steps--;
        }
        return current.Url;
    }
}
class Program
{
    static void Main(string[] args)
    {
        BrowserHistory b = new BrowserHistory("google.com");
        b.Visit("geeksforgeeks.com");
        b.Visit("youtube.com");
        Console.WriteLine(b.Back(1));
        b.Visit("gmail.com");
        Console.WriteLine(b.Back(2));
    }
}
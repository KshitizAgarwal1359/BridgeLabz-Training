using System;
using System.Collections.Generic;
using System.Linq;
public class Ticket
{
    public int Id;
    public string CustomerName;
    public int Priority;
    public Ticket(int id,string customerName,int priority)
    {
        Id=id;
        CustomerName=customerName;
        Priority=priority;
    }
}
public class SupportDesk
{
    private Dictionary<int,Queue<Ticket>> queues;
    public SupportDesk()
    {
        queues = new Dictionary<int, Queue<Ticket>>();
        for(int i = 1; i <= 5; i++)
        {
            queues[i] = new Queue<Ticket>();
        }
    }
    public void AddTicket(Ticket t)
    {
        queues[t.Priority].Enqueue(t);
    }
    public Ticket ServeNext()
    {
        for(int priority = 1; priority <= 5; priority++)
        {
            if (queues[priority].Count > 0)
            {
                return queues[priority].Dequeue();
            }
        }
        return null;
    }
    public List<Ticket> GetPendingSortedByPriority()
    {
        List<Ticket> pending = new List<Ticket>();
        foreach(var queue in queues.Values)
        {
            pending.AddRange(queue);
        }
        pending.Sort((a,b)=>a.Priority.CompareTo(b.Priority));
        return pending;
    }
}
class Program
{
    static void Main()
    {
        SupportDesk desk = new SupportDesk();
        desk.AddTicket(new Ticket(1,"Alice",2));
        desk.AddTicket(new Ticket(2,"Jimmy",1));
        desk.AddTicket(new Ticket(3,"Rahul",2));
        Ticket t1 = desk.ServeNext();
        Console.WriteLine(t1.CustomerName);
        Ticket t2 = desk.ServeNext();
        Console.WriteLine(t2.CustomerName);
        List<Ticket> pending = desk.GetPendingSortedByPriority();
        foreach(Ticket t in pending)
        {
            Console.WriteLine(t.Id+" "+t.CustomerName+" Priority: "+t.Priority);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzDSA.LinkedList.OnlineTicketReservation
{
    class Program1
    {
        public static void Main(String[] args)
        {
            TicketCircularLinkedList ticketSystem = new TicketCircularLinkedList();

            ticketSystem.AddTicket(1, "Aman", "Inception", "A1", DateTime.Now);
            ticketSystem.AddTicket(2, "Riya", "Avatar", "B5", DateTime.Now);
            ticketSystem.AddTicket(3, "Kunal", "Inception", "C3", DateTime.Now);

            Console.WriteLine("\nAll Tickets:");
            ticketSystem.DisplayTickets();

            Console.WriteLine("\nSearch by Customer Name:");
            ticketSystem.SearchByCustomerName("Aman");

            Console.WriteLine("\nSearch by Movie Name:");
            ticketSystem.SearchByMovieName("Inception");

            Console.WriteLine("\nTotal Tickets:");
            ticketSystem.CountTickets();

            Console.WriteLine("\nCancel Ticket:");
            ticketSystem.RemoveByTicketId(2);

            Console.WriteLine("\nUpdated Ticket List:");
            ticketSystem.DisplayTickets();
        }
    }

}

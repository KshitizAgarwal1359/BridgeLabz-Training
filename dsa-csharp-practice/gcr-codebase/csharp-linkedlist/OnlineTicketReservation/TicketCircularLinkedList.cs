using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzDSA.LinkedList.OnlineTicketReservation
{
    class TicketCircularLinkedList
    {
        private TicketNode head;
        private TicketNode tail;

        // Add ticket at end of circular list
        public void AddTicket(int ticketId, string customerName, string movieName, string seatNumber, DateTime bookingTime)
        {
            TicketNode newNode = new TicketNode(ticketId, customerName, movieName, seatNumber, bookingTime);

            if (head == null)
            {
                head = tail = newNode;
                newNode.next = head;
                return;
            }

            tail.next = newNode;
            newNode.next = head;
            tail = newNode;
        }

        // Remove ticket by Ticket ID
        public void RemoveByTicketId(int ticketId)
        {
            if (head == null)
            {
                Console.WriteLine("No tickets booked.");
                return;
            }

            TicketNode current = head;
            TicketNode prev = tail;

            do
            {
                if (current.ticketId == ticketId)
                {
                    if (current == head)
                        head = head.next;

                    if (current == tail)
                        tail = prev;

                    prev.next = current.next;

                    Console.WriteLine("Ticket cancelled successfully.");
                    return;
                }

                prev = current;
                current = current.next;

            } while (current != head);

            Console.WriteLine("Ticket not found.");
        }

        // Display all tickets
        public void DisplayTickets()
        {
            if (head == null)
            {
                Console.WriteLine("No tickets to display.");
                return;
            }

            TicketNode temp = head;
            do
            {
                DisplayTicket(temp);
                temp = temp.next;
            } while (temp != head);
        }

        // Search ticket by Customer Name
        public void SearchByCustomerName(string customerName)
        {
            if (head == null)
            {
                Console.WriteLine("No tickets booked.");
                return;
            }

            TicketNode temp = head;
            bool found = false;

            do
            {
                if (temp.customerName.Equals(customerName, StringComparison.OrdinalIgnoreCase))
                {
                    DisplayTicket(temp);
                    found = true;
                }
                temp = temp.next;
            } while (temp != head);

            if (!found)
                Console.WriteLine("No ticket found for this customer.");
        }

        // Search ticket by Movie Name
        public void SearchByMovieName(string movieName)
        {
            if (head == null)
            {
                Console.WriteLine("No tickets booked.");
                return;
            }

            TicketNode temp = head;
            bool found = false;

            do
            {
                if (temp.movieName.Equals(movieName, StringComparison.OrdinalIgnoreCase))
                {
                    DisplayTicket(temp);
                    found = true;
                }
                temp = temp.next;
            } while (temp != head);

            if (!found)
                Console.WriteLine("No ticket found for this movie.");
        }

        // Count total booked tickets
        public void CountTickets()
        {
            if (head == null)
            {
                Console.WriteLine("Total Tickets: 0");
                return;
            }

            int count = 0;
            TicketNode temp = head;

            do
            {
                count++;
                temp = temp.next;
            } while (temp != head);

            Console.WriteLine($"Total Tickets: {count}");
        }

        // Display single ticket details
        private void DisplayTicket(TicketNode ticket)
        {
            Console.WriteLine(
                $"TicketID: {ticket.ticketId}, Customer: {ticket.customerName}, Movie: {ticket.movieName}, Seat: {ticket.seatNumber}, Time: {ticket.bookingTime}"
            );
        }
    }

}

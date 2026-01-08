using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzDSA.LinkedList.OnlineTicketReservation
{
    class TicketNode
    {
        public int ticketId;
        public string customerName;
        public string movieName;
        public string seatNumber;
        public DateTime bookingTime;
        public TicketNode next;
        public TicketNode(int ticketId, string customerName, string movieName, string seatNumber, DateTime bookingTime) // Constructor to initialize ticket details
        {
            this.ticketId = ticketId;
            this.customerName = customerName;
            this.movieName = movieName;
            this.seatNumber = seatNumber;
            this.bookingTime = bookingTime;
            next = null;
        }
    }

}

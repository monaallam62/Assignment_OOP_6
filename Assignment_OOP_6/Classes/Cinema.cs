using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_OOP_6.Classes
{
    #region Cinema Class
    public partial class Cinema
    {
        private Ticket[] tickets = new Ticket[20];
        private Projector projector = new Projector();

        public void OpenCinema()
        {
            Console.WriteLine("=== Cinema Opened ===");
            projector.Start();
        }

        public void CloseCinema()
        {
            projector.Stop();
            Console.WriteLine("=== Cinema Closed ===");
        }

        public void AddTicket(Ticket t)
        {
            for (int i = 0; i < tickets.Length; i++)
            {
                if (tickets[i] == null)
                {
                    tickets[i] = t;
                    return;
                }
            }
        }

        public Ticket[] GetTickets()
        {
            return tickets;
        }
    }
    #endregion
}

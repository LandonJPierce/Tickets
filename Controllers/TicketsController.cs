using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Tickets.Models;

namespace Tickets.Controllers
{
    public class TicketsController : ApiController
    {
        private TicketDbModel db = new TicketDbModel();

        public IQueryable<Ticket> Get()
        {
            return db.TicketList;
        }
    }
}

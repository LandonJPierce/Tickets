using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Tickets.Models
{
    public partial class TicketDbModel : DbContext
    {
        public TicketDbModel()
            : base("name=TicketDB")
            { }
        public virtual DbSet<Ticket> TicketList { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ticket>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<Ticket>()
                .Property(e => e.Due)
                .IsUnicode(false);

            modelBuilder.Entity<Ticket>()
                .Property(e => e.Priority)
                .IsUnicode(false);

            modelBuilder.Entity<Ticket>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<Ticket>()
                .Property(e => e.AffectedUser)
                .IsUnicode(false);

            modelBuilder.Entity<Ticket>()
                .Property(e => e.Owner)
                .IsUnicode(false);

            modelBuilder.Entity<Ticket>()
                .Property(e => e.Score)
                .IsUnicode(false);
        }

    }
}
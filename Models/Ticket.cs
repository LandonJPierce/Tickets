using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace Tickets.Models
{
    [Table("Ticket")]
    public partial class Ticket
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string Title { get; set; }

        [Required]
        [StringLength(50)]
        public string Due { get; set; }

        [Required]
        [StringLength(50)]
        public string Priority { get; set; }

        [Required]
        [StringLength(50)]
        public string Status { get; set; }

        [StringLength(50)]
        public string AffectedUser { get; set; }

        [StringLength(50)]
        public string Owner { get; set; }

        [Required]
        [StringLength(50)]
        public string Score { get; set; }
    }
}

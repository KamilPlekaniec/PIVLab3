using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace Lab3
{
    public class Zajecia
    {
        public int ID { get; set; }
        [Required]
        [MaxLength(255)]
        [Column("Nazwa przedmiotu")]
        public string Nazwa { get; set; }
        public DateTime GodzinaRozpozcecia { get; set; }

    }
}

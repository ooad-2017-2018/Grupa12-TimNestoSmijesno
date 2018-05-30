using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace LanacHotelaWEBAPI.Models
{
    [Table("Hotel")]
    public class Hotel
    {
        [StringLength(255)]
        public string id { get; set; }

        public DateTimeOffset createdAt { get; set; }

        public DateTimeOffset? updatedAt { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] version { get; set; }

        public bool? deleted { get; set; }

        public string ime { get; set; }
        public string MenadzerId { get; set; }
        public int brojZvjezdica { get; set; }
        public string lokacija { get; set; }
        public string brojTelefona { get; set; }
        public string email { get; set; }

    }
}
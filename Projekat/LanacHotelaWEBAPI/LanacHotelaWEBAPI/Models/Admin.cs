using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace LanacHotelaWEBAPI.Models
{
    [Table("Admin")]
    public partial class Admin
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

        public string prezime { get; set; }

        public string korisnickoIme { get; set; }

        public string sifra { get; set; }

        public string jmbg { get; set; }

        public string datumRodjenja { get; set; }

        public string email { get; set; }

        public string brojTelefona { get; set; }

        public DateTime datumZaposlenja { get; set; }

        public string adminId { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace qlthucung.Models
{
    [Table("LiveStream")]
    public partial class LiveStream
    {
        [Key]
        [Column("idLiveStream")]
        public int IdLiveStream { get; set; }
        [Column("noidunglive")]
        [StringLength(255)]
        public string Noidunglive { get; set; }
        [Column("hinh")]
        [StringLength(255)]
        public string Hinh { get; set; }
        [Column("link")]
        [StringLength(255)]
        public string Link { get; set; }
    }
}
